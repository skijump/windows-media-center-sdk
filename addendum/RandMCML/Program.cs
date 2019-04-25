using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Timers;

namespace RandMCML
{
    class Program
    {
        static string myMCMLFilePath;

        static string MyMCMLFilePath
        {
            get { return myMCMLFilePath; }
            set { myMCMLFilePath = value; }
        }

        static void Main(string[] args)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            double interval = Convert.ToInt16(args[0]);
            aTimer.Interval = interval;
            aTimer.Enabled = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        // Specify what you want to happen when the Elapsed event is raised.
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string g = Guid.NewGuid().ToString();
            string temp = DateTime.Now.ToUniversalTime().ToString() + " " + g.ToString();
            string filename = "temp1.mcml";

            bool generateBadMCML = false;

            if (g.StartsWith("0") || g.StartsWith("1") || g.StartsWith("2") || g.StartsWith("3") || g.StartsWith("4"))
            {
                generateBadMCML = true;
            }

            if (g.EndsWith("0") || g.EndsWith("1") || g.EndsWith("2") || g.EndsWith("3") || g.EndsWith("4"))
            {
                filename = "temp2.mcml";
            }

            Console.WriteLine(filename + " " + generateBadMCML.ToString() + " " + temp);
            CreateMCML(temp, generateBadMCML, filename);
        }


        static void CreateMCML(string text, bool generateBadMCML, string filename)
        {

            StringBuilder mcmltempfilepath = new StringBuilder();
            mcmltempfilepath.Append(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            mcmltempfilepath.Append(@"\");
            mcmltempfilepath.Append(filename);
            MyMCMLFilePath = mcmltempfilepath.ToString();

            XmlWriter writer = null;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            writer = XmlWriter.Create(MyMCMLFilePath, settings);

            string mcmlNamespace = @"http://schemas.microsoft.com/2006/mcml";

            writer.WriteStartElement("Mcml", mcmlNamespace);
            if (filename == "temp1.mcml")
            {
                writer.WriteAttributeString("xmlns", "other", null, "file://temp2.mcml");
            }
            
            writer.WriteStartElement("UI");
            writer.WriteAttributeString("Name", "Default");

            writer.WriteStartElement("Content");

            if (filename == "temp1.mcml")
            {
                writer.WriteStartElement("Panel");
                writer.WriteAttributeString("Layout", "VerticalFlow");
                writer.WriteStartElement("Children");
            }

            writer.WriteStartElement("Text");
            writer.WriteAttributeString("Name", "MyText");
            writer.WriteAttributeString("Content", text);
            writer.WriteAttributeString("Color", "White");
            writer.WriteEndElement();

            if (filename == "temp1.mcml")
            {
                writer.WriteElementString("other", "Default", null, null);
            }

            if (generateBadMCML)
            {
                writer.WriteStartElement("BadMCML");
            }

            // Panel and Children
            if (filename == "temp1.mcml")
            {
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            // Content
            writer.WriteEndElement();

            // UI
            writer.WriteEndElement();

            // MCML
            writer.WriteEndElement();

            writer.Flush();

            writer.Close();
        }
    }
}
