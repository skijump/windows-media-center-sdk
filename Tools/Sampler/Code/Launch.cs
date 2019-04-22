using System.Collections.Generic;
using Microsoft.MediaCenter.Hosting;
using Microsoft.MediaCenter.UI;
using Microsoft.MediaCenter;
using System.Data;
using System.Xml;
using System;
using System.IO;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sampler
{
    public class Sampler : IAddInModule, IAddInEntryPoint
    {
        private static HistoryOrientedPageSession session;

        private AddInHost host;

        private bool navRequestPending;
        private object lockObject = new object();

        private string publicDocumentsPath = "";
        private string eHomeFolderPath = "";

        private string publicMusicPath = "";
        public string PublicMusicPath
        {
            get { return publicMusicPath; }
            set { publicMusicPath = value; }
        }

        private string publicVideosPath = "";
        public string PublicVideosPath
        {
            get { return publicVideosPath; }
            set { publicVideosPath = value; }
        }
        
        private string publicPicturesPath = "";
        public string PublicPicturesPath
        {
            get { return publicPicturesPath; }
            set { publicPicturesPath = value; }
        }

        private string id;

        private const string samplerAutomationFile = "SamplerAutomation.xml";

        string automationfile = "";

        private string localContentVideo01;
        public string LocalContentVideo01
        {
            get { return localContentVideo01; }
            set { localContentVideo01 = value; }
        }

        private string localContentVideo02;
        public string LocalContentVideo02
        {
            get { return localContentVideo02; }
            set { localContentVideo02 = value; }
        }

        private string localContentVideo03;
        public string LocalContentVideo03
        {
            get { return localContentVideo03; }
            set { localContentVideo03 = value; }
        }

        private string localContentVideo04;
        public string LocalContentVideo04
        {
            get { return localContentVideo04; }
            set { localContentVideo04 = value; }
        }

        private string[] localContentPlaylistVideo;
        public string[] LocalContentPlaylistVideo
        {
            get { return localContentPlaylistVideo; }
        }

        private string localContentAudio01;
        public string LocalContentAudio01
        {
            get { return localContentAudio01; }
            set { localContentAudio01 = value; }
        }

        private string localContentAudio02;
        public string LocalContentAudio02
        {
            get { return localContentAudio02; }
            set { localContentAudio02 = value; }
        }

        private string localContentAudio03;
        public string LocalContentAudio03
        {
            get { return localContentAudio03; }
            set { localContentAudio03 = value; }
        }

        private string[] localContentPlaylistAudio;
        public string[] LocalContentPlaylistAudio
        {
            get { return localContentPlaylistAudio; }
        }

        private string[] localContentPlaylistMixed;
        public string[] LocalContentPlaylistMixed
        {
            get { return localContentPlaylistMixed; }
        }

        private string localContentPictureLandscape;
        public string LocalContentPictureLandscape
        {
            get { return localContentPictureLandscape; }
            set { localContentPictureLandscape = value; }
        }

        private string localContentPictureLandscapeNoScheme;
        public string LocalContentPictureLandscapeNoScheme
        {
            get { return localContentPictureLandscapeNoScheme; }
            set { localContentPictureLandscapeNoScheme = value; }
        }

        private string localContentPicturePortrait;
        public string LocalContentPicturePortrait
        {
            get { return localContentPicturePortrait; }
            set { localContentPicturePortrait = value; }
        }

        private string localContentPicturePortraitNoScheme;
        public string LocalContentPicturePortraitNoScheme
        {
            get { return localContentPicturePortraitNoScheme; }
            set { localContentPicturePortraitNoScheme = value; }
        }

        private string fourBoxGraphic;
        public string FourBoxGraphic
        {
            get { return fourBoxGraphic; }
            set { fourBoxGraphic = value; }
        }

        private string fourBoxGraphicNoBorder;
        public string FourBoxGraphicNoBorder
        {
            get { return fourBoxGraphicNoBorder; }
            set { fourBoxGraphicNoBorder = value; }
        }

        private string fourBoxGraphicTransparent;
        public string FourBoxGraphicTransparent
        {
            get { return fourBoxGraphicTransparent; }
            set { fourBoxGraphicTransparent = value; }
        }

        private string fourBoxGraphicTransparentNoBorder;
        public string FourBoxGraphicTransparentNoBorder
        {
            get { return fourBoxGraphicTransparentNoBorder; }
            set { fourBoxGraphicTransparentNoBorder = value; }
        }

        private string dataFile;
        public string DataFile
        {
            get { return dataFile; }
            set { dataFile = value; }
        }

        private bool keepCurrentOnBackstack;
        public bool KeepCurrentOnBackstack
        {
            get { return keepCurrentOnBackstack; }
            set
            {
                keepCurrentOnBackstack = value;
                WriteDebugMessage("SetCurrentOnBackstack: " + KeepCurrentOnBackstack.ToString());
            }
        }

        private DataSet dataSet;

        private string InstallationFolder = "";

        private string InstallationFolderSampler = "";

        private ArrayListDataSet Categories;

        private ArrayListDataSet Samples;

        public void Initialize(Dictionary<string, object> appInfo, Dictionary<string, object> entryPointInfo)
        {
            WriteDebugMessage("Initialize");
            id = entryPointInfo["id"].ToString();
            WriteDebugMessage("EntryPoint GUID = " + id);
            WriteDebugMessage("Initialize End");

            // List out the entryPointInfo dictionary to the debug window.

            try
            {
                foreach (KeyValuePair<string, object> kvp in entryPointInfo)
                {
                    WriteDebugMessage(String.Format("{0}{1} = {2}", "entryPointInfo: ", kvp.Key, kvp.Value));
                }
            }
            catch (Exception ex)
            {
                WriteExceptionDebugMessage(ex);
            }

            // List out the appInfo dictionary to the debug window.

            try
            {
                foreach (KeyValuePair<string, object> kvp in appInfo)
                {
                    WriteDebugMessage(String.Format("{0}{1} = {2}", "appInfo: ", kvp.Key, kvp.Value));
                }
            }
            catch (Exception ex)
            {
                WriteExceptionDebugMessage(ex);
            }
        }

        public void Uninitialize()
        {
            WriteDebugMessage("Uninitialize");
        }

        public void Launch(AddInHost host)
        {
            WriteDebugMessage("Launch");

            this.host = host;

            if (host != null && host.ApplicationContext != null)
            {
                WriteDebugMessage("Set SingleInstance = True");
                host.ApplicationContext.SingleInstance = true;
            }

            // List out the capabilities to the debug window.

            Dictionary<string, object> capabilities = host.MediaCenterEnvironment.Capabilities;

            try
            {
                foreach (KeyValuePair<string, object> kvp in capabilities)
                {
                    WriteDebugMessage(String.Format("{0}{1} = {2}", "Capability: ", kvp.Key, kvp.Value));
                }
            }
            catch (Exception ex)
            {
                WriteExceptionDebugMessage(ex);
            }

            session = new HistoryOrientedPageSession();

            Categories = new ArrayListDataSet();

            Samples = new ArrayListDataSet();

            publicDocumentsPath = GetPath(KnownFolder.PublicDocuments);

            SetInstallationFolder();

            SetPaths();

            SetLocalContent();

            SetDataFile();

            LoadDataAndCategories();

            Dictionary<string, object> props = new Dictionary<string, object>();
            props.Add("Session", session);
            props.Add("Categories", Categories);
            props.Add("Sampler", this);

            automationfile = publicDocumentsPath + @"\" + samplerAutomationFile;

            KeepCurrentOnBackstack = true;

            // Look to see if we have a file which tells us to load a specific example.
            // If so, go there.

            switch (id)
            {
                case "{7f1e2adf-5006-44fb-8f3d-095e635ab443}":
                    // Launched from Extras Library (More Programs)
                    WriteDebugMessage("Launched from Extras Library");
                    if (NavigateFromAutomationFile())
                        break;
                    // Else failed to navigate to sample, so fall through for default navigate

                    // Go to the default page for the application.
                    session.GoToPage("resx://Sampler/Sampler.Resources/Default", props);
                    WriteDebugMessage("GoToDefaultPage");
                    break;

                case "{7b42c522-ac1e-4eff-b60b-0e01208551cc}":
                    WriteDebugMessage("Launched from More With This.Audio.Album");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextAlbum");
                    break;

                case "{5f51f6cd-7bd9-48d2-a016-c8dd7b1e82c3}":
                    WriteDebugMessage("Launched from More With This.Audio.Artist");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextArtist");
                    break;

                case "{084c6878-b10b-4453-a707-8025fc2cad77}":
                    WriteDebugMessage("Launched from More With This.Audio.Genre");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextGenre");
                    break;

                case "{e90d1b82-2d5d-4916-8022-52b5c994aa1b}":
                    WriteDebugMessage("Launched from More With This.Audio.Playlist");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextPlaylist");
                    break;

                case "{f06c05c0-7f5a-471a-8560-a35fa243b72e}":
                    WriteDebugMessage("Launched from More With This.Audio.Song");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextSong");
                    break;

                case "{37cc3cf8-c2b9-4da0-aa95-2aac0f37d393}":
                    WriteDebugMessage("Launched from More With This.Picture");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextPicture");
                    break;

                case "{9608152f-4996-4928-9a34-8115d893971e}":
                    WriteDebugMessage("Launched from More With This.Video");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextVideo");
                    break;

                case "{fb69d092-51c7-4a6d-8f87-5b12d1d88c42}":
                    WriteDebugMessage("Launched from More With This.DVD");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextDVD");
                    break;

                case "{33c6fd2f-a538-4604-8242-ce57e6724427}":
                    WriteDebugMessage("Launched from More With This.TV");
                    LaunchMoreWithThis(props, "resx://Sampler/Sampler.Resources/ObjectModelMediaCenterAddInHostMediaContextTV");
                    break;
            }

            SetupWatcher();

            WriteDebugMessage("Launch Complete");

        }

        private void LaunchMoreWithThis(Dictionary<string, object> props, string sample)
        {

            MediaMetadata mediaContext = host.MediaContext;

            try
            {
                foreach (KeyValuePair<string, object> kvp in mediaContext)
                {
                    WriteDebugMessage(String.Format("{0}{1} = {2}","MediaContext: ", kvp.Key, kvp.Value));
                }
            }
            catch (Exception ex)
            {
                WriteExceptionDebugMessage(ex);
            }

            session.GoToPage(sample, props);
        }

        private void SetupWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = publicDocumentsPath;
            watcher.Filter = samplerAutomationFile;
            watcher.IncludeSubdirectories = false;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            try
            {
                watcher.EnableRaisingEvents = true;
                WriteDebugMessage("Watcher: EnableRaisingEvents");
            }
            // If we can't enable raising events just continue without watching for the automation file.
            catch (System.ObjectDisposedException ex)
            {
                WriteExceptionDebugMessage(ex);
            }
            catch (System.PlatformNotSupportedException ex)
            {
                WriteExceptionDebugMessage(ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                WriteExceptionDebugMessage(ex);
            }
            catch (System.ArgumentException ex)
            {
                WriteExceptionDebugMessage(ex);
            }
        }

        void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                if ((e.ChangeType == WatcherChangeTypes.Created) || (e.ChangeType == WatcherChangeTypes.Changed))
                {
                    if (!navRequestPending)
                    {
                        FileInfo fileInfo = new FileInfo(automationfile);
                        EnsureFileIsAvailable(fileInfo);
                        KeepCurrentOnBackstack = false;
                        
                        lock (lockObject)
                        {
                            // Check again, may have changed outside the lock
                            if (!navRequestPending)
                            {
                                // We use a single automation file, so only makes sense to have one pending
                                //  request to use it at a time.
                                navRequestPending = true;
                                Application.DeferredInvoke(new DeferredHandler(NavigateFromAutomationFileDeferred));
                            }
                        }
                    }
                    WriteDebugMessage("Watcher Changed: " + e.ChangeType.ToString());
                }
            }
            catch (System.Exception ex)
            {
                WriteExceptionDebugMessage(ex);
            }
        }

        private static void EnsureFileIsAvailable(FileInfo fileInfo)
        {
            while (true)
            {
                try
                {
                    //try to access the changed file
                    FileStream stream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
                    stream.Close();
                    stream.Dispose();

                    break;
                }
                catch (System.IO.FileNotFoundException)
                {
                    //do nothing, this was probably a temp file
                    break;
                }
                catch (System.IO.IOException)
                {
                    //file must be locked...sleep for a moment and try again
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private string GetAutomationValue(string file)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            string value = "None";

            try
            {
                XmlReader reader = XmlReader.Create(file, settings);

                reader.MoveToContent();
                reader.Read();
                while (reader.NodeType == XmlNodeType.Element)
                {
                    string name = reader.Name;
                    string valueAsString = reader.ReadElementString();

                    switch (name)
                    {
                        case "Sample":
                            value = valueAsString;
                            break;
                    }
                }

                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                WriteExceptionDebugMessage(ex);
            }

            WriteDebugMessage("GetAutomationValue: " + value);

            return value;
        }

        private bool LoadData()
        {
            bool value;

            try
            {
                XmlReader xmlReader = XmlReader.Create(DataFile);
                dataSet = new DataSet();
                dataSet.ReadXml(xmlReader);
                value = true;
            }

            // For XmlReader.Create
            catch (InvalidOperationException ex)
            {
                WriteExceptionDebugMessage(ex);
                value = false;
            }
            catch (System.ArgumentNullException ex)
            {
                WriteExceptionDebugMessage(ex);
                value = false;
            }

            // For dataSet.ReadXML
            catch (System.Security.SecurityException ex)
            {
                WriteExceptionDebugMessage(ex);
                value = false;
            }

            catch (System.Xml.XmlException ex)
            {
                WriteExceptionDebugMessage(ex);
                value = false;
            }

            WriteDebugMessage("LoadData");

            return value;

        }

        private void LoadDataAndCategories()
        {
            if (System.IO.File.Exists(DataFile))
            {
                if (LoadData())
                {
                    LoadCategories();
                    WriteDebugMessage("LoadDataAndCategories");
                }
                else
                {
                    MessageBox("There was a problem reading the XML data file. Please run monitoring with DbgView.exe to troubleshoot.");
                }
            }
        }

        public void NavigateToSamples(string CategoryName)
        {
            DataTable table = dataSet.Tables["Category"];
            DataRow row = GetSingleDataRow(table, "CategoryName", CategoryName);
            string temp = row["CategoryID"].ToString();

            LoadSamples(temp);

            Dictionary<string, object> props = new Dictionary<string, object>();
            props.Add("Session", session);
            props.Add("Samples", Samples);
            props.Add("Sampler", this);
            props.Add("HeaderString", CategoryName);
            session.GoToPage("resx://Sampler/Sampler.Resources/Samples", props);

            WriteDebugMessage("NavigateToSamples");
        }

        public void NavigateFromAutomationFileDeferred(object argsUnused)
        {
            if (host.ApplicationContext.IsForegroundApplication)
            {
                NavigateFromAutomationFile();
            }
            else
            {
                // We are not yet the foreground app, so defer this operation until we are
                Application.DeferredInvoke(new DeferredHandler(NavigateFromAutomationFileDeferred));
            }
        }

        public bool NavigateFromAutomationFile()
        {
            bool navResult = false;

            if (!String.IsNullOrEmpty(automationfile))
            {

                // The automation file has served its purpose, try to delete it now
                try
                {
                    if (System.IO.File.Exists(automationfile))
                    {
                        WriteDebugMessage("AutomationFileExists");
                        navResult = NavigateToSample(GetAutomationValue(automationfile));
                        System.IO.File.Delete(automationfile);
                    }
                }
                catch (System.UnauthorizedAccessException)
                {
                    WriteDebugMessage("Unable to delete the automation file -- it is read-only or not a file.");
                }
                catch (System.IO.IOException)
                {
                    WriteDebugMessage("Unable to delete the automation file -- it is currently in use.");
                }
            }

            lock (lockObject)
            {
                // We are done with the pending update request, now allow others to come through
                navRequestPending = false;
            }

            return navResult;
        }

        public bool NavigateToSample(object SampleNameObject)
        {
            bool navResult = false;
            string SampleName = SampleNameObject as string;
            DataTable table = dataSet.Tables["Sample"];
            DataRow row = GetSingleDataRow(table, "SampleName", SampleName);

            switch (row["Type"].ToString())
            {
                case "MCML":
                    string temp = row["Filename"].ToString();
                    temp = temp.Substring(0, temp.Length - 5);
                    Dictionary<string, object> props = new Dictionary<string, object>();
                    props.Add("Session", session);
                    props.Add("Sampler", this);

                    try
                    {
                        Page curPage = session.CurrentPage;
                        if (curPage != null)
                            curPage.PushOnStack = KeepCurrentOnBackstack;
                    }
                    catch (System.Exception ex)
                    {
                        WriteExceptionDebugMessage(ex);
                    }

                    if (Boolean.Parse(row["WebServerRequired"].ToString()))
                    {
                        // Navigate to the web.
                        string fullURI = "http://" + row["WebURI"].ToString() + row["Filename"].ToString();
                        WriteDebugMessage("Sample = " + fullURI);
                        if (host.ApplicationContext.IsForegroundApplication)
                        {
                            host.MediaCenterEnvironment.NavigateToPage(PageId.WebAddIn, fullURI);
                            navResult = true;
                        }
                    }
                    else
                    {
                        //Navigate to the local page.
                        WriteDebugMessage("Sample = " + temp);
                        session.GoToPage("resx://Sampler/Sampler.Resources/" + temp, props);
                        navResult = true;
                    }
                    break;

                case "ASPX":
                    WriteDebugMessage("This sample has no visuals to display. It's likely an ASPX sample so open in a text editor.");
                    MessageBox("This sample has no visuals to display. It's likely an ASPX sample so open in a text editor.");
                    break;

                case "XML":
                    WriteDebugMessage("This sample has no visuals to display. It's likely an XML sample so open in a text editor.");
                    MessageBox("This sample has no visuals to display. It's likely an XML sample so open in a text editor.");
                    break;

                case "CSharp":
                    WriteDebugMessage("This sample has no visuals to display. It's likely a C# sample so open in a text editor.");
                    MessageBox("This sample has no visuals to display. It's likely a C# sample so open in a text editor.");
                    break;
            }

            WriteDebugMessage("NavigateToSample");
            return navResult;
        }

        private void LoadSamples(string CategoryID)
        {
            DataTableReader readerSample = new DataTableReader(dataSet.Tables["Sample"]);

            Samples.Clear();

            DataRow[] rowCollection = GetSelectedDataRows(dataSet.Tables["Sample"], "CategoryID='" + CategoryID + "'");

            foreach (DataRow row in rowCollection)
            {
                // Uncomment this line to write out the rows...
                // WriteDebugMessage("LoadSamples.Row: " + row["SampleName"].ToString());
                Samples.Source.Add(row["SampleName"].ToString());
            }

            WriteDebugMessage("LoadSamples");
        }

        private void LoadCategories()
        {
            DataTableReader readerCategory = new DataTableReader(dataSet.Tables["Category"]);

            try
            {

                while (readerCategory.Read())
                {
                    Categories.Source.Add(readerCategory["CategoryName"].ToString());
                }

            }
            catch (System.Exception ex)
            {
                WriteExceptionDebugMessage(ex);
            }

            WriteDebugMessage("LoadArrayListDataSet");
        }

        private static DataRow[] GetSelectedDataRows(DataTable table, string expression)
        {
            DataRow[] foundRows;
            foundRows = table.Select(expression);
            return foundRows;
        }

        public static DataRow GetSingleDataRow(DataTable table, string column, object value)
        {
            string query = String.Format("{0} = '{1}'", column, value);
            DataRow[] matches = table.Select(query);

            if (matches.Length != 1)
            {
                Debug.WriteLine("Unable to find a match -- make sure you have unique sample names. Query: " + query.ToString());
            }

            return matches[0];
        }

        private void SetInstallationFolder()
        {
            string temp;

            StringBuilder sb = new StringBuilder();

            // Read the registry key for SDK installation
            // Get the value from the registry.

            // HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SDKs\Windows Media Center\v6.0
            // Should return something which looks like this...
            // C:\Program Files\Microsoft SDKs\Windows Media Center\v6.0\

            temp = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Microsoft SDKs\Windows Media Center\v6.0", @"InstallationFolder", null) as string;

            // Accomodate for 64-bit support.

            if (temp == null)
            {
                temp = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\Microsoft SDKs\Windows Media Center\v6.0", @"InstallationFolder", null) as string;
            }

            sb.Append(temp);

            InstallationFolder = sb.ToString();

            WriteDebugMessage("SDK Install Folder = " + InstallationFolder);

            sb.Append(@"Samples\Sampler\");

            InstallationFolderSampler = sb.ToString();

            WriteDebugMessage("Sampler Folder = " + InstallationFolderSampler);
        }

        private void SetPaths()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(System.IO.Directory.GetParent(System.Environment.GetFolderPath(Environment.SpecialFolder.System)));
            sb.Append(@"\ehome");
            eHomeFolderPath = sb.ToString();

            PublicMusicPath = GetPath(KnownFolder.PublicMusic);
            PublicVideosPath = GetPath(KnownFolder.PublicVideos);
            PublicPicturesPath = GetPath(KnownFolder.PublicPictures);

            WriteDebugMessage("SetPaths");
        }

        private void SetLocalContent()
        {
            LocalContentVideo01 = publicVideosPath + @"\Windows Media Center SDK\Video01.wmv";
            LocalContentVideo02 = publicVideosPath + @"\Windows Media Center SDK\Video02.wmv";
            LocalContentVideo03 = publicVideosPath + @"\Windows Media Center SDK\Video03.wmv";
            LocalContentVideo04 = publicVideosPath + @"\Windows Media Center SDK\Video04.wmv";

            string[] stringArrayA = new string[4];

            stringArrayA[0] = LocalContentVideo01;
            stringArrayA[1] = LocalContentVideo02;
            stringArrayA[2] = LocalContentVideo03;
            stringArrayA[3] = LocalContentVideo04;

            localContentPlaylistVideo = stringArrayA;

            LocalContentAudio01 = publicMusicPath + @"\Windows Media Center SDK\Audio01.mp3";
            LocalContentAudio02 = publicMusicPath + @"\Windows Media Center SDK\Audio02.mp3";
            LocalContentAudio03 = publicMusicPath + @"\Windows Media Center SDK\Audio03.mp3";

            string[] stringArrayB = new string[3];

            stringArrayB[0] = LocalContentAudio01;
            stringArrayB[1] = LocalContentAudio02;
            stringArrayB[2] = LocalContentAudio03;

            localContentPlaylistAudio = stringArrayB;

            string[] stringArrayC = new string[7];

            stringArrayC[0] = LocalContentVideo01;
            stringArrayC[1] = LocalContentAudio01;
            stringArrayC[2] = LocalContentVideo02;
            stringArrayC[3] = LocalContentAudio02;
            stringArrayC[4] = LocalContentVideo03;
            stringArrayC[5] = LocalContentAudio03;
            stringArrayC[6] = LocalContentVideo04;

            localContentPlaylistMixed = stringArrayC;

            FourBoxGraphic = "file://" + InstallationFolderSampler + @"FourBoxGraphic.png";
            FourBoxGraphicNoBorder = "file://" + InstallationFolderSampler + @"FourBoxGraphicNoBorder.png";
            FourBoxGraphicTransparent = "file://" + InstallationFolderSampler + @"FourBoxGraphicTransparent.png";
            FourBoxGraphicTransparentNoBorder = "file://" + InstallationFolderSampler + @"FourBoxGraphicTransparentNoBorder.png";
            LocalContentPicturePortrait = "file://" + PublicPicturesPath + @"\Windows Media Center SDK\Photo01.jpg";
            LocalContentPictureLandscape = "file://" + PublicPicturesPath + @"\Windows Media Center SDK\Photo02.jpg";
            LocalContentPicturePortraitNoScheme = PublicPicturesPath + @"\Windows Media Center SDK\Photo01.jpg";
            LocalContentPictureLandscapeNoScheme = PublicPicturesPath + @"\Windows Media Center SDK\Photo02.jpg";


            WriteDebugMessage("SetLocalContent");
        }

        // -------------------------------------------------------

        // http://www.pinvoke.net/default.aspx/shell32.SHGetKnownFolderPath

        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);

        public static class KnownFolder
        {
            public static readonly Guid PublicDocuments = new Guid("ED4824AF-DCE4-45A8-81E2-FC7965083634");
            public static readonly Guid PublicMusic = new Guid("3214FAB5-9757-4298-BB61-92A9DEAA44FF");
            public static readonly Guid PublicVideos = new Guid("2400183A-6185-49FB-A2D8-4A392A602BA3");
            public static readonly Guid PublicPictures = new Guid("B6EBFB86-6907-413C-9AF7-4FC2ABF07CC5");
        }

        private string GetPath(Guid folder)
        {
            string value = "";
            IntPtr pPath;
            if (SHGetKnownFolderPath(folder, 0, IntPtr.Zero, out pPath) == 0)
            {
                value = System.Runtime.InteropServices.Marshal.PtrToStringUni(pPath);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(pPath);
            }
            WriteDebugMessage("GetPath");
            return value;
        }

        // -------------------------------------------------------

        private void SetDataFile()
        {
            DataFile = InstallationFolderSampler + "Sampler.xml";
            WriteDebugMessage("SetDataFile");
        }

        private void WriteDebugMessage(string message)
        {
            Debug.WriteLine("Sampler: " + message);
        }

        private void WriteExceptionDebugMessage(System.Exception ex)
        {
            Debug.WriteLine("Sampler: " + ex.ToString());
        }

        public void MessageBox(string text)
        {
            int timeout = 5;
            bool modal = true;
            string caption = Resources.ApplicationTitle;

            if (session != null)
            {
                host.MediaCenterEnvironment.Dialog(text,
                                              caption,
                                              new object[] { DialogButtons.Ok },
                                              timeout,
                                              modal,
                                              "file://" + InstallationFolder + @"\Tools\Sampler.png",
                                              delegate(DialogResult dialogResult) { });
            }
            else
            {
                WriteDebugMessage("DialogTest");
            }
        }
    }
}
