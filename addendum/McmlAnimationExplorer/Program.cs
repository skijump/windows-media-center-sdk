using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MCMLAnimationExplorer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Uri uri = new Uri(Application.ExecutablePath);
            if (uri.LocalPath.StartsWith("\\\\"))
            {
                System.Windows.Forms.MessageBox.Show(MCMLAnimationExplorer.Resources.ApplicationName + " only runs from the local machine.", MCMLAnimationExplorer.Resources.ApplicationName);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MCMLAnimationExplorer.Form1());
            }
        }
    }
}