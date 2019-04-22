using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MediaCenter.Hosting;
using Microsoft.MediaCenter.UI;

namespace Z
{
    public class ZAddIn : IAddInModule, IAddInEntryPoint
    {
        //
        // Initialize (IAddInModule)
        //

        public void Initialize(Dictionary<string, object> appInfo, Dictionary<string, object> entryPointInfo)
        {
        }


        //
        // Uninitialize (IAddInModule)
        //

        public void Uninitialize()
        {
        }


        //
        // Launch (IAddInModule)
        //

        public void Launch(AddInHost host)
        {

            if (host != null && host.ApplicationContext != null)
            {
                host.ApplicationContext.SingleInstance = true;
            }

            s_session = new HistoryOrientedPageSession();
            Application app = new Application(s_session, host);

            // Set the background color
            // Matches Background.C from Syles.mcml
            host.MediaCenterEnvironment.BackgroundColor = System.Drawing.Color.FromArgb(21, 35, 39);

            // Navigate to the main menu.
            app.GoToStartPage();
        }

        private static HistoryOrientedPageSession s_session;
    }
}

