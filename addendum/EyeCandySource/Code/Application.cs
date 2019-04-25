using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.MediaCenter;
using Microsoft.MediaCenter.Hosting;
using Microsoft.MediaCenter.UI;
using System.Threading;

namespace EyeCandy
{
    public class Application : ModelItem
    {
        private AddInHost host;
        private HistoryOrientedPageSession session;
        private string windowspath = System.Environment.GetEnvironmentVariable("windir");
        private string culture = Thread.CurrentThread.CurrentCulture.IetfLanguageTag;

        public Application()
            : this(null, null)
        {
        }

        public Application(HistoryOrientedPageSession session, AddInHost host)
        {
            this.session = session;
            this.host = host;
        }

        public MediaCenterEnvironment MediaCenterEnvironment
        {
            get
            {
                if (host == null) return null;
                return host.MediaCenterEnvironment;
            }
        }

        public void Start()
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties["Application"] = this;

            if (session != null)
            {
                session.GoToPage("resx://EyeCandy/EyeCandy.Resources/Default", properties);
                MediaCenterEnvironment.PlayMedia(MediaType.Video, @"http://jolt-media/scratch2/charlieo/Phelps400mIndividualMedley.wmv", false);
            }
            else
            {
                Debug.WriteLine("GoToMenu");
            }
        }

        public void DialogTest(string strClickedText)
        {
            int timeout = 5;
            bool modal = true;
            string caption = Resources.DialogCaption;

            if (session != null)
            {

                MediaCenterEnvironment.Dialog(strClickedText,
                                              caption,
                                              new object[] { DialogButtons.Ok },
                                              timeout,
                                              modal,
                                              null,
                                              delegate(DialogResult dialogResult) { });
            }
            else
            {
                Debug.WriteLine("DialogTest");
            }
        }

        public string[] MyData
        {
            get
            {
                return new string[10] { "Alpha", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliet" };
            }
        }
    }
}