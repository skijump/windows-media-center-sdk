using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace McmlPadAuto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Uri uri = new Uri(Application.ExecutablePath);
            if (uri.LocalPath.StartsWith("\\\\"))
            {
                System.Windows.Forms.MessageBox.Show(McmlPadAuto.Resources.StringMCMLPreviewToolLauncher + " only runs from the local machine.", McmlPadAuto.Resources.StringMCMLPreviewToolLauncher);
            }
            else
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(args));
            }
        }
    }
}