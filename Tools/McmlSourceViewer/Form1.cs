using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Globalization;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

[assembly: CLSCompliant(true)]

namespace MCMLSourceViewer
{
    public partial class Form1 : Form
    {
        // MCMLPad automation objects
        private string _padpath = null;
        private McmlPadController _remoteControl = new McmlPadController();
        private string _lastMiscOptions = null;

        private TreeNode node;

        private TreeNode myCurrentNode;

        private bool nodesExpanded = false;

        private string MarkupPath = "";

        private string InstallationFolder = "";

        private string ehShellPath = System.Environment.GetEnvironmentVariable("windir") + "\\ehome\\ehshell.exe";

        private string publicDocumentsPath = "";

        private const string samplerAutomationFile = "SamplerAutomation.xml";

        private const string SettingsFile = "SampleExplorer.Settings.xml";

        private string samplerAutomationFileFullPath = "";

        private DataSet dataSet;

        // -------------------------------------------------------

        // http://www.pinvoke.net/default.aspx/shell32.SHGetKnownFolderPath

        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);

        public static class KnownFolder
        {
            public static readonly Guid PublicDocuments = new Guid("ED4824AF-DCE4-45A8-81E2-FC7965083634");
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
            return value;
        }

        // -------------------------------------------------------

        private string dataFile;
        public string DataFile
        {
            get { return dataFile; }
            set { dataFile = value; }
        }

        private string currentnode;
        public string CurrentNode
        {
            get { return currentnode; }
            set { currentnode = value; }
        }

        private string currentsample;
        public string CurrentSample
        {
            get { return currentsample; }
            set { currentsample = value; }
        }

        private bool mediaCenterRequired;
        public bool MediaCenterRequired
        {
            get { return mediaCenterRequired; }
            set { mediaCenterRequired = value; }
        }

        private bool mediaCenterAlwaysRequired;
        public bool MediaCenterAlwaysRequired
        {
            get { return mediaCenterAlwaysRequired; }
            set { mediaCenterAlwaysRequired = value; }
        }

        private string appGuid;
        public string AppGuid
        {
            get { return appGuid; }
            set { appGuid = value; }
        }

        private string entrypointGuid;
        public string EntrypointGuid
        {
            get { return entrypointGuid; }
            set { entrypointGuid = value; }
        }

        private bool LoadData()
        {
            bool value;

            try
            {
                DataSet tempDataSet = new DataSet();
                XmlReader xmlReader = XmlReader.Create(DataFile);
                tempDataSet.ReadXml(xmlReader);

                // If the reader didn't throw update the dataSet.

                dataSet = new DataSet();
                dataSet = tempDataSet;
                value = true;
            }

            // For XmlReader.Create
            catch (InvalidOperationException)
            {
                DisplayMessage("InvalidOperationException");
                value = false;
            }
            catch (System.ArgumentNullException)
            {
                DisplayMessage("Data file was null");
                value = false;
            }

            // For dataSet.ReadXML
            catch (System.Security.SecurityException)
            {
                DisplayMessage("You do not have sufficient permissions to access the location of the XML data.");
                value = false;
            }
            catch (System.Xml.XmlException)
            {
                DisplayMessage("There was a problem reading the XML file -- please make sure it is valid.");
                value = false;
            }

            //DumpDataSetContents(dataSet,false);

            return value;

        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message, Resources.StringMCMLSourceViewer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadSettings(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + SettingsFile);
        }

        private void DeleteAutomationFile()
        {
            if (System.IO.File.Exists(samplerAutomationFileFullPath))
            {
                try
                {
                    System.IO.File.Delete(samplerAutomationFileFullPath);
                }
                catch (System.UnauthorizedAccessException)
                {
                    DisplayMessage("Unable to delete the automation file -- it is currently in use.");
                }
            }
        }

        public Form1(string[] args)
        {
            InitializeComponent();

            IDictionary appArgs = Startup();

            _padpath = System.Environment.GetEnvironmentVariable("MCMLPAD");

            publicDocumentsPath = GetPath(KnownFolder.PublicDocuments);

            samplerAutomationFileFullPath = publicDocumentsPath + @"\" + samplerAutomationFile;

            DeleteAutomationFile();

            SetInstallationFolder();

            //bool loadMarkupFilepathFromData = false;

            if (appArgs["sampler"] != null)
            {
                DataFile = InstallationFolder + "Sampler.xml";
                MarkupPath = InstallationFolder;
                this.Text = "Sample Explorer";
            }

            string stFile = (string)appArgs["file"];
            if (stFile != null)
            {
                DataFile = stFile;

                string stLocation = (string)appArgs["location"];
                if (System.IO.Directory.Exists(stLocation))
                {
                    MarkupPath = stLocation;
                }
                this.Text = "Sample Explorer -- " + DataFile;
            }

            LoadDataAndTree();

        }

