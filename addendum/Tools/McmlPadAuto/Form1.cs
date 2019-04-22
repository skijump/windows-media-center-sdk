using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;

[assembly: CLSCompliant(true)]
namespace McmlPadAuto
{
    public partial class Form1 : Form
    {
        private string _padpath = null;
        private McmlPadController _remoteControl = new McmlPadController();
        private string _lastMiscOptions = null;

        public Form1(string[] args)
        {
            InitializeComponent();

            _padpath = System.Environment.GetEnvironmentVariable("MCMLPAD");

            foreach (string arg in args)
            {
                if (arg == "/unrestricted")
                {
                    Unrestricted = true;
                }
                else if (arg.StartsWith("/pad:"))
                {
                    _padpath = arg.Substring(5);
                }
            }
        }

        private bool unrestricted;

        public bool Unrestricted
        {
            get { return unrestricted; }
            set { unrestricted = value; }
        }

        private void LaunchUriInWindowsMediaCenter(string uri, string uriType)
        {
            EndEhShellProcess();

            string tempUri = "\"" + uri + "\"";

            switch (uriType)
            {
                case "homepage":
                    // Web MCML
                    StartEhShellProcess(tempUri, @"/homepage:");
                    break;
                case "url":
                    // Web HTML
                    StartEhShellProcess(tempUri, @"/url:");
                    break;
                case "launchcoded":
                    // Assembly with Parameters
                    StartEhShellProcess(tempUri, @"/launchcoded:");
                    break;
                case "launchcodeless":
                    // Web MCML
                    StartEhShellProcess(tempUri, @"/launchcodeless:");
                    break;
            }
        }

        private void StartEhShellProcess(string uri, string commandlineswitch)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\windows\ehome\ehshell.exe", commandlineswitch + uri);
            }
            catch (ObjectDisposedException ex)
            {
                DisplayExceptionMessage(ex);
            }
            catch (System.InvalidOperationException ex)
            {
                DisplayExceptionMessage(ex);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                DisplayExceptionMessage(ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                DisplayExceptionMessage(ex);
            }
        }

        private void DisplayExceptionMessage(System.Exception ex)
        {
            MessageBox.Show("An unexpected exception occured: " + ex.Message, McmlPadAuto.Resources.StringDialogCaptionProblem);
        }

