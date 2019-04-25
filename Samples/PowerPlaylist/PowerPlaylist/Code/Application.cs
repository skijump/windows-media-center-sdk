// Copyright Microsoft Corporation

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.MediaCenter;
using Microsoft.MediaCenter.Hosting;
using System.Data;
using System.Xml;
using System.IO;
using System.Threading;

namespace PowerPlaylist
{
    public class Application
    {
        private AddInHost host;
        private DataSet dataSet;
        public string id;
        private static HistoryOrientedPageSession session;

        private string dataFile;
        public string DataFile
        {
            get { return dataFile; }
            set { dataFile = value; }
        }

        enum DataColumnPath
        {
            ContentPath = 1,
            SlideshowPath,
            VisualizationPath
        };

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
            Debug.Print("Start");
            LoadData();
            StartPlaylist();
        }

        private void LoadData()
        {
            Debug.WriteLine("LoadData");
            try
            {
                if (DataFile != null)
                {
                    XmlReader xmlReader = XmlReader.Create(DataFile);
                    dataSet = new DataSet();
                    dataSet.ReadXml(xmlReader);
                    xmlReader.Close();
                }
            }
            catch (System.Security.SecurityException)
            {
                MessageBox("You do not have sufficient permissions to access the location of the XML data.");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox("The data file does not appear to exist.");
            }
            catch (System.UriFormatException)
            {
                MessageBox("The path to the data file doesn't appear to be valid.");
            }
        }

        private void StartPlaylist()
        {
            Debug.WriteLine("StartPlaylist");
            int rowid = 0;
            string contentpath;
            string slideshowpath;
            string visualizationpath;

            Debug.WriteLine("Evaluating EntrypointID");
            switch (id)
            {
                // Even though the registration GUIDs have ALL CAPS
                // they are written to the registry with lower case.
                // These should match exactly what is shown in the
                // registry instead of the registration file.
                case "{30f10141-61f8-45b1-b369-1b508d080bd7}":
                    session = new HistoryOrientedPageSession();
                    session.GoToPage("resx://PowerPlaylist/PowerPlaylist.Resources/Default");
                    break;
                case "{dfd75e76-7530-4d0d-a126-71863200a556}":
                    rowid = 1;
                    break;
                case "{b9b49dbf-fb85-4a80-beb7-5732c4ba849e}":
                    rowid = 2;
                    break;
                case "{4a03b055-eea0-466f-b4fd-ae72d41fdb02}":
                    rowid = 3;
                    break;
                case "{f8216194-c5c8-4fc8-98b8-b33ef15b36aa}":
                    rowid = 4;
                    break;
                case "{9580a0b8-f06f-4422-94d2-4aae0a26b3b3}":
                    rowid = 5;
                    break;
            }

            if (rowid <= 5 && rowid >= 1)
            {
                Debug.WriteLine("Getting data from dataset.");
                try
                {
                    DataRow dataRow = GetSingleDataRow(dataSet.Tables["Table"], "ID=" + rowid.ToString());

                    contentpath = (null == dataRow[(int)DataColumnPath.ContentPath]) ? null : dataRow[(int)DataColumnPath.ContentPath].ToString();

                    slideshowpath = (null == dataRow[(int)DataColumnPath.SlideshowPath]) ? null : dataRow[(int)DataColumnPath.SlideshowPath].ToString();

                    visualizationpath = (null == dataRow[(int)DataColumnPath.VisualizationPath]) ? null : dataRow[(int)DataColumnPath.VisualizationPath].ToString();
                }

                catch (System.Exception e)
                {
                    MessageBox("PowerPlaylist had a problem reading the data file and can't continue. Exception: " + e.Message.ToString());
                    return;
                }

                if (!string.IsNullOrEmpty(contentpath))
                {
                    Debug.WriteLine(contentpath);
                    PlayContent(contentpath);
                }

                if (string.IsNullOrEmpty(visualizationpath) && string.IsNullOrEmpty(slideshowpath))
                {
                    // The user has specified only audio content.
                    // Thus we will navgate to the full screen experience.

                    GoFullscreen();
                    return;
                }

                // If the user specifies both visualization and
                // slideshow paths the slideshow will win.

                if (!string.IsNullOrEmpty(slideshowpath))
                {
                    Debug.WriteLine(slideshowpath);
                    StartSlideshow(slideshowpath);
                }

                else
                {
                    if (!string.IsNullOrEmpty(visualizationpath))
                    {
                        Debug.WriteLine(visualizationpath);
                        StartVisualization(visualizationpath);
                    }
                }
            }
        }

        private void GoFullscreen()
        {
            Debug.WriteLine("GoFullscreen");
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(System.TimeSpan.FromSeconds(1));
                if (MediaCenterEnvironment.MediaExperience != null)
                {
                    MediaCenterEnvironment.MediaExperience.GoToFullScreen();
                    break;
                }
            }
        }

        private void NavigateToPictures(string slideshowpath)
        {
            Debug.WriteLine("NavigateToPictures");
            MediaCenterEnvironment.NavigateToPage(PageId.MyPictures, slideshowpath);
        }

        private void StartSlideshow(string slideshowpath)
        {
            Debug.WriteLine("StartSlideshow");
            MediaCenterEnvironment.NavigateToPage(PageId.Slideshow, slideshowpath);
        }

        private void StartVisualization(string visualizationpath)
        {
            Debug.WriteLine("StartVisualization");
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(System.TimeSpan.FromSeconds(1));
                if (MediaCenterEnvironment.MediaExperience != null)
                {
                    MediaCenterEnvironment.NavigateToPage(PageId.Visualizations, visualizationpath);
                    break;
                }
            }
        }

        private static DataRow GetSingleDataRow(DataTable table, string expression)
        {
            Debug.WriteLine("GetSingleDataRow");
            DataRow[] foundRows;
            foundRows = table.Select(expression);
            return foundRows[0];
        }


        private void PlayContent(string content)
        {
            Debug.WriteLine("PlayContent");
            MediaCenterEnvironment.PlayMedia(MediaType.Audio, content, false);
        }

        private void MessageBox(string text)
        {
            Debug.WriteLine("MessageBox");
            int timeout = 10;
            bool modal = true;
            string caption = Resources.DialogCaption;

            if (host != null)
            {

                MediaCenterEnvironment.Dialog(text,
                                  caption,
                                  new object[] { DialogButtons.Ok },
                                  timeout,
                                  modal,
                                  null,
                                  delegate(DialogResult dialogResult) { });
            }
        }
    }
}