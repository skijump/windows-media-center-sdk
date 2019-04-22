using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.MediaCenter;
using Microsoft.MediaCenter.Hosting;
using Microsoft.MediaCenter.UI;

namespace $safeprojectname$
{
    public class Application : ModelItem
    {
        private AddInHost host;

	public Application(AddInHost host)
	{
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
		string temp = "The background application did something.";     
		DialogTest(temp);
	}	

        public void DialogTest(string strClickedText)
        {
            int timeout = 5;
            bool modal = true;
            string caption = Resources.DialogCaption;

            if (host != null)
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
    }
}