using System;
using Microsoft.MediaCenter.UI;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Sampler.CodeData.Images
{
    public class Images : ModelItem
    {

        private Microsoft.MediaCenter.UI.Image imageFromStreamPng;
        public Microsoft.MediaCenter.UI.Image ImageFromStreamPng
        {
            get
            {
                return imageFromStreamPng;
            }
            set
            {
                if (imageFromStreamPng != value)
                {
                    imageFromStreamPng = value;
                    FirePropertyChanged("ImageFromStreamPng");
                }
            }

        }

        private Microsoft.MediaCenter.UI.Image imageFromStreamJpg;
        public Microsoft.MediaCenter.UI.Image ImageFromStreamJpg
        {
            get
            {
                return imageFromStreamJpg;
            }
            set
            {
                if (imageFromStreamJpg != value)
                {
                    imageFromStreamJpg = value;
                    FirePropertyChanged("ImageFromStreamJpg");
                }
            }
        }

        private Microsoft.MediaCenter.UI.Image imageFromSystemImagePng;
        public Microsoft.MediaCenter.UI.Image ImageFromSystemImagePng
        {
            get
            {
                return imageFromSystemImagePng;
            }
            set
            {
                if (imageFromSystemImagePng != value)
                {
                    imageFromSystemImagePng = value;
                    FirePropertyChanged("ImageFromSystemImagePng");
                }
            }

        }

        private Microsoft.MediaCenter.UI.Image imageFromSystemImageJpg;
        public Microsoft.MediaCenter.UI.Image ImageFromSystemImageJpg
        {
            get
            {
                return imageFromSystemImageJpg;
            }
            set
            {
                if (imageFromSystemImageJpg != value)
                {
                    imageFromSystemImageJpg = value;
                    FirePropertyChanged("ImageFromSystemImageJpg");
                }
            }
            
        }

        public void SetImages()
        {
            ImageFromStreamJpg = ImageFromStream("jpg");
            ImageFromStreamPng = ImageFromStream("png");
            ImageFromSystemImagePng = ImageFromSystemImage("png");
            ImageFromSystemImageJpg = ImageFromSystemImage("jpg");
        }

        private Microsoft.MediaCenter.UI.Image ImageFromStream(string imageType)
        {
            bool success = true;

            string myImageFullPath = GetFullImagePath(imageType);

            System.Drawing.Image testImage = null;

            System.IO.MemoryStream memStream = new MemoryStream();

            try
            {
                testImage = System.Drawing.Image.FromFile(myImageFullPath);
                testImage.Save(memStream, testImage.RawFormat);
                memStream.Seek(0, SeekOrigin.Begin);
            }
            catch (System.OutOfMemoryException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.ArgumentNullException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.ArgumentException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.Runtime.InteropServices.ExternalException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.IO.IOException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.ObjectDisposedException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }

            if (memStream != null && success)
            {
                WriteDebugMessage("ImageFromStream = " + success.ToString() + " for " + imageType);
                return Microsoft.MediaCenter.UI.Image.FromStream(memStream, null);
            }
            else
            {
                if (memStream != null)
                {
                    memStream.Close();
                }
                return null;
            }

        }

        private Microsoft.MediaCenter.UI.Image ImageFromSystemImage(string imageType)
        {
            bool success = true;

            string myImageFullPath = GetFullImagePath(imageType);

            System.Drawing.Image testImage = null;

            try
            {
                testImage = System.Drawing.Image.FromFile(myImageFullPath);
            }
            catch (System.OutOfMemoryException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }
            catch (System.ArgumentException ex)
            {
                WriteExceptionDebugMessage(ex);
                success = false;
            }

            if (success)
            {
                WriteDebugMessage("ImageFromSystemImage = " + success.ToString() + " for " + imageType);
                return Microsoft.MediaCenter.UI.Image.FromSystemImage(testImage, null);
            }
            else
            {
                return null;
            }
        }

        private string GetFullImagePath(string imageType)
        {
            string publicPicturesPath = GetPath(KnownFolder.PublicPictures);
            string myImageName = null;

            switch (imageType)
            {
                case "jpg":
                    myImageName = @"Photo02.jpg";
                    break;

                case "png":
                    myImageName = @"Photo11.png";
                    break;
            }

            string myImageFullPath = publicPicturesPath + @"\Windows Media Center SDK\" + myImageName;

            return myImageFullPath;
        }

        private void WriteDebugMessage(string message)
        {
            Debug.WriteLine("Sampler: " + message);
        }

        private void WriteExceptionDebugMessage(System.Exception ex)
        {
            Debug.WriteLine("Sampler: " + ex.ToString());
        }

        // -------------------------------------------------------

        // http://www.pinvoke.net/default.aspx/shell32.SHGetKnownFolderPath

        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);

        public static class KnownFolder
        {
            public static readonly Guid PublicPictures = new Guid("B6EBFB86-6907-413C-9AF7-4FC2ABF07CC5");
        }

        private string GetPath(Guid folder)
        {
            string value = "";
            IntPtr pPath;
            if (SHGetKnownFolderPath(folder, 0, IntPtr.Zero, out pPath) == 0)
            {
                value = System.Runtime.InteropServices.Marshal.PtrToStringUni(pPath);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(pPath);
            }
            return value;
        }

        // -------------------------------------------------------
    }
}