        public static IDictionary Startup()
        {
            string argsText = System.Environment.CommandLine;

            string[] argsArray = argsText.Split(new string[] { " /", " -" }, StringSplitOptions.RemoveEmptyEntries);
            string[] argsArray2 = new string[argsArray.Length - 1];

            //ignore the first item...it's the path to the executable
            for (int i = 1; i < argsArray.Length; i++)
            {
                argsArray2[i - 1] = "/" + argsArray[i];
            }

            return Startup(argsArray2);
        }

        public static IDictionary Startup(string[] args)
        {

            CommandLineArgument[] knobs = CommandLineArgument.ParseArgs(args);
            IDictionary appSpecificKnobs = new Hashtable();

            foreach (CommandLineArgument knob in knobs)
            {
                switch (knob.Name)
                {
                    case "sampler":
                        appSpecificKnobs[knob.Name] = "";
                        break;

                    case "file":
                        appSpecificKnobs[knob.Name] = knob.Value;
                        break;

                    case "location":
                        appSpecificKnobs[knob.Name] = knob.Value;
                        break;
                }
            }

            return appSpecificKnobs;
        }

        internal struct CommandLineArgument
        {
            public CommandLineArgument(string name, string value)
            {
                if (name == null)
                    throw new ArgumentNullException("name");

                Name = name.ToLower(CultureInfo.InvariantCulture);
                Value = value;
            }

            public string Name;
            public string Value;



            //
            // CommandLineArgument.ParseArgs
            //

            public static CommandLineArgument[] ParseArgs(string[] arArgs)
            {
                return ParseArgs(arArgs, null);
            }

            public static CommandLineArgument[] ParseArgs(string[] arArgs, string stDefaultName)
            {
                System.Collections.Generic.List<CommandLineArgument> listArguments = new System.Collections.Generic.List<CommandLineArgument>();

                foreach (string stArg in arArgs)
                {
                    if (String.IsNullOrEmpty(stArg))
                        throw new ArgumentException("arArgs");

                    CommandLineArgument knob;
                    string stName;
                    string stValue = null;

                    if (stArg[0] == '-' || stArg[0] == '/')
                    {
                        stName = stArg.Substring(1, stArg.Length - 1);
                    }
                    else if (stDefaultName != null)
                    {
                        stName = stDefaultName + ":" + stArg;
                    }
                    else
                    {
                        Debug.WriteLine("Ignoring bad command line argument: Arguments should begin with either a dash (-) or slash (/)");
                        continue;
                    }

                    int idxSplit = stName.IndexOf(':');
                    if (idxSplit != -1)
                    {
                        stValue = stName.Substring(idxSplit + 1).Replace("\"", "");
                        stName = stName.Substring(0, idxSplit);
                    }

                    knob = new CommandLineArgument(stName, stValue);

                    listArguments.Add(knob);
                }

                return listArguments.ToArray();
            }
        }

