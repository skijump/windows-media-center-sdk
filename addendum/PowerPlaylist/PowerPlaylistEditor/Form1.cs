// Copyright Microsoft Corporation

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Xml;
using System.IO;

namespace PowerPlaylistEditor
{
    public partial class Form1 : Form
    {

        private DataSet dataSet;
        private string DataDirectory = "";
        private string fileName = "data.xml";

        public Form1()
        {
            InitializeComponent();
            DataDirectory = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\", @"Microsoft\PowerPlaylist2", @"DataLocation");
            LoadData();
            ParseData();
        }

        private void ParseData()
        {

            string temp = "";

            // Start Menu strip title
            textBoxStartMenuTitle.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Start Menu\Applications\{94761D39-3AAF-4c54-A2D3-CBDA27D2229C}", @"Title");

            // First Tile
            textBoxTile1Title.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{DFD75E76-7530-4d0d-A126-71863200A556}", @"Title");
            textBoxTile1Image.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{DFD75E76-7530-4d0d-A126-71863200A556}", @"ImageURL");
            textBoxTile1ImageNonfocus.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{DFD75E76-7530-4d0d-A126-71863200A556}", @"InactiveImageURL");

            DataRow dataRow = GetSingleDataRow(dataSet.Tables["Table"], "ID=1");

            textBoxTile1Audio.Text = dataRow[1].ToString();
            textBoxTile1Slideshow.Text = dataRow[2].ToString();
            textBoxTile1Visualization.Text = dataRow[3].ToString();

            temp = dataRow[4].ToString();

            if (temp == "true")
            {
                checkBoxTile1Disable.CheckState = CheckState.Checked;
            }

            // Second Tile
            textBoxTile2Title.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{B9B49DBF-FB85-4a80-BEB7-5732C4BA849E}", @"Title");
            textBoxTile2Image.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{B9B49DBF-FB85-4a80-BEB7-5732C4BA849E}", @"ImageURL");
            textBoxTile2ImageNonfocus.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{B9B49DBF-FB85-4a80-BEB7-5732C4BA849E}", @"InactiveImageURL");

            dataRow = GetSingleDataRow(dataSet.Tables["Table"], "ID=2");

            textBoxTile2Audio.Text = dataRow[1].ToString();
            textBoxTile2Slideshow.Text = dataRow[2].ToString();
            textBoxTile2Visualization.Text = dataRow[3].ToString();

            temp = dataRow[4].ToString();

            if (temp == "true")
            {
                checkBoxTile2Disable.CheckState = CheckState.Checked;
            }

            // Third Tile
            textBoxTile3Title.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{4A03B055-EEA0-466f-B4FD-AE72D41FDB02}", @"Title");
            textBoxTile3Image.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{4A03B055-EEA0-466f-B4FD-AE72D41FDB02}", @"ImageURL");
            textBoxTile3ImageNonfocus.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{4A03B055-EEA0-466f-B4FD-AE72D41FDB02}", @"InactiveImageURL");

            dataRow = GetSingleDataRow(dataSet.Tables["Table"], "ID=3");

            textBoxTile3Audio.Text = dataRow[1].ToString();
            textBoxTile3Slideshow.Text = dataRow[2].ToString();
            textBoxTile3Visualization.Text = dataRow[3].ToString();

            temp = dataRow[4].ToString();

            if (temp == "true")
            {
                checkBoxTile3Disable.CheckState = CheckState.Checked;
            }

            // Fourth Tile
            textBoxTile4Title.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{F8216194-C5C8-4fc8-98B8-B33EF15B36AA}", @"Title");
            textBoxTile4Image.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{F8216194-C5C8-4fc8-98B8-B33EF15B36AA}", @"ImageURL");
            textBoxTile4ImageNonfocus.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{F8216194-C5C8-4fc8-98B8-B33EF15B36AA}", @"InactiveImageURL");

            dataRow = GetSingleDataRow(dataSet.Tables["Table"], "ID=4");

            textBoxTile4Audio.Text = dataRow[1].ToString();
            textBoxTile4Slideshow.Text = dataRow[2].ToString();
            textBoxTile4Visualization.Text = dataRow[3].ToString();

            temp = dataRow[4].ToString();

            if (temp == "true")
            {
                checkBoxTile4Disable.CheckState = CheckState.Checked;
            }

            // Fifth Tile
            textBoxTile5Title.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{9580A0B8-F06F-4422-94D2-4AAE0A26B3B3}", @"Title");
            textBoxTile5Image.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{9580A0B8-F06F-4422-94D2-4AAE0A26B3B3}", @"ImageURL");
            textBoxTile5ImageNonfocus.Text = GetRegistryValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{9580A0B8-F06F-4422-94D2-4AAE0A26B3B3}", @"InactiveImageURL");

            dataRow = GetSingleDataRow(dataSet.Tables["Table"], "ID=5");

            textBoxTile5Audio.Text = dataRow[1].ToString();
            textBoxTile5Slideshow.Text = dataRow[2].ToString();
            textBoxTile5Visualization.Text = dataRow[3].ToString();

            temp = dataRow[4].ToString();

            if (temp == "true")
            {
                checkBoxTile5Disable.CheckState = CheckState.Checked;
            }
        }

