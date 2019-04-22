using System;
using System.Runtime.InteropServices;
using AddinDataReceiver;

namespace ItvApp
{
    internal sealed class DataProcessor : AddinDataReceiver.IDataConsumer
    {
        // GUID definitions                                                 
        private Guid s_application_guid = new Guid("{f6b1ed91-7445-ec41-ae77-71dff5517968}");                
        
        // number of cells.
        static int _iNumberOfCells = 0;

        // number of info text format after which we shud stop. [This is tied to the xml file]
        const int _NumberofInfoTextFormat = 3;

        #region AppResources
        private AddinDataReceiverClass _addinDataReceiver;        
        private UserInterface _userInterface;
        private AddIn _addin;
        private AppSpecificationDescriptor _description;
        #endregion AppResources        

        // Constructor
        internal DataProcessor(ItvApp.AddIn app, UserInterface userInterface)
        {            
            _addin = app;            
            _userInterface = userInterface;
            _description = null;
        }

        // Initialize the services and start receiving data
        public void InitializeAndLaunch()
        {
            // Setup the data services.
            if (!SetupDataServices())
            {
                // if we cant setup the data services, exit the addin.
                _addin.Exit();
                return;
            }
        }

        // Uninitialize. Causes all services/components to be recalimed. 
        public void Uninitialize()
        {
            // disconnect data
            TeardownDataServices();            
        }

        // Setup the data services.
        private bool SetupDataServices() 
        {
            try
            {
                // Initialize the UI
                _userInterface.Initialize();

                // Setup the data receiver
                _addinDataReceiver = new AddinDataReceiverClass();                

                // Connect ourselves to the data receiver so that we can start to get the data
                if (_addinDataReceiver is IAddinDataReceiver)
                {
                    if (this is IDataConsumer)
                    {
                        _addinDataReceiver.AdviseConsumer(this as IDataConsumer, s_application_guid);                       
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;            
        }

        // Disconnect from the data services. 
        private void TeardownDataServices() 
        {
            // we no longer need the data interface.

            if (null != _addinDataReceiver)
            {
                if (_addinDataReceiver is IAddinDataReceiver)
                {
                    _addinDataReceiver.UnAdviseConsumer();
                }
            }

            _addinDataReceiver = null;            
        }

        // Called when iTv calls InvalidateDataSource()
        public void ReaquireDataSource()
        {
            if (_addinDataReceiver is IAddinDataReceiver)
            {
                _addinDataReceiver.ReacquireDataSource();
            }
        }        

        // Receive settings for the app.
        public void ReceiveAppData(int iRowCount, int iColCount, int iVideoWidth, int iVideoHeight, int iCellWidth, int iCellHeight)
        {
            if (null == _description)
            {
                _description = new AppSpecificationDescriptor(iRowCount, iColCount, iVideoWidth, iVideoHeight, iCellWidth, iCellHeight);                                
                _iNumberOfCells = iRowCount * iColCount;
            }            
        }

        // Receive data for each Mosaic Cell.
        public void ReceiveCellData(int iRowIndex, int iColIndex, int iAudioPid, int iLeft, int iTop, string tuneString, string programInfo1, string programInfo2, string programInfo3)
        {
            // if we have all the info we need, just ignore.
            if ((null != _description) && (_description.Channels.Count != _iNumberOfCells))
            {
                // create a channel box and populate the data
                ChannelBox box = new ChannelBox(iRowIndex, iColIndex, iAudioPid, iLeft, iTop, (string)tuneString);
                box.AddInfoText(programInfo1);
                box.AddInfoText(programInfo2);
                box.AddInfoText(programInfo3);

                // add this to _description
                _description.Channels.Add(box);

                // we have all our data, so set the UI.
                if (_description.Channels.Count == _iNumberOfCells)
                {
                    _userInterface.UpdateData(_description);
                }
            }
        }

        // Receive data for info text.
        public void ReceiveInfoTextFormat(int iTop, int iLeft, int iWidth, int iFontSize, string sInfoColor, string sInfoFont)
        {
            if ((null != _description) && (_description.InfoTexts.Count < _NumberofInfoTextFormat))
            {
                // create a new InfoTextFormat  
                InfoTextFormat iFormat = new InfoTextFormat();
                iFormat.left = iLeft;
                iFormat.top = iTop;
                iFormat.width = iWidth;
                iFormat.infoFontSize = iFontSize;
                iFormat.infoColor = sInfoColor;
                iFormat.infoFont = sInfoFont;

                // add it to the description.
                _description.InfoTexts.Add(iFormat);
            }
        }
      
        // Datareceiver stop
        public void Stop()
        {            
        }

        // Data Receiver start
        public void Start()
        {
        }
    }   
}

