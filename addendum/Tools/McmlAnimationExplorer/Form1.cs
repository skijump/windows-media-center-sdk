using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml;
using Microsoft.Win32;

namespace MCMLAnimationExplorer
{
    public partial class Form1 : Form
    {

        // MCMLPad automation objects
        private string _padpath = null;
        private McmlPadController _remoteControl = new McmlPadController();
        private string _lastMiscOptions = null;

        public Form1()
        {
            InitializeComponent();
        }

        public void BuildMCML()
        {
            XmlWriter writer = null;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            writer = XmlWriter.Create(MyMCMLFilePath, settings);

            writer.WriteComment(MCMLAnimationExplorer.Resources.XMLComment);

            writer.WriteStartElement("Mcml", "http://schemas.microsoft.com/2006/mcml");

            writer.WriteStartElement("UI");
            writer.WriteAttributeString("Name", "Default");

            writer.WriteStartElement("Content");

            writer.WriteStartElement("Graphic");
            writer.WriteAttributeString("Name", "MyGraphic");
            writer.WriteAttributeString("Content", textBoxGraphic.Text);
            writer.WriteAttributeString("CenterPointPercent", numericUpDownCenterpointPercentX.Value + "," + numericUpDownCenterpointPercentY.Value + "," + numericUpDownCenterpointPercentZ.Value);
            writer.WriteAttributeString("CenterPointOffset", textBoxCenterpointOffsetX.Text + "," + textBoxCenterpointOffsetY.Text + "," + textBoxCenterpointOffsetZ.Text);

            writer.WriteStartElement("Animations");

            writer.WriteStartElement("Animation");
            writer.WriteAttributeString("Loop", numericUpDownAnimationLoop.Value.ToString());

            writer.WriteStartElement("Keyframes");

            switch (comboBoxAnimationType.Text)
            {
                case "RotationKeyframe":
                    BuildRotationKeyframes(writer);
                    break;

                case "AlphaKeyframe":
                    BuildAlphaKeyframes(writer);
                    break;

                case "ColorKeyframe":
                    BuildColorKeyframes(writer);
                    break;

                case "PositionKeyframe":
                    BuildPositionKeyframes(writer);
                    break;

                case "ScaleKeyframe":
                    BuildScaleKeyframes(writer);
                    break;

                case "SizeKeyframe":
                    BuildSizeKeyframes(writer);
                    break;

                default:
                    break;
            }

            // Keyframes
            writer.WriteEndElement();

            // Animation
            writer.WriteEndElement();

            // Animations
            writer.WriteEndElement();

            // Graphic
            writer.WriteEndElement();

            // Content
            writer.WriteEndElement();

            // UI
            writer.WriteEndElement();

            // MCML
            writer.WriteEndElement();

            writer.Flush();

            writer.Close();

            richTextBox1.LoadFile(MyMCMLFilePath, RichTextBoxStreamType.PlainText);

        }

        #region BuildKeyframes