        private string GetRegistryValue(string keyName, string valueName)
        {
            string value = Registry.GetValue(keyName, valueName, null) as string;
            return value;
        }

        private string GetRegistryValue(string keyName1, string keyName2, string valueName)
        {
            string value = Registry.GetValue(keyName1 + keyName2, valueName, null) as string;
            if (value == null)
                value = Registry.GetValue(keyName1 + @"Wow6432Node\" + keyName2, valueName, null) as string;
            return value;
        }

        private static DataRow GetSingleDataRow(DataTable table, string expression)
        {
            DataRow[] foundRows;
            foundRows = table.Select(expression);
            return foundRows[0];
        }

        private void LoadData()
        {
            TextReader rawReader = null;

            try
            {
                rawReader = new StreamReader(DataDirectory + fileName);
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("Can't find the data folder. " + e.Message);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Can't find the data file. " + e.Message);
                return;
            }

            XmlReader xmlReader = new XmlTextReader(rawReader);

            dataSet = new DataSet();
            dataSet.ReadXml(xmlReader);

            xmlReader.Close();
            rawReader.Close();
        }

        private void SaveRegistry()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Start Menu\Applications\{94761D39-3AAF-4c54-A2D3-CBDA27D2229C}", @"Title", textBoxStartMenuTitle.Text);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{DFD75E76-7530-4d0d-A126-71863200A556}", @"Title", textBoxTile1Title.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{DFD75E76-7530-4d0d-A126-71863200A556}", @"ImageURL", textBoxTile1Image.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{DFD75E76-7530-4d0d-A126-71863200A556}", @"InactiveImageURL", textBoxTile1ImageNonfocus.Text);            

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{B9B49DBF-FB85-4a80-BEB7-5732C4BA849E}", @"Title", textBoxTile2Title.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{B9B49DBF-FB85-4a80-BEB7-5732C4BA849E}", @"ImageURL", textBoxTile2Image.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{B9B49DBF-FB85-4a80-BEB7-5732C4BA849E}", @"InactiveImageURL", textBoxTile2ImageNonfocus.Text);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{4A03B055-EEA0-466f-B4FD-AE72D41FDB02}", @"Title", textBoxTile3Title.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{4A03B055-EEA0-466f-B4FD-AE72D41FDB02}", @"ImageURL", textBoxTile3Image.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{4A03B055-EEA0-466f-B4FD-AE72D41FDB02}", @"InactiveImageURL", textBoxTile3ImageNonfocus.Text);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{F8216194-C5C8-4fc8-98B8-B33EF15B36AA}", @"Title", textBoxTile4Title.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{F8216194-C5C8-4fc8-98B8-B33EF15B36AA}", @"ImageURL", textBoxTile4Image.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{F8216194-C5C8-4fc8-98B8-B33EF15B36AA}", @"InactiveImageURL", textBoxTile4ImageNonfocus.Text);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{9580A0B8-F06F-4422-94D2-4AAE0A26B3B3}", @"Title", textBoxTile5Title.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{9580A0B8-F06F-4422-94D2-4AAE0A26B3B3}", @"ImageURL", textBoxTile5Image.Text);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{9580A0B8-F06F-4422-94D2-4AAE0A26B3B3}", @"InactiveImageURL", textBoxTile5ImageNonfocus.Text);
        }

        private void SaveData()
        {
            XmlTextWriter writer = new XmlTextWriter(DataDirectory + fileName, Encoding.UTF8);

            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement("dataroot");

            writer.WriteStartElement("Table");

            writer.WriteElementString("ID", "1");
            writer.WriteElementString("Audio", textBoxTile1Audio.Text);
            writer.WriteElementString("SlideshowFolder", textBoxTile1Slideshow.Text);
            writer.WriteElementString("Visualization", textBoxTile1Visualization.Text);

            if (checkBoxTile1Disable.CheckState == CheckState.Checked)
            {
                writer.WriteElementString("HideTile", "true");
            }
            else
            {
                writer.WriteElementString("HideTile", "false");
            }

            writer.WriteEndElement();

            writer.WriteStartElement("Table");

            writer.WriteElementString("ID", "2");
            writer.WriteElementString("Audio", textBoxTile2Audio.Text);
            writer.WriteElementString("SlideshowFolder", textBoxTile2Slideshow.Text);
            writer.WriteElementString("Visualization", textBoxTile2Visualization.Text);

            if (checkBoxTile2Disable.CheckState == CheckState.Checked)
            {
                writer.WriteElementString("HideTile", "true");
            }
            else
            {
                writer.WriteElementString("HideTile", "false");
            }

            writer.WriteEndElement();

            writer.WriteStartElement("Table");

            writer.WriteElementString("ID", "3");
            writer.WriteElementString("Audio", textBoxTile3Audio.Text);
            writer.WriteElementString("SlideshowFolder", textBoxTile3Slideshow.Text);
            writer.WriteElementString("Visualization", textBoxTile3Visualization.Text);

            if (checkBoxTile3Disable.CheckState == CheckState.Checked)
            {
                writer.WriteElementString("HideTile", "true");
            }
            else
            {
                writer.WriteElementString("HideTile", "false");
            }

            writer.WriteEndElement();

            writer.WriteStartElement("Table");

            writer.WriteElementString("ID", "4");
            writer.WriteElementString("Audio", textBoxTile4Audio.Text);
            writer.WriteElementString("SlideshowFolder", textBoxTile4Slideshow.Text);
            writer.WriteElementString("Visualization", textBoxTile4Visualization.Text);

            if (checkBoxTile4Disable.CheckState == CheckState.Checked)
            {
                writer.WriteElementString("HideTile", "true");
            }
            else
            {
                writer.WriteElementString("HideTile", "false");
            }

            writer.WriteEndElement();

            writer.WriteStartElement("Table");

            writer.WriteElementString("ID", "5");
            writer.WriteElementString("Audio", textBoxTile5Audio.Text);
            writer.WriteElementString("SlideshowFolder", textBoxTile5Slideshow.Text);
            writer.WriteElementString("Visualization", textBoxTile5Visualization.Text);

            if (checkBoxTile5Disable.CheckState == CheckState.Checked)
            {
                writer.WriteElementString("HideTile", "true");
            }
            else
            {
                writer.WriteElementString("HideTile", "false");
            }

            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }

        private void HideTiles()
        {
            if (checkBoxTile1Disable.Checked)
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{dfd75e76-7530-4d0d-a126-71863200a556}", @"AppId", "Disabled by PowerPlaylistEditor");
            }
            else
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{dfd75e76-7530-4d0d-a126-71863200a556}", @"AppId", "{94761d39-3aaf-4c54-a2d3-cbda27d2229c}");
            }

            if (checkBoxTile2Disable.Checked)
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{b9b49dbf-fb85-4a80-beb7-5732c4ba849e}", @"AppId", "Disabled by PowerPlaylistEditor");
            }
            else
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{b9b49dbf-fb85-4a80-beb7-5732c4ba849e}", @"AppId", "{94761d39-3aaf-4c54-a2d3-cbda27d2229c}");
            }

            if (checkBoxTile3Disable.Checked)
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{4a03b055-eea0-466f-b4fd-ae72d41fdb02}", @"AppId", "Disabled by PowerPlaylistEditor");
            }
            else
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{4a03b055-eea0-466f-b4fd-ae72d41fdb02}", @"AppId", "{94761d39-3aaf-4c54-a2d3-cbda27d2229c}");
            }

            if (checkBoxTile4Disable.Checked)
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{f8216194-c5c8-4fc8-98b8-b33ef15b36aa}", @"AppId", "Disabled by PowerPlaylistEditor");
            }
            else
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{f8216194-c5c8-4fc8-98b8-b33ef15b36aa}", @"AppId", "{94761d39-3aaf-4c54-a2d3-cbda27d2229c}");
            }

            if (checkBoxTile5Disable.Checked)
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{9580a0b8-f06f-4422-94d2-4aae0a26b3b3}", @"AppId", "Disabled by PowerPlaylistEditor");
            }
            else
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\Custom Start Menu\PowerPlaylist 2\{9580a0b8-f06f-4422-94d2-4aae0a26b3b3}", @"AppId", "{94761d39-3aaf-4c54-a2d3-cbda27d2229c}");
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveRegistry();
            SaveData();
            HideTiles();
        }

        private string SelectFile(string filter)
        {
            string result = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            switch (filter)
            {
                case "png":
                    openFileDialog1.Filter = "Portable Network Graphic Files (*.png)|*.png|All files (*.*)|*.*";
                    break;
                case "wpl":
                    openFileDialog1.Filter = "Windows Media Player Playlist (*.wpl)|*.wpl|All files (*.*)|*.*";
                    break;

            }
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                result = openFileDialog1.FileName;
            }

            return result;
        }

        private string SelectFolder()
        {
            string result = "";
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                result = folderDialog.SelectedPath;
            }

            return result;
        }

        private string SelectFileImage()
        {
            return SelectFile("png");
        }

        private string SelectFileAudio()
        {
            return SelectFile("wpl");
        }

        private void SetImage(TextBox textBox)
        {
            string temp = SelectFileImage();
            if (!string.IsNullOrEmpty(temp))
            {
                textBox.Text = temp;
            }
        }

        private void SetAudio(TextBox textBox)
        {
            string temp = SelectFileAudio();
            if (!string.IsNullOrEmpty(temp))
            {
                textBox.Text = temp;
            }
        }

        private void SetSlideshow(TextBox textBox)
        {
            string temp = SelectFolder();
            if (!string.IsNullOrEmpty(temp))
            {
                textBox.Text = temp;
            }
        }

        private void buttonBrowseTile1Image_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile1Image);
        }

        private void buttonBrowseTile1Audio_Click(object sender, EventArgs e)
        {
            SetAudio(textBoxTile1Audio);
        }

        private void buttonBrowseTile1Slideshow_Click(object sender, EventArgs e)
        {
            SetSlideshow(textBoxTile1Slideshow);
        }

        private void buttonBrowseTile2Image_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile2Image);
        }

        private void buttonBrowseTile2Audio_Click(object sender, EventArgs e)
        {
            SetAudio(textBoxTile2Audio);
        }

        private void buttonBrowseTile2Slideshow_Click(object sender, EventArgs e)
        {
            SetSlideshow(textBoxTile2Slideshow);
        }

        private void buttonBrowseTile3Image_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile3Image);
        }

        private void buttonBrowseTile3Audio_Click(object sender, EventArgs e)
        {
            SetAudio(textBoxTile3Audio);
        }

        private void buttonBrowseTile3Slideshow_Click(object sender, EventArgs e)
        {
            SetSlideshow(textBoxTile3Slideshow);
        }

        private void buttonBrowseTile4Image_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile4Image);
        }

        private void buttonBrowseTile4Audio_Click(object sender, EventArgs e)
        {
            SetAudio(textBoxTile4Audio);
        }

        private void buttonBrowseTile4Slideshow_Click(object sender, EventArgs e)
        {
            SetSlideshow(textBoxTile4Slideshow);
        }

        private void buttonBrowseTile5Image_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile5Image);
        }

        private void buttonBrowseTile5Audio_Click(object sender, EventArgs e)
        {
            SetAudio(textBoxTile5Audio);
        }

        private void buttonBrowseTile5Slideshow_Click(object sender, EventArgs e)
        {
            SetSlideshow(textBoxTile5Slideshow);
        }

        private void buttonBrowseTile1ImageNonfocus_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile1ImageNonfocus);
        }

        private void buttonBrowseTile2ImageNonfocus_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile2ImageNonfocus);
        }

        private void buttonBrowseTile3ImageNonfocus_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile3ImageNonfocus);
        }

        private void buttonBrowseTile4ImageNonfocus_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile4ImageNonfocus);
        }

        private void buttonBrowseTile5ImageNonfocus_Click(object sender, EventArgs e)
        {
            SetImage(textBoxTile5ImageNonfocus);
        }
    }
}