        private bool LoadDataAndTree()
        {
            bool value = true;

            if (System.IO.File.Exists(DataFile))
            {
                if (LoadData())
                {
                    if (!LoadTree())
                    {
                        value = false;
                    }
                }
                else
                {
                    value = false;
                }
            }
            return value;
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

            sb.Append(@"Samples\Sampler\");

            InstallationFolder = sb.ToString();
        }

        private static DataRow GetSingleDataRow(DataTable table, string expression)
        {
            DataRow[] foundRows;
            foundRows = table.Select(expression);
            return foundRows[0];
        }

        /// <summary>
        /// Dump out the contents of a DataSet to the output window.
        /// </summary>
        /// <param name="onlyDumpOneRowPerTable">
        /// If set, only one row per table will be dumped.  This is useful for
        /// debugging the structure of your data set (as opposed to the full
        /// contents)
        /// </param>
        public static void DumpDataSetContents(DataSet dataSet, bool onlyDumpOneRowPerTable)
        {
            Debug.WriteLine("DATASET: " + dataSet.ToString());
            Debug.Indent();

            foreach (DataTable table in dataSet.Tables)
                DumpDataTableContents(table, onlyDumpOneRowPerTable);

            Debug.Unindent();
        }

        /// <summary>
        /// Dump out the contents of a DataTable to the output window.
        /// </summary>
        /// <param name="onlyDumpOneRowPerTable">
        /// If set, only one row per table will be dumped.  This is useful for
        /// debugging the structure of your data table (as opposed to the full
        /// contents)
        /// </param>
        public static void DumpDataTableContents(DataTable table, bool onlyDumpOneRowPerTable)
        {
            Debug.WriteLine("Table: " + table.ToString());
            Debug.Indent();

            //foreach (DataRow row in table.Rows)
            //{
            //    Debug.WriteLine("Row:");
            //    Debug.Indent();

            //    foreach (DataColumn column in table.Columns)
            //    {
            //        Debug.WriteLine(String.Format(System.Globalization.CultureInfo.InvariantCulture,
            //            "[{0}] = {1}", column.ColumnName, row[column]));
            //    }

            //    Debug.Unindent();

            //    if (onlyDumpOneRowPerTable)
            //        break;
            //}

            //Debug.Unindent();
        }

        private static DataRow[] GetSelectedDataRows(DataTable table, string expression)
        {
            DataRow[] foundRows;
            foundRows = table.Select(expression);
            return foundRows;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadInViewer();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            LoadSample();
        }

        private void WriteSamplerAutomation(string file)
        {
            XmlWriter writer = null;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            writer = XmlWriter.Create(file, settings);

            writer.WriteComment("Windows Media Center SDK");
            writer.WriteComment("This file used to automate the Sampler application.");

            // Root
            writer.WriteStartElement("Root");

            // Sample
            writer.WriteStartElement("Sample");
            writer.WriteString(CurrentSample);
            writer.WriteEndElement();

            // End Root
            writer.WriteEndElement();

            writer.Flush();
            writer.Close();
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    LoadSample();
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void LoadInViewer()
        {
            string temp = treeView1.SelectedNode.Name;
            myCurrentNode = treeView1.SelectedNode;
            string tempText = treeView1.SelectedNode.Text;

            UpdateStatus("");

            if (MarkupPath.StartsWith("http://"))
            {
                return;
            }

            if (!string.IsNullOrEmpty(temp))
            {
                try
                {
                    DataRow dataRow = GetSingleDataRow(dataSet.Tables["Sample"], "SampleID='" + temp + "'");
                    string filename = dataRow["Filename"].ToString();

                    string combined = MarkupPath + filename;

                    Debug.WriteLine(combined);

                    if (System.IO.File.Exists(combined))
                    {
                        richTextBox1.LoadFile(combined, RichTextBoxStreamType.PlainText);

                        if (dataRow["Type"].ToString() != "MCML")
                        {
                            UpdateStatus("This sample type is non-visual and will therefore not render properly in the Preview Tool: " + filename);
                        }
                        else
                        {
                            UpdateStatus(filename);
                        }

                        if (Boolean.Parse(dataRow["WebServerRequired"].ToString()))
                        {
                            string webURI = dataRow["WebURI"].ToString();
                            CurrentNode = "http://" + webURI + filename;
                            //CurrentSample = "http://" + webURI + filename;
                        }
                        else
                        {
                            CurrentNode = "file://" + combined;
                            //CurrentSample = tempText;
                        }

                        CurrentSample = tempText;

                        try
                        {
                            AppGuid = dataRow["ApplicationID"].ToString();
                            EntrypointGuid = dataRow["EntryPointID"].ToString();
                        }
                        catch (ArgumentException)
                        {
                            UpdateStatus("Rows not found in the table.");
                        }

                        if (Boolean.Parse(dataRow["MediaCenterRequired"].ToString()))
                        {
                            MediaCenterRequired = true;
                        }
                        else
                        {
                            MediaCenterRequired = false;
                        }


                    }
                    else
                    {
                        UpdateStatus("The sample name is wrong in your data file or the sample is missing.");
                        richTextBox1.Text = "Unable to load sample.";
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    DirectoryNotFoundHandler();
                }
                catch (FileNotFoundException)
                {
                    FileNotFoundHandler();
                }
            }
            else
            {
                richTextBox1.Text = "";
                CurrentNode = "";
            }
        }

        private void UpdateStatus(string status)
        {
            toolStripStatusLabel1.Text = status;
        }

        private void DirectoryNotFoundHandler()
        {
            UpdateStatus("Directory Not Found");
        }

        private void FileNotFoundHandler()
        {
            UpdateStatus("File Not Found");
        }

        private void LoadSample()
        {
            if (MediaCenterRequired || MediaCenterAlwaysRequired)
            {
                _remoteControl.Close();
                WriteSamplerAutomation(publicDocumentsPath + @"\" + samplerAutomationFile);

                StringBuilder sb = new StringBuilder();
                sb.Append("/entrypoint:");
                sb.Append(AppGuid);
                sb.Append("\\");
                sb.Append(EntrypointGuid);

                System.Diagnostics.Process.Start(ehShellPath, sb.ToString());
            }
            else
            {
                if (!string.IsNullOrEmpty(CurrentNode))
                {
                    LaunchMCMLPad(CurrentNode);
                }
            }
        }

        private bool LoadTree()
        {
            try
            {
                DataTableReader readerCategory = new DataTableReader(dataSet.Tables["Category"]);

                while (readerCategory.Read())
                {
                    string tempCategoryID = readerCategory["CategoryID"].ToString();

                    node = treeView1.Nodes.Add(readerCategory["CategoryName"].ToString());

                    DataRow[] rowCollection = GetSelectedDataRows(dataSet.Tables["Sample"], "CategoryID='" + tempCategoryID + "'");

                    foreach (DataRow row in rowCollection)
                    {
                        AddNode(node, row["SampleID"].ToString(), row["SampleName"].ToString());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("The data file was in an unexpected format: " + ex.Message);

                return false;
            }
        }

        private void AddNode(TreeNode node, string key, string text)
        {
            node.Nodes.Add(key, text);
        }

        private void LaunchMCMLPad(string filepath)
        {
            StringBuilder args;
            string mcmlpadpath;
            bool fCanUseExistingPad = false;
            bool fPadExists;
            Point curPos;
            Size curSize;

            args = new StringBuilder();

            if (args.ToString().Equals(_lastMiscOptions))
                fCanUseExistingPad = true;

            _lastMiscOptions = args.ToString();

            fPadExists = _remoteControl.GetPositionAndSize(
                            out curPos,
                            out curSize
                            );

            if (!String.IsNullOrEmpty(filepath))
            {
                args.Insert(0, String.Format(" /load:\"{0}\"", filepath));
            }

            if (_padpath != null)
            {
                mcmlpadpath = _padpath;
            }
            else
            {
                mcmlpadpath = System.Environment.GetEnvironmentVariable("windir");
                mcmlpadpath += "\\ehome\\mcmlpad.exe";
            }

            if (fCanUseExistingPad)
            {
                if (_remoteControl.PadExists)
                {
                    _remoteControl.Load(filepath);
                    return;
                }
            }

            _remoteControl.Close();

            _remoteControl.ID = Guid.NewGuid().ToString();

            args.AppendFormat(" /controlid:{0}", _remoteControl.ID);

            if (!File.Exists(mcmlpadpath))
            {
                MessageBox.Show(
                    String.Format(MCMLSourceViewer.Resources.StringMCMLPadNotFound, mcmlpadpath),
                    MCMLSourceViewer.Resources.StringMCMLSourceViewer
                    );

                return;
            }

            try
            {
                System.Diagnostics.Process.Start(mcmlpadpath, args.ToString());
            }
            catch (Win32Exception e)
            {
                MessageBox.Show(
                    String.Format(MCMLSourceViewer.Resources.StringMCMLPadLaunchError, e.ToString()),
                    MCMLSourceViewer.Resources.StringMCMLSourceViewer
                    );
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = OpenFile();

            if (!string.IsNullOrEmpty(file))
            {
                DataFile = file;
                if (LoadDataAndTree())
                {
                    this.Text = "Source Viewer -- " + DataFile;
                }
                else
                {
                    DisplayMessage("There was a problem with the data file so it was not loaded.");
                }
            }
        }

        private string OpenFile()
        {
            string result = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                result = openFileDialog.FileName;
            }

            return result;
        }

        private void alwaysUseMediaCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alwaysUseMediaCenterToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                alwaysUseMediaCenterToolStripMenuItem.CheckState = CheckState.Checked;
                MediaCenterAlwaysRequired = true;
            }
            else
            {
                alwaysUseMediaCenterToolStripMenuItem.CheckState = CheckState.Unchecked;
                MediaCenterAlwaysRequired = false;
            }
        }

        private void expandAllNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpandOrCollapseAllNodes();
        }

        private void ExpandOrCollapseAllNodes()
        {
            if (nodesExpanded)
            {
                treeView1.CollapseAll();
                expandAllNodesToolStripMenuItem.Text = "Expand All Nodes";
                nodesExpanded = false;
            }
            else
            {
                treeView1.ExpandAll();
                expandAllNodesToolStripMenuItem.Text = "Collapse All Nodes";
                nodesExpanded = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteAutomationFile();
        }

        private void clearAutomationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAutomationFile();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(Application.ProductName.ToString());
            s.Append(Environment.NewLine);
            s.Append(MCMLSourceViewer.Resources.StringMCMLSourceViewer);
            s.Append(Environment.NewLine);
            s.Append("Version " + Application.ProductVersion.ToString());
            s.Append(Environment.NewLine);
            s.Append(MCMLSourceViewer.Resources.StringCopyright);
            MessageBox.Show(s.ToString(), MCMLSourceViewer.Resources.StringAbout);
        }

        private void setSampleLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.SelectedPath = MarkupPath;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MarkupPath = folderBrowserDialog.SelectedPath + @"\";
            }
            LoadInViewer();
        }

        private void WriteSettings(string file)
        {
            XmlWriter writer = null;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            writer = XmlWriter.Create(file, settings);

            writer.WriteComment("Settings for Windows Media Center SDK Sample Explorer");

            writer.WriteStartElement("Root");

            writer.WriteStartElement("NodesExpanded");
            writer.WriteString(nodesExpanded.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("NodeSelected");
            if (myCurrentNode != null)
            {
                writer.WriteString(myCurrentNode.Name);
            }
            writer.WriteEndElement();

            writer.WriteStartElement("AlwaysUseMediaCenter");
            writer.WriteString(alwaysUseMediaCenterToolStripMenuItem.Checked.ToString());
            writer.WriteEndElement();

            //Root
            writer.WriteEndElement();

            writer.Flush();
            writer.Close();
        }

        private void ReadSettings(string file)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            string nodeToSelect = "";

            if (!File.Exists(file))
                return;

            try
            {
                XmlReader reader = XmlReader.Create(file, settings);

                reader.MoveToContent();
                reader.Read();

                while (reader.NodeType == XmlNodeType.Element)
                {
                    string name = reader.Name;
                    string valueAsString = reader.ReadElementString();
                    bool valueAsBool = valueAsString.Equals("True");

                    switch (name)
                    {
                        case "NodesExpanded":
                            // Restore expansion of nodes.
                            if (valueAsBool)
                            {
                                treeView1.ExpandAll();
                                expandAllNodesToolStripMenuItem.Text = "Collapse All Nodes";
                                nodesExpanded = true;
                            }
                            else
                            {
                                treeView1.CollapseAll();
                                nodesExpanded = false;
                            }
                            break;

                        case "NodeSelected":
                            // Determine which node was last selected.
                            // See below for actually taking action.
                            nodeToSelect = valueAsString;
                            break;

                        case "AlwaysUseMediaCenter":
                            // Set the option for always use Media Center.
                            alwaysUseMediaCenterToolStripMenuItem.Checked = valueAsBool;
                            MediaCenterAlwaysRequired = valueAsBool;
                            break;

                        default:
                            // Ignore unknown elements.
                            break;
                    }
                }
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex.ToString());
            }

            // Select the last node selected by the user
            if (!string.IsNullOrEmpty(nodeToSelect))
            {
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    for (int i2 = 0; i2 < treeView1.Nodes[i].Nodes.Count; i2++)
                    {
                        if (treeView1.Nodes[i].Nodes[i2].Name == nodeToSelect)
                        {
                            treeView1.SelectedNode = treeView1.Nodes[i].Nodes[i2];
                            break;
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                WriteSettings(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + SettingsFile);
            }
            catch (UnauthorizedAccessException exNoAccess)
            {
                DisplayMessage(exNoAccess.ToString());
            }
        }
    }
}
