// Copyright Microsoft Corporation

using System.Collections.Generic;
using Microsoft.MediaCenter.Hosting;
using System.Diagnostics;
using System;

namespace PowerPlaylist
{
    public class MyAddIn : IAddInModule, IAddInEntryPoint
    {
        private string id;

        public void Initialize(Dictionary<string, object> appInfo, Dictionary<string, object> entryPointInfo)
        {
            id = entryPointInfo["id"].ToString();
            Debug.WriteLine(id);
        }

        public void Uninitialize()
        {
        }

        public void Launch(AddInHost host)
        {
            string dataFile = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Microsoft\PowerPlaylist2\Data\Data.xml";
            Application app = new Application(host);

            app.id = id;
            app.DataFile = dataFile;
            app.Start();
        }
    }
}