        public void BuildRotationKeyframes(XmlWriter writer)
        {
            writer.WriteStartElement("RotateKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe1Time.Text);
            writer.WriteAttributeString("Value", numericUpDownKeyframe1Degrees.Value + "deg;" + textBoxKeyframe1X.Text + "," + textBoxKeyframe1Y.Text + "," + textBoxKeyframe1Z.Text);
            writer.WriteAttributeString("Interpolation", comboBoxKeyframe1Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe1RelativeTo.Text);
            writer.WriteEndElement();

            if (checkBoxEnableKeyframe2.Checked)
            {
                writer.WriteStartElement("RotateKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe2Time.Text);
                writer.WriteAttributeString("Value", numericUpDownKeyframe2Degrees.Value + "deg;" + textBoxKeyframe2X.Text + "," + textBoxKeyframe2Y.Text + "," + textBoxKeyframe2Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe2Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe2RelativeTo.Text);
                writer.WriteEndElement();
            }

            if (checkBoxEnableKeyframe3.Checked)
            {
                writer.WriteStartElement("RotateKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe3Time.Text);
                writer.WriteAttributeString("Value", numericUpDownKeyframe3Degrees.Value + "deg;" + textBoxKeyframe3X.Text + "," + textBoxKeyframe3Y.Text + "," + textBoxKeyframe3Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe3Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe3RelativeTo.Text);
                writer.WriteEndElement();
            }

            writer.WriteStartElement("RotateKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe4Time.Text);
            writer.WriteAttributeString("Value", numericUpDownKeyframe4Degrees.Value + "deg;" + textBoxKeyframe4X.Text + "," + textBoxKeyframe4Y.Text + "," + textBoxKeyframe4Z.Text);
            //writer.WriteAttributeString("Interpolation", comboBoxKeyframe4Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe4RelativeTo.Text);
            writer.WriteEndElement();
        }

        public void BuildAlphaKeyframes(XmlWriter writer)
        {
            writer.WriteStartElement("AlphaKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe1Time.Text);
            writer.WriteAttributeString("Value", numericUpDownKeyframe1Alpha.Value.ToString());
            writer.WriteAttributeString("Interpolation", comboBoxKeyframe1Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe1RelativeTo.Text);
            writer.WriteEndElement();

            if (checkBoxEnableKeyframe2.Checked)
            {
                writer.WriteStartElement("AlphaKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe2Time.Text);
                writer.WriteAttributeString("Value", numericUpDownKeyframe2Alpha.Value.ToString());
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe2Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe2RelativeTo.Text);
                writer.WriteEndElement();
            }

            if (checkBoxEnableKeyframe3.Checked)
            {
                writer.WriteStartElement("AlphaKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe3Time.Text);
                writer.WriteAttributeString("Value", numericUpDownKeyframe3Alpha.Value.ToString());
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe3Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe3RelativeTo.Text);
                writer.WriteEndElement();
            }

            writer.WriteStartElement("AlphaKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe4Time.Text);
            writer.WriteAttributeString("Value", numericUpDownKeyframe4Alpha.Value.ToString());
            //writer.WriteAttributeString("Interpolation", comboBoxKeyframe4Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe4RelativeTo.Text);
            writer.WriteEndElement();
        }

        public void BuildColorKeyframes(XmlWriter writer)
        {
            writer.WriteStartElement("ColorKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe1Time.Text);
            writer.WriteAttributeString("Value", comboBoxKeyframe1Color.Text);
            writer.WriteAttributeString("Interpolation", comboBoxKeyframe1Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe1RelativeTo.Text);
            writer.WriteEndElement();

            if (checkBoxEnableKeyframe2.Checked)
            {
                writer.WriteStartElement("ColorKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe2Time.Text);
                writer.WriteAttributeString("Value", comboBoxKeyframe2Color.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe2Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe2RelativeTo.Text);
                writer.WriteEndElement();
            }

            if (checkBoxEnableKeyframe3.Checked)
            {
                writer.WriteStartElement("ColorKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe3Time.Text);
                writer.WriteAttributeString("Value", comboBoxKeyframe3Color.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe3Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe3RelativeTo.Text);
                writer.WriteEndElement();
            }

            writer.WriteStartElement("ColorKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe4Time.Text);
            writer.WriteAttributeString("Value", comboBoxKeyframe4Color.Text);
            //writer.WriteAttributeString("Interpolation", comboBoxKeyframe4Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe4RelativeTo.Text);
            writer.WriteEndElement();
        }

        public void BuildPositionKeyframes(XmlWriter writer)
        {
            writer.WriteStartElement("PositionKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe1Time.Text);
            writer.WriteAttributeString("Value", textBoxKeyframe1X.Text + "," + textBoxKeyframe1Y.Text + "," + textBoxKeyframe1Z.Text);
            writer.WriteAttributeString("Interpolation", comboBoxKeyframe1Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe1RelativeTo.Text);
            writer.WriteEndElement();

            if (checkBoxEnableKeyframe2.Checked)
            {
                writer.WriteStartElement("PositionKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe2Time.Text);
                writer.WriteAttributeString("Value", textBoxKeyframe2X.Text + "," + textBoxKeyframe2Y.Text + "," + textBoxKeyframe2Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe2Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe2RelativeTo.Text);
                writer.WriteEndElement();
            }

            if (checkBoxEnableKeyframe3.Checked)
            {
                writer.WriteStartElement("PositionKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe3Time.Text);
                writer.WriteAttributeString("Value", textBoxKeyframe3X.Text + "," + textBoxKeyframe3Y.Text + "," + textBoxKeyframe3Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe3Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe3RelativeTo.Text);
                writer.WriteEndElement();
            }

            writer.WriteStartElement("PositionKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe4Time.Text);
            writer.WriteAttributeString("Value", textBoxKeyframe4X.Text + "," + textBoxKeyframe4Y.Text + "," + textBoxKeyframe4Z.Text);
            //writer.WriteAttributeString("Interpolation", comboBoxKeyframe4Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe4RelativeTo.Text);
            writer.WriteEndElement();
        }

        public void BuildScaleKeyframes(XmlWriter writer)
        {
            writer.WriteStartElement("ScaleKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe1Time.Text);
            writer.WriteAttributeString("Value", textBoxKeyframe1X.Text + "," + textBoxKeyframe1Y.Text + "," + textBoxKeyframe1Z.Text);
            writer.WriteAttributeString("Interpolation", comboBoxKeyframe1Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe1RelativeTo.Text);
            writer.WriteEndElement();

            if (checkBoxEnableKeyframe2.Checked)
            {
                writer.WriteStartElement("ScaleKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe2Time.Text);
                writer.WriteAttributeString("Value", textBoxKeyframe2X.Text + "," + textBoxKeyframe2Y.Text + "," + textBoxKeyframe2Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe2Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe2RelativeTo.Text);
                writer.WriteEndElement();
            }

            if (checkBoxEnableKeyframe3.Checked)
            {
                writer.WriteStartElement("ScaleKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe3Time.Text);
                writer.WriteAttributeString("Value", textBoxKeyframe3X.Text + "," + textBoxKeyframe3Y.Text + "," + textBoxKeyframe3Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe3Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe3RelativeTo.Text);
                writer.WriteEndElement();
            }

            writer.WriteStartElement("ScaleKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe4Time.Text);
            writer.WriteAttributeString("Value", textBoxKeyframe4X.Text + "," + textBoxKeyframe4Y.Text + "," + textBoxKeyframe4Z.Text);
            //writer.WriteAttributeString("Interpolation", comboBoxKeyframe4Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe4RelativeTo.Text);
            writer.WriteEndElement();
        }

        public void BuildSizeKeyframes(XmlWriter writer)
        {
            writer.WriteStartElement("SizeKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe1Time.Text);
            writer.WriteAttributeString("Value", textBoxKeyframe1X.Text + "," + textBoxKeyframe1Y.Text + "," + textBoxKeyframe1Z.Text);
            writer.WriteAttributeString("Interpolation", comboBoxKeyframe1Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe1RelativeTo.Text);
            writer.WriteEndElement();

            if (checkBoxEnableKeyframe2.Checked)
            {
                writer.WriteStartElement("SizeKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe2Time.Text);
                writer.WriteAttributeString("Value", textBoxKeyframe2X.Text + "," + textBoxKeyframe2Y.Text + "," + textBoxKeyframe2Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe2Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe2RelativeTo.Text);
                writer.WriteEndElement();
            }

            if (checkBoxEnableKeyframe3.Checked)
            {
                writer.WriteStartElement("SizeKeyframe");
                writer.WriteAttributeString("Time", textBoxKeyframe3Time.Text);
                writer.WriteAttributeString("Value", textBoxKeyframe3X.Text + "," + textBoxKeyframe3Y.Text + "," + textBoxKeyframe3Z.Text);
                writer.WriteAttributeString("Interpolation", comboBoxKeyframe3Interpolation.Text);
                writer.WriteAttributeString("RelativeTo", comboBoxKeyframe3RelativeTo.Text);
                writer.WriteEndElement();
            }

            writer.WriteStartElement("SizeKeyframe");
            writer.WriteAttributeString("Time", textBoxKeyframe4Time.Text);
            writer.WriteAttributeString("Value", textBoxKeyframe4X.Text + "," + textBoxKeyframe4Y.Text + "," + textBoxKeyframe4Z.Text);
            //writer.WriteAttributeString("Interpolation", comboBoxKeyframe4Interpolation.Text);
            writer.WriteAttributeString("RelativeTo", comboBoxKeyframe4RelativeTo.Text);
            writer.WriteEndElement();
        }

        #endregion

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
                filepath = "file://" + filepath;
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

            args.AppendFormat(" /folder:{0}", CurrentUserDocumentsFolder);

            args.Append(" /interval:0");            

            if (!File.Exists(mcmlpadpath))
            {
                MessageBox.Show(
                    String.Format(MCMLAnimationExplorer.Resources.StringMCMLPadNotFound, mcmlpadpath),
                    MCMLAnimationExplorer.Resources.ApplicationName
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
                    String.Format(MCMLAnimationExplorer.Resources.StringMCMLPadLaunchError, e.ToString()),
                    MCMLAnimationExplorer.Resources.ApplicationName
                    );
            }
        }

        private void sBuildMCML(object sender, EventArgs e)
        {
            BuildMCML();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder mcmltempfilepath = new StringBuilder();
                mcmltempfilepath.Append(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                CurrentUserDocumentsFolder = mcmltempfilepath.ToString();
                mcmltempfilepath.Append(@"\");
                mcmltempfilepath.Append(tempfile);
                MyMCMLFilePath = mcmltempfilepath.ToString();

                StringBuilder mcmlpadpath = new StringBuilder();
                mcmlpadpath.Append(System.Environment.GetEnvironmentVariable("windir"));
                mcmlpadpath.Append("\\ehome\\mcmlpad.exe");
                MyMCMLPadPath = mcmlpadpath.ToString();

                textBoxGraphic.Text = @"file://" + Application.StartupPath + @"\FourBoxGraphic.png";

                BuildMCML();

                sEnableControls();
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("The " + MCMLAnimationExplorer.Resources.ApplicationName + "executable is copied to a location where you do not have read / write privileges to the file system.", MCMLAnimationExplorer.Resources.ApplicationName);
                Application.ExitThread();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (File.Exists(MyMCMLFilePath))
                {
                    File.Delete(MyMCMLFilePath);
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        #region Properties

        private const string tempfile = "temp.mcml";

        private string currentUserDocumentsFolder;

        public string CurrentUserDocumentsFolder
        {
            get { return currentUserDocumentsFolder; }
            set { currentUserDocumentsFolder = value; }
        }


        private string myMCMLFilePath;

        public string MyMCMLFilePath
        {
            get { return myMCMLFilePath; }
            set { myMCMLFilePath = value; }
        }


        private string MCMLPadPath;

        public string MyMCMLPadPath
        {
            get { return MCMLPadPath; }
            set { MCMLPadPath = value; }
        }

        private string myApplicationPath;

        public string MyApplicationPath
        {
            get { return myApplicationPath; }
            set { myApplicationPath = value; }
        }


        private bool CreateKeyframe2;

        public bool MyCreateKeyframe2
        {
            get { return CreateKeyframe2; }
            set { CreateKeyframe2 = value; }
        }

        #endregion

        #region EnableControls

        private void comboBoxAnimationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            sEnableControls();
        }

        private void sEnableControls()
        {
            switch (comboBoxAnimationType.Text)
            {
                case "AlphaKeyframe":
                    ControlsAlphaEnable(true);
                    ControlsRotationEnable(false);
                    ControlsVector3Enable(false);
                    ControlsColorEnable(false);
                    break;

                case "RotationKeyframe":
                    ControlsAlphaEnable(false);
                    ControlsVector3Enable(false);
                    ControlsRotationEnable(true);
                    ControlsColorEnable(false);
                    break;

                case "PositionKeyframe":
                    ControlsAlphaEnable(false);
                    ControlsRotationEnable(false);
                    ControlsVector3Enable(true);
                    ControlsColorEnable(false);
                    break;

                case "ColorKeyframe":
                    ControlsAlphaEnable(false);
                    ControlsRotationEnable(false);
                    ControlsVector3Enable(false);
                    ControlsColorEnable(true);
                    break;

                case "ScaleKeyframe":
                    ControlsAlphaEnable(false);
                    ControlsRotationEnable(false);
                    ControlsVector3Enable(true);
                    ControlsColorEnable(false);
                    break;

                case "SizeKeyframe":
                    ControlsAlphaEnable(false);
                    ControlsRotationEnable(false);
                    ControlsVector3Enable(true);
                    ControlsColorEnable(false);
                    break;

                default:
                    break;
            }


            BuildMCML();
        }

        private void ControlsRotationEnable(bool which)
        {
            numericUpDownKeyframe1Degrees.Enabled = which;
            numericUpDownKeyframe2Degrees.Enabled = which;
            numericUpDownKeyframe3Degrees.Enabled = which;
            numericUpDownKeyframe4Degrees.Enabled = which;

            textBoxKeyframe1X.Enabled = which;
            textBoxKeyframe2X.Enabled = which;
            textBoxKeyframe3X.Enabled = which;
            textBoxKeyframe4X.Enabled = which;

            textBoxKeyframe1Y.Enabled = which;
            textBoxKeyframe2Y.Enabled = which;
            textBoxKeyframe3Y.Enabled = which;
            textBoxKeyframe4Y.Enabled = which;

            textBoxKeyframe1Z.Enabled = which;
            textBoxKeyframe2Z.Enabled = which;
            textBoxKeyframe3Z.Enabled = which;
            textBoxKeyframe4Z.Enabled = which;

            labelKeyframe1Degrees.Enabled = which;
            labelKeyframe2Degrees.Enabled = which;
            labelKeyframe3Degrees.Enabled = which;
            labelKeyframe4Degrees.Enabled = which;

            labelKeyframe1X.Enabled = which;
            labelKeyframe2X.Enabled = which;
            labelKeyframe3X.Enabled = which;
            labelKeyframe4X.Enabled = which;

            labelKeyframe1Y.Enabled = which;
            labelKeyframe2Y.Enabled = which;
            labelKeyframe3Y.Enabled = which;
            labelKeyframe4Y.Enabled = which;

            labelKeyframe1Z.Enabled = which;
            labelKeyframe2Z.Enabled = which;
            labelKeyframe3Z.Enabled = which;
            labelKeyframe4Z.Enabled = which;
        }

        private void ControlsVector3Enable(bool which)
        {
            textBoxKeyframe1X.Enabled = which;
            textBoxKeyframe2X.Enabled = which;
            textBoxKeyframe3X.Enabled = which;
            textBoxKeyframe4X.Enabled = which;

            textBoxKeyframe1Y.Enabled = which;
            textBoxKeyframe2Y.Enabled = which;
            textBoxKeyframe3Y.Enabled = which;
            textBoxKeyframe4Y.Enabled = which;

            textBoxKeyframe1Z.Enabled = which;
            textBoxKeyframe2Z.Enabled = which;
            textBoxKeyframe3Z.Enabled = which;
            textBoxKeyframe4Z.Enabled = which;

            labelKeyframe1X.Enabled = which;
            labelKeyframe2X.Enabled = which;
            labelKeyframe3X.Enabled = which;
            labelKeyframe4X.Enabled = which;

            labelKeyframe1Y.Enabled = which;
            labelKeyframe2Y.Enabled = which;
            labelKeyframe3Y.Enabled = which;
            labelKeyframe4Y.Enabled = which;

            labelKeyframe1Z.Enabled = which;
            labelKeyframe2Z.Enabled = which;
            labelKeyframe3Z.Enabled = which;
            labelKeyframe4Z.Enabled = which;
        }

        private void ControlsAlphaEnable(bool which)
        {
            numericUpDownKeyframe1Alpha.Enabled = which;
            numericUpDownKeyframe2Alpha.Enabled = which;
            numericUpDownKeyframe3Alpha.Enabled = which;
            numericUpDownKeyframe4Alpha.Enabled = which;

            labelKeyframe1Alpha.Enabled = which;
            labelKeyframe2Alpha.Enabled = which;
            labelKeyframe3Alpha.Enabled = which;
            labelKeyframe4Alpha.Enabled = which;

        }

        private void ControlsColorEnable(bool which)
        {
            labelKeyframe1Color.Enabled = which;
            labelKeyframe2Color.Enabled = which;
            labelKeyframe3Color.Enabled = which;
            labelKeyframe4Color.Enabled = which;

            comboBoxKeyframe1Color.Enabled = which;
            comboBoxKeyframe2Color.Enabled = which;
            comboBoxKeyframe3Color.Enabled = which;
            comboBoxKeyframe4Color.Enabled = which;
        }

        private void checkBoxEnableKeyframe2_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxEnableKeyframe2.Checked)
            {
                case true:
                    groupBoxKeyframe2.Enabled = true;
                    MyCreateKeyframe2 = true;
                    break;
                case false:
                    groupBoxKeyframe2.Enabled = false;
                    MyCreateKeyframe2 = false;
                    break;
            }

            BuildMCML();
        }

        private void checkBoxEnableKeyframe3_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBoxEnableKeyframe3.Checked)
            {
                case true:
                    groupBoxKeyframe3.Enabled = true;
                    break;
                case false:
                    groupBoxKeyframe3.Enabled = false;
                    break;
            }

            BuildMCML();
        }

        #endregion

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Portable Network Graphics Image (*.png)|*.png|All Files (*.*)|*.*";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                s.Append("file://");
                s.Append(open.FileName);
                textBoxGraphic.Text = s.ToString();
            }
        }

        private void buttonLaunchMCMLPad_Click(object sender, EventArgs e)
        {
            BuildMCML();
            LaunchMCMLPad(MyMCMLFilePath);
        }


    }
}