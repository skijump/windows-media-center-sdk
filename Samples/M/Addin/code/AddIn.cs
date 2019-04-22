using System;
using Microsoft.MediaCenter.TVVM;

/*
 * The code for the Addin object. 
 * 
 *      UserInterface implemented in UserInterface.cs 
 *          Updates the data in the UI based on the data provided by the DataProcessor.
 *          Handles tuning and keyboard presses to navigate between App cells.  
 *      DataProcessor
 *          Receives data from the Data Receiver and populates the UI. 
 *          The data receiver in this sample is implemented in native code as a COM object.          
 *      AppSpecificationDescriptor
 *          Contains helper objects that describe the data for the application. These objects are
 *          used by the UserInterface class to display items in the UI.
 *      AudioStreamSwitcher
 *          Implements a helper object that helps to switch between audio streams when the user navigates
 *          to a different cell.
 * 
 *              
*/

namespace ItvApp
{
    public class AddIn : Microsoft.MediaCenter.TVVM.TVVMbase
    {        
        // DataStream object
        DataProcessor _dataProcessor;
        
        // User interface object
        UserInterface _userInterface;
                
        // Uninitialize components used in this class.
        protected override void CleanUp()
        {
            // Uninitialize the data receiver
            if (null != _dataProcessor)
            {
                _dataProcessor.Uninitialize();
            }

            if (null != _userInterface)
            {
                _userInterface.Uninitialize();
            }

            // Call base.Exit to terminate the addin.
            base.Exit();
        }       

        // Launch the addin
        protected override void Launch()
        {
            try
            {
                // create the user interface
                _userInterface = new UserInterface(this);

                // create the data receiver
                _dataProcessor = new DataProcessor(this, _userInterface);                
                
                // Initialize the data receiver
                _dataProcessor.InitializeAndLaunch();                
            }
            catch (System.Exception)
            {
                throw;
            }            
        }        

        // iTv invalidated the data source. Rerequest the data pointer. 
        public override void InvalidateDataSource()
        {
            if (null != _dataProcessor)
            {
                _dataProcessor.ReaquireDataSource();
            }
        }        
    }
}