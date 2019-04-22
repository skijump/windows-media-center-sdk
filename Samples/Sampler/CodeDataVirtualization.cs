using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.MediaCenter.UI;

namespace Sampler.CodeData.Virtualization
{
    //
    // EnormoList is an example of an asynchronous virtual list implementation
    // that enables surfacing data of very large lists.
    //
    // Virtual lists have two goals:
    //
    // 1) Only keep data items in the list that are necessary for display of 
    //    what's currently visible in the list. Items are "requested" as needed.
    //
    // 2) Support for requested data that is very slow to acquire.
    //

    public class EnormoList : VirtualList
    {
        //
        // Enormous list construction.
        //

        public EnormoList()
        {
            //
            // In this example list, the item count is initialized to a very large
            // number. It is not necessary to set the count during construction of
            // the list. It can happen at a later time.
            //
            // To wait until the last possible moment to supply the count, use the
            // ItemCountHandler that can be supplied during construction.
            //
            // Yes, we have one hundred thousand items in our list.
            //

            Count = 100000;


            //
            // Set item "release" behavior. When the use scrolls, and visual items 
            // are no longer shown, you may, if you choose, keep the data item
            // around in the virtual list. Obviously, this can get pretty heavy
            // as more data is faulted in. Here, we are setting the behvavior
            // to have it 1) release the reference, and 2) dispose the item.
            //
            // NOTE: The is the behavior when visuals get released. Visuals
            // only get released if the Repeater is configured to
            // "DiscardOffscreenVisuals".
            //

            VisualReleaseBehavior = ReleaseBehavior.Dispose;


            //
            // This list demonstrates not only large data sets, but data that is
            // slow to acquire. This means, we need to use virtual list's
            // "slow data" request service.
            //

            EnableSlowDataRequests = true;


            //
            // Pictures for the thumbnails are generated at runtime. Temporary files
            // are used to construct the images. The lifetime of the temporary file
            // is tied to that of the data item. But, if the application is
            // terminated prematurely, some temporary files can be left over. This
            // will clear those leftovers out.
            //

            ClearLeftoverPictureFiles();
        }


        //
        // Item Request
        //
        // The repeater is ready to build visuals for the data at the specified
        // index. An index is queried if the visual representation of that item
        // is ready to be displayed. You are given a delegate to call back on
        // to report the data item.
        //
        // NOTE: Never block within this call and always call the callback delegate
        //       on this (the application) thread!
        //
        // Depending on your data situation, you may choose to:
        //
        // 1) Call the callback immediately (recommended):
        //
        // If you call the callback immediately, your are providing the required
        // data item right now. However, you don't have to guarantee that the
        // data item is complete (in which case, you can fill in with "placeholder"
        // data). The benefit of an immediate return (even if it's partial data) is 
        // that there will always be something on the screen for the user to see and
        // interact with.
        //
        // In general, you should build a data item and populate it with only
        // data that can be queried quickly. Any data that is too slow to get
        // during this call should be provided in the "update" callback.
        // 
        // 2) Call callback at a later time:
        //
        // If you call the callback later, the negative is that the user will 
        // see a "hole" in the list while you fetch the data on a worker thread.
        // Although this is supported, it's not recommended. Make sure to always
        // call the callback back on the main application thread.
        //

        protected override void OnRequestItem(int index, ItemRequestCallback callback)
        {
            //
            // Build the data item and initialize it with data that
            // is quick to get (in this case, the caption).
            //
            // Notice how the VirtualList is passed to the ThumbnailData. This is
            // so every ModelItem created (in this case, the ThumbnailData) gets 
            // assigned an owner. This is important since when the VirtualList gets
            // disposed, the ThumbnailData will also get disposed automatically.
            //

            ThumbnailData t = new ThumbnailData(this, index.ToString(CultureInfo.CurrentUICulture));


            //
            // Inform the list.
            //

            callback(this, index, t);
        }


        //
        // Slow Data Request
        //
        // In the recommended configuration, a data item will always be returned
        // quickly from OnRequestItem. This data may be partially complete. In
        // which case, the rest of the data needs to be acquired.
        //
        // This callback is enabled using 'EnableSlowDataRequests'. Technically,
        // you can acquire your own slow data and finish off your data items
        // on your own time. But, the benefit of using this callback is that
        // the platform will inform you of prior requested items that the user
        // is "interested" in. Interest is determined by several factors (the
        // current focus being one of them).
        //
        // NOTE: DO NOT BLOCK WITHIN THIS CALL!
        //
        // The whole purpose of this callback is for you to acquire your slowest 
        // of data. For this reason, you should only be sending requests to 
        // worker threads of this callback. Then, when you are done, your data
        // is committed using another callback which gets invoked on the
        // application thread.
        //

        protected override void OnRequestSlowData(int index)
        {
            //
            // OnRequestSlowData can be called multiple times for the same index
            // if the data item is thrown away and brought back by movement in
            // the list by the user. For this reason, there may be a pending
            // picture acquire going on right now. Check if this is the case.
            //

            if (_pendingPictureAcquires.ContainsKey(index))
            {
                return;
            }


            SlowDataResult result = new SlowDataResult();
            result.Index = index;

            _pendingPictureAcquires[index] = result;


            //
            // Best practice: Use DeferredInvokeOnWorkerThread.
            //
            // The first param is a delegate that is called on the worker thread.
            //
            // The second param is a delegate that is called on the application thread
            // (after the worker thread is complete).
            //
            // Data (results) are passed between these callbacks via the third param
            // (the args).
            //

            Microsoft.MediaCenter.UI.Application.DeferredInvokeOnWorkerThread(AcquireSlowData, StoreSlowData, result);
        }