        private void EndEhShellProcess()
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.StartsWith("ehshell"))
                {
                    try
                    {
                        clsProcess.Kill();
                    }
                    catch (Exception ex)
                    {
                        // Do nothing.
                        //DisplayExceptionMessage(ex);
                    }
                }
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            LaunchTool();
        }

        private void LaunchTool()
        {
            string launchURI = textBoxURI.Text.Trim();
            if (openWithHomepageToolStripMenuItem.Checked)
            {
                LaunchUriInWindowsMediaCenter(launchURI, "homepage");
                CreateHistory(launchURI);
                return;
            }
            if (openWithUrlToolStripMenuItem.Checked)
            {
                LaunchUriInWindowsMediaCenter(launchURI, "url");
                CreateHistory(launchURI);
                return;
            }
            if (openWithLaunchcodedToolStripMenuItem.Checked)
            {
                LaunchUriInWindowsMediaCenter(launchURI, "launchcoded");
                CreateHistory(launchURI);
                return;
            }
            if (openWithLaunchcodelessToolStripMenuItem.Checked)
            {
                LaunchUriInWindowsMediaCenter(launchURI, "launchcodeless");
                CreateHistory(launchURI);
                return;
            }
            else
            {
                LaunchMCMLPad(launchURI);
                CreateHistory(launchURI);
                return;
            }
        }

        private void CreateHistory(string uri)
        {
            if (uri.Length != 0)
            {
                listBox1.Items.Remove(uri);
                listBox1.Items.Insert(0, uri);
            }

            textBoxURI.Focus();
            textBoxURI.SelectAll();
        }

        private bool GetNumericValue(Control control, out Int32 value)
        {
            string text = control.Text.Trim();
            bool isValid = false;

            try
            {
                value = Int32.Parse(text);
                isValid = true;
            }
            catch (System.OverflowException)
            {
                MessageBox.Show(String.Format("Numeric value '{0}' is too large.", text),
                                McmlPadAuto.Resources.StringMCMLPreviewToolLauncher);
                value = -1;
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    String.Format("Invalid numeric value '{0}'.", text),
                    McmlPadAuto.Resources.StringMCMLPreviewToolLauncher
                    );

                value = -1;
            }

            return isValid;
        }

        //
        //
        //

        private void LaunchMCMLPad(string filepath)
        {
            StringBuilder args;
            string mcmlpadpath;
            bool fCanUseExistingPad = false;
            bool fSizeSpecified = false;
            bool fPosSpecified = false;
            bool fPadExists;
            Point curPos;
            Size curSize;

            //
            // Construct the mcmlpad command line arguments that correspond
            // to the misc. options the user has selected.  Note that the
            // size/position parameters and URI are handled later.
            //

            args = new StringBuilder();

            if (Unrestricted == true)
            {
                args.Append(" -unrestricted");
            }

            if (checkBoxAnimations.Checked == false)
            {
                args.Append(" /animations:false");
            }

            if (checkBoxDevice.Checked == true)
            {
                if (comboBoxDevice.Text == "DX9")
                {
                    args.Append(" /dx9");
                }
                if (comboBoxDevice.Text == "GDI")
                {
                    args.Append(" /gdi");
                }
            }

            if (checkBoxDirection.Checked == true)
            {
                args.Append(" /direction:");

                if (comboBoxDirection.Text == "Right To Left (RTL)")
                {
                    args.Append("rtl");
                }
                if (comboBoxDirection.Text == "Left To Right (LTR)")
                {
                    args.Append("ltr");
                }
            }

            if (checkBoxAssemblyRedirect.Checked == true)
            {
                args.Append(" /assemblyredirect:\"");
                args.Append(textBoxAssemblyRedirectFullPath.Text);
                args.Append("\"");
            }

            if (checkBoxMarkupRedirect.Checked == true)
            {
                args.Append(" /markupredirect:\"");
                args.Append(textBoxMarkupRedirectBefore.Text);
                args.Append(",");
                args.Append(textBoxMarkupRedirectAfter.Text);
                args.Append(",");
                args.Append(textBoxMarkupRedirectSuffix.Text);
                args.Append("\"");
            }

            if (checkBoxWatchFolder.Checked == true)
            {
                args.Append(" /folder:\"");
                args.Append(textBoxWatchFolderPath.Text);
                args.Append("\"");
                args.Append(" /interval:");
                args.Append(textBoxWatchFolderInterval.Text);
            }

            //
            // If the misc. options have not changed from the last launch
            // then we may not need to spawn a new MCMLPad instance.
            //

            if (args.ToString().Equals(_lastMiscOptions))
                fCanUseExistingPad = true;

            _lastMiscOptions = args.ToString();

            //
            // Now, process the size/position parameters.  If these are
            // specified, and they differ from the current position of
            // an existing mcmlpad instance, then we must recreate the
            // mcmlpad instance in order to position it correctly.
            //

            fPadExists = _remoteControl.GetPositionAndSize(
                            out curPos,
                            out curSize
                            );

            if (checkBoxPosition.Checked)
            {
                int x, y;

                if (!GetNumericValue(textBoxPositionX, out x))
                    return;

                if (!GetNumericValue(textBoxPositionY, out y))
                    return;

                if (fPadExists && (x != curPos.X || y != curPos.Y))
                    fCanUseExistingPad = false;

                args.AppendFormat(" /position:{0},{1}", x, y);

                fPosSpecified = true;
            }

            if (checkBoxSize.Checked)
            {
                int w, h;

                if (!GetNumericValue(textBoxSizeX, out w))
                    return;

                if (!GetNumericValue(textBoxSizeY, out h))
                    return;

                if (fPadExists && (w != curSize.Width || h != curSize.Height))
                    fCanUseExistingPad = false;

                args.AppendFormat(" /size:{0},{1}", w, h);

                fSizeSpecified = true;
            }

            //
            // Now that we have determined if the options have changed or
            // not we can add on the /load parameter.  Note that we need to
            // do this even if we are going to re-use the existing MCMLPad
            // instance because we need to update the textBoxResult field.
            //

            if (!String.IsNullOrEmpty(filepath))
            {
                args.Insert(0, String.Format(" /load:\"{0}\"", filepath));
            }

            //
            // Figure out the path to mcmlpad.exe.  If the user explicitly
            // specified a path then use it, otherwise default to
            // <windir>\ehome\mcmlpad.exe.
            //

            if (_padpath != null)
            {
                mcmlpadpath = _padpath;
            }
            else
            {
                mcmlpadpath = System.Environment.GetEnvironmentVariable("windir");
                mcmlpadpath += "\\ehome\\mcmlpad.exe";
            }

            //
            // Show the user the user friendly form of the command line.
            // Note that we may tack on some additional parameters below,
            // but they are behind the scenes wiring between us and mcmlpad
            // and there is no reason to show these to the user.
            //

            textBoxResult.Text = mcmlpadpath + args.ToString();

            //
            // If:
            //
            //  - The 'Use Single McmlPad Instance' option is enabled,
            //  - AND none of the options changed since the last launch, 
            //  - AND and the prior instance of MCMLPad is still running, 
            //
            // Then we simply send the existing pad a load request and are done.
            //

            if (reusePadMenuItem.Checked && fCanUseExistingPad)
            {
                if (_remoteControl.PadExists)
                {
                    _remoteControl.Load(filepath);
                    return;
                }
            }

            //
            // Otherwise, if we are in single pad instance mode then we need 
            // to close the existing MCMLPad and launch a new one.  If the 
            // user has not explicitly specified size and/or position 
            // parameters, then we try to position the new pad instance in 
            // the same screen location as the old one.  Before closing the 
            // existing instance, we fetch its size and position, and tack 
            // them onto the command line.
            //

            if (reusePadMenuItem.Checked)
            {
                if (fPadExists && !fPosSpecified)
                {
                    args.AppendFormat(" /position:{0},{1}", curPos.X, curPos.Y);
                }

                if (fPadExists && !fSizeSpecified)
                {
                    args.AppendFormat(" /size:{0},{1}", curSize.Width, curSize.Height);
                }

                _remoteControl.Close();
            }

            //
            // Create a new control ID for the new pad instance. Reset the
            // pad controller to use the new ID and pass the ID to the new
            // pad via the command line.
            //

            _remoteControl.ID = Guid.NewGuid().ToString();

            args.AppendFormat(" /controlid:{0}", _remoteControl.ID);

            // Explicitly verify that mcmlpad.exe exists so that we can give
            // the user a straightforward error message if not.

            if (!File.Exists(mcmlpadpath))
            {
                MessageBox.Show(
                    String.Format(McmlPadAuto.Resources.StringMCMLPadNotFound, mcmlpadpath),
                    McmlPadAuto.Resources.StringMCMLPreviewToolLauncher
                    );

                return;
            }

            // Spawn MCMLPad.

            try
            {
                System.Diagnostics.Process.Start(mcmlpadpath, args.ToString());
            }
            catch (Win32Exception e)
            {
                MessageBox.Show(
                    String.Format(McmlPadAuto.Resources.StringMCMLPadLaunchError, e.ToString()),
                    McmlPadAuto.Resources.StringMCMLPreviewToolLauncher
                    );
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ActionOnSelectedItem(true);
        }

        private void ActionOnSelectedItem(bool launchMCMLPad)
        {
            try
            {
                textBoxURI.Text = listBox1.SelectedItem.ToString();
                if (launchMCMLPad)
                {
                    LaunchTool();
                    //LaunchMCMLPad(textBoxURI.Text);
                }
                MyItemLastSelected = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.Insert(0, textBoxURI.Text);
                textBoxURI.Focus();
                textBoxURI.SelectAll();
            }
            catch (NullReferenceException ex)
            {
                Console.Write(ex.ToString());
            }
        }


        private string itemLastSelected;

        public string MyItemLastSelected
        {
            get { return itemLastSelected; }
            set { itemLastSelected = value; }
        }

        private const string HistoryFile = "MCMLPadAuto.History.xml";
        private const string SettingsFile = "MCMLPadAuto.Settings.xml";

        private void WriteSettings(string file)
        {
            XmlWriter writer = null;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            writer = XmlWriter.Create(file, settings);

            writer.WriteComment(McmlPadAuto.Resources.StringXMLElementMCMLPadSettings);

            writer.WriteStartElement("Root");

            writer.WriteStartElement("URI");
            writer.WriteString(textBoxURI.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("Animations");
            writer.WriteString(checkBoxAnimations.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Device");
            writer.WriteString(checkBoxDevice.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("DeviceSetting");
            writer.WriteString(comboBoxDevice.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("Direction");
            writer.WriteString(checkBoxDirection.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("DirectionSetting");
            writer.WriteString(comboBoxDirection.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("Size");
            writer.WriteString(checkBoxSize.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("SizeX");
            writer.WriteString(textBoxSizeX.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("SizeY");
            writer.WriteString(textBoxSizeY.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("Position");
            writer.WriteString(checkBoxPosition.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("PositionX");
            writer.WriteString(textBoxPositionX.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("PositionY");
            writer.WriteString(textBoxPositionY.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("AssemblyRedirect");
            writer.WriteString(checkBoxAssemblyRedirect.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("AssemblyRedirectFullPath");
            writer.WriteString(textBoxAssemblyRedirectFullPath.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("MarkupRedirect");
            writer.WriteString(checkBoxMarkupRedirect.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("MarkupRedirectBefore");
            writer.WriteString(textBoxMarkupRedirectBefore.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("MarkupRedirectAfter");
            writer.WriteString(textBoxMarkupRedirectAfter.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("MarkupRedirectSuffix");
            writer.WriteString(textBoxMarkupRedirectSuffix.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("ReusePadInstance");
            writer.WriteString(reusePadMenuItem.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("openEhShellWithHomepageSwitch");
            writer.WriteString(openWithHomepageToolStripMenuItem.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("openEhShellWithUrlSwitch");
            writer.WriteString(openWithUrlToolStripMenuItem.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("openEhShellWithLaunchcodelessSwitch");
            writer.WriteString(openWithLaunchcodelessToolStripMenuItem.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("openEhShellWithLaunchcodedSwitch");
            writer.WriteString(openWithLaunchcodedToolStripMenuItem.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("WatchFolder");
            writer.WriteString(checkBoxWatchFolder.Checked.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("WatchFolderPath");
            writer.WriteString(textBoxWatchFolderPath.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("WatchFolderInterval");
            writer.WriteString(textBoxWatchFolderInterval.Text);
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
                        case "URI":
                            textBoxURI.Text = valueAsString;
                            break;

                        case "Animations":
                            checkBoxAnimations.Checked = valueAsBool;
                            break;

                        case "Device":
                            checkBoxDevice.Checked = valueAsBool;
                            break;

                        case "DeviceSetting":
                            comboBoxDevice.Text = valueAsString;
                            break;

                        case "Direction":
                            checkBoxDirection.Checked = valueAsBool;
                            break;

                        case "DirectionSetting":
                            comboBoxDirection.Text = valueAsString;
                            break;

                        case "Size":
                            checkBoxSize.Checked = valueAsBool;
                            break;

                        case "SizeX":
                            textBoxSizeX.Text = valueAsString;
                            break;

                        case "SizeY":
                            textBoxSizeY.Text = valueAsString;
                            break;

                        case "Position":
                            checkBoxPosition.Checked = valueAsBool;
                            break;

                        case "PositionX":
                            textBoxPositionX.Text = valueAsString;
                            break;

                        case "PositionY":
                            textBoxPositionY.Text = valueAsString;
                            break;

                        case "AssemblyRedirect":
                            checkBoxAssemblyRedirect.Checked = valueAsBool;
                            break;

                        case "AssemblyRedirectFullPath":
                            textBoxAssemblyRedirectFullPath.Text = valueAsString;
                            break;

                        case "MarkupRedirect":
                            checkBoxMarkupRedirect.Checked = valueAsBool;
                            break;

                        case "MarkupRedirectBefore":
                            textBoxMarkupRedirectBefore.Text = valueAsString;
                            break;

                        case "MarkupRedirectAfter":
                            textBoxMarkupRedirectAfter.Text = valueAsString;
                            break;

                        case "MarkupRedirectSuffix":
                            textBoxMarkupRedirectSuffix.Text = valueAsString;
                            break;

                        case "ReusePadInstance":
                            reusePadMenuItem.Checked = valueAsBool;
                            break;

                        case "openEhShellWithHomepageSwitch":
                            openWithHomepageToolStripMenuItem.Checked = valueAsBool;
                            break;

                        case "openEhShellWithUrlSwitch":
                            openWithUrlToolStripMenuItem.Checked = valueAsBool;
                            break;

                        case "openEhShellWithLaunchcodelessSwitch":
                            openWithLaunchcodelessToolStripMenuItem.Checked = valueAsBool;
                            break;

                        case "openEhShellWithLaunchcodedSwitch":
                            openWithLaunchcodedToolStripMenuItem.Checked = valueAsBool;
                            break;

                        case "WatchFolder":
                            checkBoxWatchFolder.Checked = valueAsBool;
                            break;

                        case "WatchFolderPath":
                            textBoxWatchFolderPath.Text = valueAsString;
                            break;

                        case "WatchFolderInterval":
                            textBoxWatchFolderInterval.Text = valueAsString;
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
        }

        private void WriteHistory(string file)
        {
            //StringBuilder s = new StringBuilder();
            XmlWriter writer = null;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            writer = XmlWriter.Create(file, settings);

            //FX Cop -- the string literals used here would not be localized.
            writer.WriteComment(McmlPadAuto.Resources.StringXMLElementMCMLPadHistory);

            writer.WriteStartElement("Root");
            foreach (object item in listBox1.Items)
            {
                writer.WriteStartElement("Item");
                writer.WriteString(item.ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
        }

        private void ReadHistory(string file)
        {
            if (!File.Exists(file))
                return;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            try
            {
                XmlReader reader = XmlReader.Create(file, settings);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Text:
                            listBox1.Items.Add(reader.Value);
                            break;
                    }
                }
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;

            reusePadMenuItem.Checked = true;

            ReadHistory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + HistoryFile);
            ReadSettings(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + SettingsFile);
            buttonGo.Text = McmlPadAuto.Resources.StringButtonGo;
            buttonBrowse.Text = McmlPadAuto.Resources.StringButtonBrowse;

            labelURI.Text = McmlPadAuto.Resources.StringLabelURI;
            //labelPrefaceFile.Text = McmlPadAuto.Resources.StringLabelPrefaceUI;
            labelHistory.Text = McmlPadAuto.Resources.StringLabelHistory;
            //labelDoubleClickItem.Text = McmlPadAuto.Resources.StringLabelDoubleClickItem;
            //labelDragAndDrop.Text = McmlPadAuto.Resources.StringLabelDragAndDrop;
            fileToolStripMenuItem.Text = McmlPadAuto.Resources.StringMenuFile;
            openHistoryToolStripMenuItem.Text = McmlPadAuto.Resources.StringMenuOpenHistory;
            saveHistoryToolStripMenuItem.Text = McmlPadAuto.Resources.StringMenuSaveHistory;
            optionsToolStripMenuItem.Text = McmlPadAuto.Resources.StringMenuOptions;
            clearHistoryToolStripMenuItem.Text = McmlPadAuto.Resources.StringMenuClearHistory;
            helpToolStripMenuItem.Text = McmlPadAuto.Resources.StringMenuHelp;
            aboutToolStripMenuItem.Text = McmlPadAuto.Resources.StringMenuAbout;
            reusePadMenuItem.Text = McmlPadAuto.Resources.StringMenuReusePad;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Media Center Markup Language Files (*.mcml)|*.mcml|All Files (*.*)|*.*";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                s.Append("file://");
                s.Append(open.FileName);
                textBoxURI.Text = s.ToString();
            }
            buttonGo.Focus();
        }

        private void openHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                s.Append(open.FileName);
                ReadHistory(s.ToString());
            }
            buttonGo.Focus();
        }

        private void saveHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            save.FilterIndex = 1;
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                s.Append(save.FileName);
                WriteHistory(s.ToString());
            }
            buttonGo.Focus();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MyItemLastSelected = null;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                listBox1.Items.Add("file://" + s[i]); ;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                WriteHistory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + HistoryFile);
                WriteSettings(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + SettingsFile);
            }
            catch (UnauthorizedAccessException exNoAccess)
            {
                MessageBox.Show(McmlPadAuto.Resources.StringUnauthorizedAccessException, McmlPadAuto.Resources.StringDialogCaptionProblem);
                Console.Write(exNoAccess.ToString());
            }
        }

        private void checkBoxSize_CheckedChanged(object sender, EventArgs e)
        {
            labelSizeX.Enabled = checkBoxSize.Checked;
            labelSizeY.Enabled = checkBoxSize.Checked;
            textBoxSizeX.Enabled = checkBoxSize.Checked;
            textBoxSizeY.Enabled = checkBoxSize.Checked;
        }

        private void checkBoxPosition_CheckedChanged(object sender, EventArgs e)
        {
            labelPositionX.Enabled = checkBoxPosition.Checked;
            labelPositionY.Enabled = checkBoxPosition.Checked;
            textBoxPositionX.Enabled = checkBoxPosition.Checked;
            textBoxPositionY.Enabled = checkBoxPosition.Checked;
        }

        private void checkBoxDirection_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDirection.Enabled = checkBoxDirection.Checked;
        }

        private void checkBoxAssemblyRedirect_CheckedChanged(object sender, EventArgs e)
        {
            labelAssemblyRedirectFullPath.Enabled = checkBoxAssemblyRedirect.Checked;
            textBoxAssemblyRedirectFullPath.Enabled = checkBoxAssemblyRedirect.Checked;
        }

        private void checkBoxMarkupRedirect_CheckedChanged(object sender, EventArgs e)
        {
            labelMarkupRedirectBefore.Enabled = checkBoxMarkupRedirect.Checked;
            labelMarkupRedirectAfter.Enabled = checkBoxMarkupRedirect.Checked;
            labelMarkupRedirectSuffix.Enabled = checkBoxMarkupRedirect.Checked;
            textBoxMarkupRedirectBefore.Enabled = checkBoxMarkupRedirect.Checked;
            textBoxMarkupRedirectAfter.Enabled = checkBoxMarkupRedirect.Checked;
            textBoxMarkupRedirectSuffix.Enabled = checkBoxMarkupRedirect.Checked;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(McmlPadAuto.Resources.StringWindowsMediaCenterSDK);
            s.Append(Environment.NewLine);
            s.Append(McmlPadAuto.Resources.StringMCMLPreviewToolLauncher);
            s.Append(Environment.NewLine);
            s.Append("Version " + Application.ProductVersion.ToString());
            s.Append(Environment.NewLine);
            s.Append(McmlPadAuto.Resources.StringCopyright);
            MessageBox.Show(s.ToString(), McmlPadAuto.Resources.StringAbout);
        }

        private void checkBoxDevice_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDevice.Enabled = checkBoxDevice.Checked;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (reusePadMenuItem.Checked)
            {
                _remoteControl.Refresh();
            }
            else
            {
                MessageBox.Show("Options > Use Single Preview Tool Instance must be enabled via the menu.", Resources.StringMCMLPreviewToolLauncher);
            }
        }

        private void labelPositionX_DoubleClick(object sender, EventArgs e)
        {
            Point pos;
            Size size;

            if (_remoteControl.GetPositionAndSize(out pos, out size))
            {
                textBoxPositionX.Text = pos.X.ToString();
                textBoxPositionY.Text = pos.Y.ToString();
            }
        }

        private void labelSizeX_DoubleClick(object sender, EventArgs e)
        {
            Point pos;
            Size size;

            if (_remoteControl.GetPositionAndSize(out pos, out size))
            {
                textBoxSizeX.Text = size.Width.ToString();
                textBoxSizeY.Text = size.Height.ToString();
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Enter:
                    listBox1_DoubleClick(sender, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void textBoxURI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGo_Click(sender, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void checkBoxWatchFolder_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWatchFolderPath.Enabled = checkBoxWatchFolder.Checked;
            labelWatchFolderPath.Enabled = checkBoxWatchFolder.Checked;
            textBoxWatchFolderInterval.Enabled = checkBoxWatchFolder.Checked;
            labelWatchedFolderInterval.Enabled = checkBoxWatchFolder.Checked;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActionOnSelectedItem(false);
        }

        private void closeCurrentMCMLPreviewToolInstanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _remoteControl.Close();
        }



        private void openWithHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWithUrlToolStripMenuItem.Checked = false;
            openWithLaunchcodedToolStripMenuItem.Checked = false;
            openWithLaunchcodelessToolStripMenuItem.Checked = false;
        }

        private void openWithUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWithHomepageToolStripMenuItem.Checked = false;
            openWithLaunchcodedToolStripMenuItem.Checked = false;
            openWithLaunchcodelessToolStripMenuItem.Checked = false;
        }

        private void openWithLaunchcodelessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWithHomepageToolStripMenuItem.Checked = false;
            openWithLaunchcodedToolStripMenuItem.Checked = false;
            openWithUrlToolStripMenuItem.Checked = false;
        }

        private void openWithLaunchcodedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWithHomepageToolStripMenuItem.Checked = false;
            openWithLaunchcodelessToolStripMenuItem.Checked = false;
            openWithUrlToolStripMenuItem.Checked = false;
        }

        private void labelURI_Click(object sender, EventArgs e)
        {
            textBoxURI.Focus();
            textBoxURI.SelectAll();
        }

    }
}