using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

using Microsoft.MediaCenter.TVVM;
using Microsoft.MediaCenter.UI;

namespace ItvApp
{
    #region KeyboardHandlerDelegate
    // Delegate to handle keyboard strokes and tuning events
    internal class EventHandlerDelegate : MarshalByRefObject
    {
        // TVVM objects
        OverlaySurface _overlaySurface;
        Tuning _tuning;
        PlaybackSession _session;        
        KeyCommandEventHandler _eKeyboardHandler;
        PropertyChangedEventHandler _eChannelChangeHandler;
        PropertyChangedEventHandler _eOverlaySurfaceChangeHandler;
       
        // handle to the M.Userinterface
        UserInterface _userInterface;

        // Constructor
        internal EventHandlerDelegate(PlaybackSession session, Tuning tuning, OverlaySurface overlaySurface, UserInterface userInterface)
        {
            _tuning = tuning;
            _session = session;
            _overlaySurface = overlaySurface;
            _userInterface = userInterface;
            _eKeyboardHandler = null;
            _eChannelChangeHandler = null;
        }

        // Initialize members
        public void Initialize()
        {
            AddKeyboardHandlerDelegate();
            AddChannelChangeHandlerDelegate();
            AddOverlaySurfaceHandlerDelegate();
        }

        // UnInitialize members
        public void UnInitialize()
        {
            RemoveKeyboardHandlerDelegate();
            RemoveChannelChangeHandlerDelegate();
            RemoveOverlaySurfaceHandlerDelegate();
        }

        // Add our keyboard handler
        private void AddKeyboardHandlerDelegate()
        {
            if (null == _eKeyboardHandler)
            {
                _eKeyboardHandler = new KeyCommandEventHandler(ProcessSessionEvents);
                _session.KeyCommandEvent += _eKeyboardHandler;
            }
        }

        // Remove our keyboard handler
        private void RemoveKeyboardHandlerDelegate()
        {
            if (null != _eKeyboardHandler)
            {
                _session.KeyCommandEvent -= _eKeyboardHandler;
                _eKeyboardHandler = null;
            }            
        }

        // Add our ChannelChange handler
        private void AddChannelChangeHandlerDelegate()
        {
            if (null == _eChannelChangeHandler)
            {
                _eChannelChangeHandler = new PropertyChangedEventHandler(ProcessTuningEvents);
                _tuning.PropertyChanged += _eChannelChangeHandler;
            }
        }

        // Remove our ChannelChange handler
        private void RemoveChannelChangeHandlerDelegate()
        {
            if (null != _eChannelChangeHandler)
            {
                _tuning.PropertyChanged -= _eChannelChangeHandler;
                _eChannelChangeHandler = null;
            }
        }

        // Add our ChannelChange handler
        private void AddOverlaySurfaceHandlerDelegate()
        {
            if (null == _eOverlaySurfaceChangeHandler)
            {
                _eOverlaySurfaceChangeHandler = new PropertyChangedEventHandler(ProcessOverlaySurfaceEvents);
                _overlaySurface.PropertyChanged += _eOverlaySurfaceChangeHandler;
            }
        }

        // Remove our ChannelChange handler
        private void RemoveOverlaySurfaceHandlerDelegate()
        {
            if (null != _eOverlaySurfaceChangeHandler)
            {
                _overlaySurface.PropertyChanged -= _eOverlaySurfaceChangeHandler;
                _eOverlaySurfaceChangeHandler = null;
            }
        }

        // Our Keyboard Handler. Ensure that the key that was pressed is something that we can handle.
        public bool ProcessSessionEvents(object sender, KeyCommandEventArgs args)
        {
            if (null != args)
            {
                // ensure that there are no control keys with the keystroke and we only process up,down, left, right keys
                if ((args.InputModifiers == Microsoft.MediaCenter.TVVM.InputModifiers.None) &&
                    (args.State == Microsoft.MediaCenter.TVVM.KeyCommandState.Down) &&  // CHECK IF WE NEED THIS
                    ((args.Key == Microsoft.MediaCenter.TVVM.KeyHandlerKey.Up) ||
                     (args.Key == Microsoft.MediaCenter.TVVM.KeyHandlerKey.Down) ||
                     (args.Key == Microsoft.MediaCenter.TVVM.KeyHandlerKey.Left) ||
                     (args.Key == Microsoft.MediaCenter.TVVM.KeyHandlerKey.Right) ||
                     (args.Key == Microsoft.MediaCenter.TVVM.KeyHandlerKey.Return)))
                {
                    _userInterface.ProcessKeyboardEvent(args);
                    // we know that these keys are handled, so return true
                    return true;
                }
            }
            return false;                    
        }