        //
        // Acquire the slow data.
        //
        // THIS CALL HAPPENS ON A WORKER THREAD. Never call any MCML object from a
        // worker thread.
        //

        private static void AcquireSlowData(object args)
        {
            //
            // Heavy operation: Build our randomly-generated snow flake image.
            //

            ThreadPriority priority = Thread.CurrentThread.Priority;
            try
            {
                Thread.CurrentThread.Priority = ThreadPriority.Lowest;

                SlowDataResult result = (SlowDataResult)args;

                FractalSnow.SnowFlake flakeGenerator = new FractalSnow.RandomSnowFlake(100, result.Index);
                flakeGenerator.Antialiasing = true;

                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(100, 100);
                System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);

                flakeGenerator.Draw(graphics, new System.Drawing.PointF(50, 50));

                string flakePicture = Path.GetTempPath() + result.Index.ToString(CultureInfo.InvariantCulture) + "." + TempPictureFileExtension;
                bitmap.Save(flakePicture, System.Drawing.Imaging.ImageFormat.Png);

                graphics.Dispose();
                bitmap.Dispose();

                //
                // The locatation of the generated file 
                //

                result.PicturePath = flakePicture;
            }
            finally
            {
                Thread.CurrentThread.Priority = priority;
            }
        }


        //
        // Slow data is ready.
        //
        // This call occurs after the worker thread is complete and the results
        // are ready.
        //
        // NOTE: THIS CALL CAN HAPPEN AFTER THE VIRTUAL LIST HAS BEEN DISPOSED.
        //
        // Take care during this type of callback. It's asynchronous and you can't
        // make assumptions about the validity of the virtual list (or the data items
        // within it).
        //

        private void StoreSlowData(object args)
        {
            SlowDataResult result = (SlowDataResult)args;

            //
            // Remove tracking for pending picture acquires.
            //

            _pendingPictureAcquires.Remove(result.Index);


            //
            // If the VirtualList has been disposed before this callback is received,
            // or if the data item specified by the index has been thrown away, then
            // clean up the picture file.
            //
            // Note that we need to check IsItemAvailable() instead of just calling
            // the indexer and checking for null.  This is because doing that query 
            // can cause the item to be faulted in after it'd already been thrown 
            // away due to going offscreen.
            //

            if (IsDisposed || !IsItemAvailable(result.Index))
            {
                if (result.PicturePath != null)
                {
                    File.Delete(result.PicturePath);
                }

                return;
            }


            //
            // All is well, tell the ThumbnailData about this new picture.
            //

            ThumbnailData t = (ThumbnailData)this[result.Index];
            t.SetPicture(result.PicturePath);
        }


        //
        // The shared results data with the worker thread.
        //

        private class SlowDataResult
        {
            public int Index;
            public string PicturePath;
        }


        //
        // Wipe out all temporary files that may have been left over from
        // a previous run. Left over files can occur if the application
        // was terminated prematurely.
        //

        private void ClearLeftoverPictureFiles()
        {
            DirectoryInfo d = new DirectoryInfo(Path.GetTempPath());
            foreach (FileInfo f in d.GetFiles("*." + TempPictureFileExtension))
            {
                f.Delete();
            }
        }


        private Dictionary<int, object> _pendingPictureAcquires = new Dictionary<int, object>();
        private const string TempPictureFileExtension = "acdv";
    }


    //
    // Thumbnail data items for the EnormoList.
    //

    public class ThumbnailData : ModelItem
    {
        //
        // ThumbnailData requires an owner. That way, its Dispose will
        // get called when its owner's Dispose gets called.
        //
        // This is important since resources need to get freed.
        //

        public ThumbnailData(IModelItemOwner owner, string caption)
            :
            base(owner)
        {
            _caption = caption;
        }


        //
        // The thumbnail caption (accessed via markup).
        //

        public string Caption
        {
            get
            {
                return _caption;
            }
        }


        //
        // The picture to display (access via markup).
        //

        public Image Picture
        {
            get
            {
                return _picture;
            }
        }


        //
        // The temporary location (on disk) where the picture lives.
        //
        // This file must be kept around for the lifetime of the Image.
        // The Image may refer back to it if needed.
        //

        public void SetPicture(string picturePath)
        {
            _picturePath = picturePath;

            _picture = new Image("file://" + picturePath);

            FirePropertyChanged("Picture");
        }


        //
        // This ModelItem is being Diposed for the following reasons:
        //
        //   1) All visuals for this item have been released (they are offscreen), or
        //   2) The owner (VirtualList) is being disposed.
        //
        // Dipose the Image and throw away the temporary file.
        //

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                if (_picture != null)
                {
                    _picture.Dispose();
                    _picture = null;
                }

                if (_picturePath != null)
                {
                    File.Delete(_picturePath);
                    _picturePath = null;
                }
            }
        }


        private string _caption;

        private string _picturePath;
        private Image _picture;
    }
}