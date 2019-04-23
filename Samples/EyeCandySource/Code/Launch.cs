using System.Collections.Generic;
using Microsoft.MediaCenter.Hosting;

namespace EyeCandy
{
    public class MyAddIn : IAddInModule, IAddInEntryPoint
    {
        private static HistoryOrientedPageSession session;

        public void Initialize(Dictionary<string, object> appInfo, Dictionary<string, object> entryPointInfo)
        {
        }

        public void Uninitialize()
        {
        }

        public void Launch(AddInHost host)
        {
            session = new HistoryOrientedPageSession();
            Application app = new Application(session, host);
            app.Start();
        }
    }
}