        // Our Tuning handler. Will get called when a tune happens. [Channel change begin/end]
        public void ProcessTuningEvents(object sender, string property)
        {
            // Someone tried to tune)
            if (_tuning.ChannelState == ChannelState.TuneInProgress)
            {
                // let the UI know that it has to hide itself
                _userInterface.QuitAddin();
            }
        }

        // Our OverlaySurface handler. Will get called when overlay surface changes
        public void ProcessOverlaySurfaceEvents(object sender, string property)
        {
            if (null != _userInterface)
            {
                _userInterface.ProcessOverlayChange();
            }
        }
    }
    #endregion KeyboardHandlerDelegate        

    internal sealed class UserInterface
    {
        // Helper Objects
        AudioStreamSwitcher _audioStreamSwitcher;
        AppSpecificationDescriptor _description;
        EventHandlerDelegate _eventHandler;        
        ItvApp.AddIn _addin;
        
        // TVVM Objects
        OverlaySurface _overlaySurface;
        VideoSurface _videoSurface;
        PlaybackSession _session;
        Tuning _tuning;    
        
        // Currently selected cell.
        int _selectionX;
        int _selectionY;

        internal enum AspectRatios
        {
            AspectRatio_16x10,
            AspectRatio_16x9,
            AspectRatio_4x3
        }

        private const double aspectRatioBoundary16x10 = 1.55555555555555555;
        private const double aspectRatioBoundary16x9 = 1.68888888888888888;

        // Constructor
        internal UserInterface(ItvApp.AddIn addin)
        {
            _addin = addin;

            _overlaySurface = _addin.OverlaySurface;
            _videoSurface = _addin.VideoSurface;
            _tuning = _addin.Tuning;
            _session = _addin.Session;
                        
            // create the object to receive keyboard hits.
            _eventHandler = new EventHandlerDelegate(_session, _tuning, _overlaySurface, this);

            // create a new audiostreamswticher
            _audioStreamSwitcher = new AudioStreamSwitcher(addin);            
        }

        // Initilize method to initialize the members
        public void Initialize()
        {            
            // Requestr the overlaySurface to allocate a region.
            Microsoft.MediaCenter.UI.Size size = new Microsoft.MediaCenter.UI.Size(1200, 800);
            _overlaySurface.Allocate(size, true, true);

            // the user cannot override the zoom or rendering will be off
            _videoSurface.SetUserZoomModeOverride(false);

            // Initialize the audio stream.
            _audioStreamSwitcher.Initialize();

            // Add delegate to handle events.
            _eventHandler.Initialize();

            // Reset the selection to 0,0
            _selectionX = 0;
            _selectionY = 0;
        }

        // Initilize method to uninitialize the members
        public void Uninitialize()
        {            
            _description = null;

            // delete the overlaySurface.
            if (null != _overlaySurface)
            {
                _overlaySurface.Visible = false;
                _overlaySurface.Free();
                _overlaySurface = null;
            }

            if (null != _videoSurface)
            {
                _videoSurface = null;
            }

            // remove the Tuning object
            if (null != _tuning)
            {
                _tuning = null;
            }            

            // remove the event handler object
            if(null != _eventHandler)
            {
                _eventHandler.UnInitialize();
                _eventHandler = null;
            }

            // delete the session object
            if (null != _session)
            {
                _session = null;
            }
            
            // delete the AudioStreamSwitcher
            if (null != _audioStreamSwitcher)
            {
                _audioStreamSwitcher.Uninitialize();
                _audioStreamSwitcher = null;
            }
        }

        // exit the addin when the user tunes away to a different channel
        public void QuitAddin()
        {
            _addin.Exit();
        }

        // Called by the DataStream when new data is available. 
        public void UpdateData(AppSpecificationDescriptor description)
        {
            // if the existing description is not null, make it null
            if (null != _description)
            {
                _description = null;                
            }

            // set the description to this new value
            _description = description;                  

            // Now make sure that the current selectionX/Y are valid for this page.
            ChannelBox current = _description.Nearest(_selectionX, _selectionY);
            if (current != null)
            {
                _selectionX = current.Column;
                _selectionY = current.Row;                
            }

            // we got data from the receiver. Make ourselves visible
            if (!_overlaySurface.Visible)
            {
                _overlaySurface.Visible = true;
            }

            UpdateDisplayAndAudio();
        }

        public static AspectRatios FromSize(int pixelWidth, int pixelHeight)
        {
            AspectRatios aspectRatios;
            // Calculate based on real pixels
            double aspectRatio = (double)pixelWidth / pixelHeight;
            if (aspectRatio < aspectRatioBoundary16x10)
            {
                aspectRatios = AspectRatios.AspectRatio_4x3;
            }
            else if (aspectRatio < aspectRatioBoundary16x9)
            {
                aspectRatios = AspectRatios.AspectRatio_16x10;
            }
            else
            {
                aspectRatios = AspectRatios.AspectRatio_16x9;
            }
            return aspectRatios;
        }


        // Called after UI _description available
        private void Render()
        {
            AspectRatios ar = FromSize(_overlaySurface.RenderingMode.PlayerViewportSize.Width, _overlaySurface.RenderingMode.PlayerViewportSize.Height);
            if (ar == AspectRatios.AspectRatio_16x10)
            {
                _videoSurface.ZoomMode = ZoomMode.Stretched;
            }
            else
            {
                _videoSurface.ZoomMode = ZoomMode.Normal;
            }
            Microsoft.MediaCenter.UI.Point startPoint = new Microsoft.MediaCenter.UI.Point(0, 0);

            Bitmap image = new Bitmap(1200, 800, PixelFormat.Format32bppArgb);            

            using (Graphics dc = Graphics.FromImage(image))
            {
                ChannelBox current = _description.Lookup(_selectionX, _selectionY);

                if (current == null)
                {                        
                    return;
                }
                                
                int index = 0;
                foreach (InfoTextFormat icb in _description.InfoTexts)
                {
                    SolidBrush brush = new SolidBrush(System.Drawing.Color.FromName(icb.infoColor));
                    Font font = new Font(icb.infoFont, icb.infoFontSize);
                    dc.DrawString(current._infoText[index], font, brush, icb.left, icb.top);
                    index++;
                }

                 // Draw the lines around the chosen cell.

                 SolidBrush brushText = new SolidBrush(System.Drawing.Color.FromName(_description.InfoTexts[0].infoColor));
                 Pen pen = new System.Drawing.Pen(brushText, 6);
                
                 dc.DrawLine(pen, current.Left, current.Top, current.Left + _description.CellWidth, current.Top);
                 dc.DrawLine(pen, current.Left, current.Top, current.Left, current.Top + _description.CellHeight);
                 dc.DrawLine(pen, current.Left, current.Top + _description.CellHeight, current.Left + _description.CellWidth, current.Top + _description.CellHeight);
                 dc.DrawLine(pen, current.Left + _description.CellWidth, current.Top, current.Left + _description.CellWidth, current.Top + _description.CellHeight);
            }                

            _overlaySurface.BeginRegionUpdates();
            _overlaySurface.UpdateRegion(startPoint, image);
            _overlaySurface.EndRegionUpdates();        
        }                      

        // Moving to a different cell results only in the audio stream switch.  Pressing Enter/Ok causes the tune to happen.
        public void ProcessKeyboardEvent(KeyCommandEventArgs args)
        {
            try
            {
                switch (args.Key)
                {
                    // Move Left
                    case Microsoft.MediaCenter.TVVM.KeyHandlerKey.Left:
                        if (_selectionX > 0)
                        {
                            _selectionX--;
                        }
                        break;

                    // Move Right
                    case Microsoft.MediaCenter.TVVM.KeyHandlerKey.Right:
                        if (_selectionX < (_description.Columns - 1))
                        {
                            _selectionX++;
                        }
                        break;

                    // Move Up
                    case Microsoft.MediaCenter.TVVM.KeyHandlerKey.Up:
                        if (_selectionY > 0)
                        {
                            _selectionY--;
                        }
                        break;

                    // Move Down
                    case Microsoft.MediaCenter.TVVM.KeyHandlerKey.Down:
                        if (_selectionY < (_description.Rows - 1))
                        {
                            _selectionY++;
                        }
                        break;

                    // User hit OK/Enter. Tune to the channel and exit the Addin.
                    case Microsoft.MediaCenter.TVVM.KeyHandlerKey.Return:
                        // get the channel box
                        ChannelBox channelBox = _description.Lookup(_selectionX, _selectionY);

                        if (null != channelBox)
                        {
                            // check if this has a valid tune string
                            if (channelBox.TuneString != string.Empty)
                            {
                                // Start tuning request
                                _tuning.Tune(channelBox.TuneString, true);
                                // Call exit. 
                                _addin.Exit();
                                return;
                            }
                        }
                        break;
                }
                UpdateDisplayAndAudio();
            }
            catch (Exception)
            {
            }
        }

        private void UpdateDisplayAndAudio()
        {
            // Update the visuals            
            Render();

            // Update the audible audio stream
            _audioStreamSwitcher.SelectStream(_description.GetAudioPid(_description.Lookup(_selectionX, _selectionY)));
        }

        public void ProcessOverlayChange()
        {
            ThreadPool.QueueUserWorkItem(delegate(Object state) { Render(); }, null);
        }
    }
}
