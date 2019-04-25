namespace McmlPadAuto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxURI = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelURI = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reusePadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeCurrentMCMLPreviewToolInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openWithHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithLaunchcodelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithLaunchcodedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxAnimations = new System.Windows.Forms.CheckBox();
            this.checkBoxDirection = new System.Windows.Forms.CheckBox();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.checkBoxPosition = new System.Windows.Forms.CheckBox();
            this.textBoxPositionX = new System.Windows.Forms.TextBox();
            this.textBoxPositionY = new System.Windows.Forms.TextBox();
            this.checkBoxAssemblyRedirect = new System.Windows.Forms.CheckBox();
            this.textBoxAssemblyRedirectFullPath = new System.Windows.Forms.TextBox();
            this.checkBoxMarkupRedirect = new System.Windows.Forms.CheckBox();
            this.textBoxMarkupRedirectBefore = new System.Windows.Forms.TextBox();
            this.textBoxMarkupRedirectAfter = new System.Windows.Forms.TextBox();
            this.textBoxMarkupRedirectSuffix = new System.Windows.Forms.TextBox();
            this.labelAssemblyRedirectFullPath = new System.Windows.Forms.Label();
            this.labelMarkupRedirectBefore = new System.Windows.Forms.Label();
            this.labelMarkupRedirectAfter = new System.Windows.Forms.Label();
            this.labelMarkupRedirectSuffix = new System.Windows.Forms.Label();
            this.labelPositionX = new System.Windows.Forms.Label();
            this.labelPositionY = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.checkBoxDevice = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.checkBoxSize = new System.Windows.Forms.CheckBox();
            this.textBoxSizeX = new System.Windows.Forms.TextBox();
            this.textBoxSizeY = new System.Windows.Forms.TextBox();
            this.labelSizeX = new System.Windows.Forms.Label();
            this.labelSizeY = new System.Windows.Forms.Label();
            this.labelWatchFolderPath = new System.Windows.Forms.Label();
            this.textBoxWatchFolderPath = new System.Windows.Forms.TextBox();
            this.checkBoxWatchFolder = new System.Windows.Forms.CheckBox();
            this.labelWatchedFolderInterval = new System.Windows.Forms.Label();
            this.textBoxWatchFolderInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(695, 36);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxURI
            // 
            this.textBoxURI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURI.Location = new System.Drawing.Point(43, 37);
            this.textBoxURI.Name = "textBoxURI";
            this.textBoxURI.Size = new System.Drawing.Size(565, 23);
            this.textBoxURI.TabIndex = 0;
            this.textBoxURI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxURI_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(758, 229);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem1.Text = "Edit URI";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(614, 36);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelURI
            // 
            this.labelURI.AutoSize = true;
            this.labelURI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURI.Location = new System.Drawing.Point(12, 40);
            this.labelURI.Name = "labelURI";
            this.labelURI.Size = new System.Drawing.Size(25, 15);
            this.labelURI.TabIndex = 5;
            this.labelURI.Text = "URI";
            this.labelURI.Click += new System.EventHandler(this.labelURI_Click);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistory.Location = new System.Drawing.Point(12, 72);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(45, 15);
            this.labelHistory.TabIndex = 7;
            this.labelHistory.Text = "History";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "URI";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHistoryToolStripMenuItem,
            this.saveHistoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openHistoryToolStripMenuItem
            // 
            this.openHistoryToolStripMenuItem.Name = "openHistoryToolStripMenuItem";
            this.openHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openHistoryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openHistoryToolStripMenuItem.Text = "Open History";
            this.openHistoryToolStripMenuItem.Click += new System.EventHandler(this.openHistoryToolStripMenuItem_Click);
            // 
            // saveHistoryToolStripMenuItem
            // 
            this.saveHistoryToolStripMenuItem.Name = "saveHistoryToolStripMenuItem";
            this.saveHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveHistoryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveHistoryToolStripMenuItem.Text = "Save History";
            this.saveHistoryToolStripMenuItem.Click += new System.EventHandler(this.saveHistoryToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.reusePadMenuItem,
            this.toolStripSeparator3,
            this.closeCurrentMCMLPreviewToolInstanceToolStripMenuItem,
            this.toolStripSeparator1,
            this.openWithHomepageToolStripMenuItem,
            this.openWithUrlToolStripMenuItem,
            this.openWithLaunchcodelessToolStripMenuItem,
            this.openWithLaunchcodedToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(328, 6);
            // 
            // reusePadMenuItem
            // 
            this.reusePadMenuItem.CheckOnClick = true;
            this.reusePadMenuItem.Name = "reusePadMenuItem";
            this.reusePadMenuItem.Size = new System.Drawing.Size(331, 22);
            this.reusePadMenuItem.Text = "Use Single Preview Tool Instance";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(328, 6);
            // 
            // closeCurrentMCMLPreviewToolInstanceToolStripMenuItem
            // 
            this.closeCurrentMCMLPreviewToolInstanceToolStripMenuItem.Name = "closeCurrentMCMLPreviewToolInstanceToolStripMenuItem";
            this.closeCurrentMCMLPreviewToolInstanceToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.closeCurrentMCMLPreviewToolInstanceToolStripMenuItem.Text = "C&lose Current Preview Tool Instance";
            this.closeCurrentMCMLPreviewToolInstanceToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentMCMLPreviewToolInstanceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(328, 6);
            // 
            // openWithHomepageToolStripMenuItem
            // 
            this.openWithHomepageToolStripMenuItem.CheckOnClick = true;
            this.openWithHomepageToolStripMenuItem.Name = "openWithHomepageToolStripMenuItem";
            this.openWithHomepageToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.openWithHomepageToolStripMenuItem.Text = "Open With ehShell.exe -homepage (MCML)";
            this.openWithHomepageToolStripMenuItem.Click += new System.EventHandler(this.openWithHomepageToolStripMenuItem_Click);
            // 
            // openWithUrlToolStripMenuItem
            // 
            this.openWithUrlToolStripMenuItem.CheckOnClick = true;
            this.openWithUrlToolStripMenuItem.Name = "openWithUrlToolStripMenuItem";
            this.openWithUrlToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.openWithUrlToolStripMenuItem.Text = "Open With ehShell.exe -url (HTML)";
            this.openWithUrlToolStripMenuItem.Click += new System.EventHandler(this.openWithUrlToolStripMenuItem_Click);
            // 
            // openWithLaunchcodelessToolStripMenuItem
            // 
            this.openWithLaunchcodelessToolStripMenuItem.CheckOnClick = true;
            this.openWithLaunchcodelessToolStripMenuItem.Name = "openWithLaunchcodelessToolStripMenuItem";
            this.openWithLaunchcodelessToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.openWithLaunchcodelessToolStripMenuItem.Text = "Open With ehShell.exe -launchcodeless (MCML)";
            this.openWithLaunchcodelessToolStripMenuItem.Click += new System.EventHandler(this.openWithLaunchcodelessToolStripMenuItem_Click);
            // 
            // openWithLaunchcodedToolStripMenuItem
            // 
            this.openWithLaunchcodedToolStripMenuItem.CheckOnClick = true;
            this.openWithLaunchcodedToolStripMenuItem.Name = "openWithLaunchcodedToolStripMenuItem";
            this.openWithLaunchcodedToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.openWithLaunchcodedToolStripMenuItem.Text = "Open With ehShell.exe -launchcoded (Assembly)";
            this.openWithLaunchcodedToolStripMenuItem.Click += new System.EventHandler(this.openWithLaunchcodedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkBoxAnimations
            // 
            this.checkBoxAnimations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAnimations.AutoSize = true;
            this.checkBoxAnimations.Checked = true;
            this.checkBoxAnimations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnimations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAnimations.Location = new System.Drawing.Point(12, 328);
            this.checkBoxAnimations.Name = "checkBoxAnimations";
            this.checkBoxAnimations.Size = new System.Drawing.Size(87, 19);
            this.checkBoxAnimations.TabIndex = 6;
            this.checkBoxAnimations.Text = "Animations";
            this.checkBoxAnimations.UseVisualStyleBackColor = true;
            // 
            // checkBoxDirection
            // 
            this.checkBoxDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDirection.AutoSize = true;
            this.checkBoxDirection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDirection.Location = new System.Drawing.Point(127, 356);
            this.checkBoxDirection.Name = "checkBoxDirection";
            this.checkBoxDirection.Size = new System.Drawing.Size(74, 19);
            this.checkBoxDirection.TabIndex = 9;
            this.checkBoxDirection.Text = "Direction";
            this.checkBoxDirection.UseVisualStyleBackColor = true;
            this.checkBoxDirection.CheckedChanged += new System.EventHandler(this.checkBoxDirection_CheckedChanged);
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxDirection.Enabled = false;
            this.comboBoxDirection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "Right To Left (RTL)",
            "Left To Right (LTR)"});
            this.comboBoxDirection.Location = new System.Drawing.Point(201, 354);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(146, 23);
            this.comboBoxDirection.TabIndex = 10;
            this.comboBoxDirection.Text = "Right To Left (RTL)";
            // 
            // checkBoxPosition
            // 
            this.checkBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPosition.AutoSize = true;
            this.checkBoxPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPosition.Location = new System.Drawing.Point(360, 356);
            this.checkBoxPosition.Name = "checkBoxPosition";
            this.checkBoxPosition.Size = new System.Drawing.Size(69, 19);
            this.checkBoxPosition.TabIndex = 14;
            this.checkBoxPosition.Text = "Position";
            this.checkBoxPosition.UseVisualStyleBackColor = true;
            this.checkBoxPosition.CheckedChanged += new System.EventHandler(this.checkBoxPosition_CheckedChanged);
            // 
            // textBoxPositionX
            // 
            this.textBoxPositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPositionX.Enabled = false;
            this.textBoxPositionX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPositionX.Location = new System.Drawing.Point(455, 354);
            this.textBoxPositionX.Name = "textBoxPositionX";
            this.textBoxPositionX.Size = new System.Drawing.Size(50, 23);
            this.textBoxPositionX.TabIndex = 15;
            // 
            // textBoxPositionY
            // 
            this.textBoxPositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPositionY.Enabled = false;
            this.textBoxPositionY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPositionY.Location = new System.Drawing.Point(532, 354);
            this.textBoxPositionY.Name = "textBoxPositionY";
            this.textBoxPositionY.Size = new System.Drawing.Size(50, 23);
            this.textBoxPositionY.TabIndex = 16;
            // 
            // checkBoxAssemblyRedirect
            // 
            this.checkBoxAssemblyRedirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAssemblyRedirect.AutoSize = true;
            this.checkBoxAssemblyRedirect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAssemblyRedirect.Location = new System.Drawing.Point(12, 385);
            this.checkBoxAssemblyRedirect.Name = "checkBoxAssemblyRedirect";
            this.checkBoxAssemblyRedirect.Size = new System.Drawing.Size(123, 19);
            this.checkBoxAssemblyRedirect.TabIndex = 17;
            this.checkBoxAssemblyRedirect.Text = "Assembly Redirect";
            this.checkBoxAssemblyRedirect.UseVisualStyleBackColor = true;
            this.checkBoxAssemblyRedirect.CheckedChanged += new System.EventHandler(this.checkBoxAssemblyRedirect_CheckedChanged);
            // 
            // textBoxAssemblyRedirectFullPath
            // 
            this.textBoxAssemblyRedirectFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAssemblyRedirectFullPath.Enabled = false;
            this.textBoxAssemblyRedirectFullPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAssemblyRedirectFullPath.Location = new System.Drawing.Point(201, 383);
            this.textBoxAssemblyRedirectFullPath.Name = "textBoxAssemblyRedirectFullPath";
            this.textBoxAssemblyRedirectFullPath.Size = new System.Drawing.Size(569, 23);
            this.textBoxAssemblyRedirectFullPath.TabIndex = 18;
            // 
            // checkBoxMarkupRedirect
            // 
            this.checkBoxMarkupRedirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxMarkupRedirect.AutoSize = true;
            this.checkBoxMarkupRedirect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMarkupRedirect.Location = new System.Drawing.Point(12, 411);
            this.checkBoxMarkupRedirect.Name = "checkBoxMarkupRedirect";
            this.checkBoxMarkupRedirect.Size = new System.Drawing.Size(113, 19);
            this.checkBoxMarkupRedirect.TabIndex = 19;
            this.checkBoxMarkupRedirect.Text = "Markup Redirect";
            this.checkBoxMarkupRedirect.UseVisualStyleBackColor = true;
            this.checkBoxMarkupRedirect.CheckedChanged += new System.EventHandler(this.checkBoxMarkupRedirect_CheckedChanged);
            // 
            // textBoxMarkupRedirectBefore
            // 
            this.textBoxMarkupRedirectBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMarkupRedirectBefore.Enabled = false;
            this.textBoxMarkupRedirectBefore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarkupRedirectBefore.Location = new System.Drawing.Point(201, 409);
            this.textBoxMarkupRedirectBefore.Name = "textBoxMarkupRedirectBefore";
            this.textBoxMarkupRedirectBefore.Size = new System.Drawing.Size(569, 23);
            this.textBoxMarkupRedirectBefore.TabIndex = 20;
            // 
            // textBoxMarkupRedirectAfter
            // 
            this.textBoxMarkupRedirectAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMarkupRedirectAfter.Enabled = false;
            this.textBoxMarkupRedirectAfter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarkupRedirectAfter.Location = new System.Drawing.Point(201, 435);
            this.textBoxMarkupRedirectAfter.Name = "textBoxMarkupRedirectAfter";
            this.textBoxMarkupRedirectAfter.Size = new System.Drawing.Size(569, 23);
            this.textBoxMarkupRedirectAfter.TabIndex = 21;
            // 
            // textBoxMarkupRedirectSuffix
            // 
            this.textBoxMarkupRedirectSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMarkupRedirectSuffix.Enabled = false;
            this.textBoxMarkupRedirectSuffix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarkupRedirectSuffix.Location = new System.Drawing.Point(201, 461);
            this.textBoxMarkupRedirectSuffix.Name = "textBoxMarkupRedirectSuffix";
            this.textBoxMarkupRedirectSuffix.Size = new System.Drawing.Size(98, 23);
            this.textBoxMarkupRedirectSuffix.TabIndex = 22;
            // 
            // labelAssemblyRedirectFullPath
            // 
            this.labelAssemblyRedirectFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAssemblyRedirectFullPath.AutoSize = true;
            this.labelAssemblyRedirectFullPath.Enabled = false;
            this.labelAssemblyRedirectFullPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssemblyRedirectFullPath.Location = new System.Drawing.Point(142, 386);
            this.labelAssemblyRedirectFullPath.Name = "labelAssemblyRedirectFullPath";
            this.labelAssemblyRedirectFullPath.Size = new System.Drawing.Size(53, 15);
            this.labelAssemblyRedirectFullPath.TabIndex = 25;
            this.labelAssemblyRedirectFullPath.Text = "Full Path";
            // 
            // labelMarkupRedirectBefore
            // 
            this.labelMarkupRedirectBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMarkupRedirectBefore.AutoSize = true;
            this.labelMarkupRedirectBefore.Enabled = false;
            this.labelMarkupRedirectBefore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarkupRedirectBefore.Location = new System.Drawing.Point(142, 412);
            this.labelMarkupRedirectBefore.Name = "labelMarkupRedirectBefore";
            this.labelMarkupRedirectBefore.Size = new System.Drawing.Size(41, 15);
            this.labelMarkupRedirectBefore.TabIndex = 26;
            this.labelMarkupRedirectBefore.Text = "Before";
            // 
            // labelMarkupRedirectAfter
            // 
            this.labelMarkupRedirectAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMarkupRedirectAfter.AutoSize = true;
            this.labelMarkupRedirectAfter.Enabled = false;
            this.labelMarkupRedirectAfter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarkupRedirectAfter.Location = new System.Drawing.Point(142, 438);
            this.labelMarkupRedirectAfter.Name = "labelMarkupRedirectAfter";
            this.labelMarkupRedirectAfter.Size = new System.Drawing.Size(33, 15);
            this.labelMarkupRedirectAfter.TabIndex = 27;
            this.labelMarkupRedirectAfter.Text = "After";
            // 
            // labelMarkupRedirectSuffix
            // 
            this.labelMarkupRedirectSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMarkupRedirectSuffix.AutoSize = true;
            this.labelMarkupRedirectSuffix.Enabled = false;
            this.labelMarkupRedirectSuffix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarkupRedirectSuffix.Location = new System.Drawing.Point(142, 464);
            this.labelMarkupRedirectSuffix.Name = "labelMarkupRedirectSuffix";
            this.labelMarkupRedirectSuffix.Size = new System.Drawing.Size(36, 15);
            this.labelMarkupRedirectSuffix.TabIndex = 28;
            this.labelMarkupRedirectSuffix.Text = "Suffix";
            // 
            // labelPositionX
            // 
            this.labelPositionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPositionX.AutoSize = true;
            this.labelPositionX.Enabled = false;
            this.labelPositionX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositionX.Location = new System.Drawing.Point(435, 357);
            this.labelPositionX.Name = "labelPositionX";
            this.labelPositionX.Size = new System.Drawing.Size(14, 15);
            this.labelPositionX.TabIndex = 29;
            this.labelPositionX.Text = "X";
            this.labelPositionX.DoubleClick += new System.EventHandler(this.labelPositionX_DoubleClick);
            // 
            // labelPositionY
            // 
            this.labelPositionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPositionY.AutoSize = true;
            this.labelPositionY.Enabled = false;
            this.labelPositionY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositionY.Location = new System.Drawing.Point(515, 357);
            this.labelPositionY.Name = "labelPositionY";
            this.labelPositionY.Size = new System.Drawing.Size(14, 15);
            this.labelPositionY.TabIndex = 30;
            this.labelPositionY.Text = "Y";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 539);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(758, 43);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TabStop = false;
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxDevice.Enabled = false;
            this.comboBoxDevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Items.AddRange(new object[] {
            "DX9",
            "GDI"});
            this.comboBoxDevice.Location = new System.Drawing.Point(201, 327);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(146, 23);
            this.comboBoxDevice.TabIndex = 8;
            this.comboBoxDevice.Text = "DX9";
            // 
            // checkBoxDevice
            // 
            this.checkBoxDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDevice.AutoSize = true;
            this.checkBoxDevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDevice.Location = new System.Drawing.Point(127, 328);
            this.checkBoxDevice.Name = "checkBoxDevice";
            this.checkBoxDevice.Size = new System.Drawing.Size(61, 19);
            this.checkBoxDevice.TabIndex = 7;
            this.checkBoxDevice.Text = "Device";
            this.checkBoxDevice.UseVisualStyleBackColor = true;
            this.checkBoxDevice.CheckedChanged += new System.EventHandler(this.checkBoxDevice_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(601, 340);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(169, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "&Refresh Preview Tool";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkBoxSize
            // 
            this.checkBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSize.AutoSize = true;
            this.checkBoxSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSize.Location = new System.Drawing.Point(360, 328);
            this.checkBoxSize.Name = "checkBoxSize";
            this.checkBoxSize.Size = new System.Drawing.Size(46, 19);
            this.checkBoxSize.TabIndex = 11;
            this.checkBoxSize.Text = "Size";
            this.checkBoxSize.UseVisualStyleBackColor = true;
            this.checkBoxSize.CheckedChanged += new System.EventHandler(this.checkBoxSize_CheckedChanged);
            // 
            // textBoxSizeX
            // 
            this.textBoxSizeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSizeX.Enabled = false;
            this.textBoxSizeX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSizeX.Location = new System.Drawing.Point(455, 326);
            this.textBoxSizeX.Name = "textBoxSizeX";
            this.textBoxSizeX.Size = new System.Drawing.Size(50, 23);
            this.textBoxSizeX.TabIndex = 12;
            // 
            // textBoxSizeY
            // 
            this.textBoxSizeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSizeY.Enabled = false;
            this.textBoxSizeY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSizeY.Location = new System.Drawing.Point(532, 326);
            this.textBoxSizeY.Name = "textBoxSizeY";
            this.textBoxSizeY.Size = new System.Drawing.Size(50, 23);
            this.textBoxSizeY.TabIndex = 13;
            // 
            // labelSizeX
            // 
            this.labelSizeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSizeX.AutoSize = true;
            this.labelSizeX.Enabled = false;
            this.labelSizeX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeX.Location = new System.Drawing.Point(435, 329);
            this.labelSizeX.Name = "labelSizeX";
            this.labelSizeX.Size = new System.Drawing.Size(14, 15);
            this.labelSizeX.TabIndex = 29;
            this.labelSizeX.Text = "X";
            this.labelSizeX.DoubleClick += new System.EventHandler(this.labelSizeX_DoubleClick);
            // 
            // labelSizeY
            // 
            this.labelSizeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSizeY.AutoSize = true;
            this.labelSizeY.Enabled = false;
            this.labelSizeY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeY.Location = new System.Drawing.Point(515, 329);
            this.labelSizeY.Name = "labelSizeY";
            this.labelSizeY.Size = new System.Drawing.Size(14, 15);
            this.labelSizeY.TabIndex = 30;
            this.labelSizeY.Text = "Y";
            // 
            // labelWatchFolderPath
            // 
            this.labelWatchFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWatchFolderPath.AutoSize = true;
            this.labelWatchFolderPath.Enabled = false;
            this.labelWatchFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWatchFolderPath.Location = new System.Drawing.Point(142, 493);
            this.labelWatchFolderPath.Name = "labelWatchFolderPath";
            this.labelWatchFolderPath.Size = new System.Drawing.Size(31, 15);
            this.labelWatchFolderPath.TabIndex = 33;
            this.labelWatchFolderPath.Text = "Path";
            // 
            // textBoxWatchFolderPath
            // 
            this.textBoxWatchFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWatchFolderPath.Enabled = false;
            this.textBoxWatchFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWatchFolderPath.Location = new System.Drawing.Point(201, 490);
            this.textBoxWatchFolderPath.Name = "textBoxWatchFolderPath";
            this.textBoxWatchFolderPath.Size = new System.Drawing.Size(381, 23);
            this.textBoxWatchFolderPath.TabIndex = 32;
            // 
            // checkBoxWatchFolder
            // 
            this.checkBoxWatchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWatchFolder.AutoSize = true;
            this.checkBoxWatchFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWatchFolder.Location = new System.Drawing.Point(12, 492);
            this.checkBoxWatchFolder.Name = "checkBoxWatchFolder";
            this.checkBoxWatchFolder.Size = new System.Drawing.Size(96, 19);
            this.checkBoxWatchFolder.TabIndex = 31;
            this.checkBoxWatchFolder.Text = "Watch Folder";
            this.checkBoxWatchFolder.UseVisualStyleBackColor = true;
            this.checkBoxWatchFolder.CheckedChanged += new System.EventHandler(this.checkBoxWatchFolder_CheckedChanged);
            // 
            // labelWatchedFolderInterval
            // 
            this.labelWatchedFolderInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWatchedFolderInterval.AutoSize = true;
            this.labelWatchedFolderInterval.Enabled = false;
            this.labelWatchedFolderInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWatchedFolderInterval.Location = new System.Drawing.Point(611, 493);
            this.labelWatchedFolderInterval.Name = "labelWatchedFolderInterval";
            this.labelWatchedFolderInterval.Size = new System.Drawing.Size(101, 15);
            this.labelWatchedFolderInterval.TabIndex = 35;
            this.labelWatchedFolderInterval.Text = "Interval (Seconds)";
            // 
            // textBoxWatchFolderInterval
            // 
            this.textBoxWatchFolderInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWatchFolderInterval.Enabled = false;
            this.textBoxWatchFolderInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWatchFolderInterval.Location = new System.Drawing.Point(715, 490);
            this.textBoxWatchFolderInterval.Name = "textBoxWatchFolderInterval";
            this.textBoxWatchFolderInterval.Size = new System.Drawing.Size(53, 23);
            this.textBoxWatchFolderInterval.TabIndex = 34;
            this.textBoxWatchFolderInterval.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Command Line Result";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxWatchFolderInterval);
            this.Controls.Add(this.labelWatchedFolderInterval);
            this.Controls.Add(this.labelWatchFolderPath);
            this.Controls.Add(this.textBoxWatchFolderPath);
            this.Controls.Add(this.checkBoxWatchFolder);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxURI);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.checkBoxDevice);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.labelSizeY);
            this.Controls.Add(this.labelPositionY);
            this.Controls.Add(this.labelSizeX);
            this.Controls.Add(this.labelPositionX);
            this.Controls.Add(this.labelMarkupRedirectSuffix);
            this.Controls.Add(this.labelMarkupRedirectAfter);
            this.Controls.Add(this.labelMarkupRedirectBefore);
            this.Controls.Add(this.labelAssemblyRedirectFullPath);
            this.Controls.Add(this.textBoxMarkupRedirectSuffix);
            this.Controls.Add(this.textBoxMarkupRedirectAfter);
            this.Controls.Add(this.textBoxMarkupRedirectBefore);
            this.Controls.Add(this.checkBoxMarkupRedirect);
            this.Controls.Add(this.textBoxAssemblyRedirectFullPath);
            this.Controls.Add(this.checkBoxAssemblyRedirect);
            this.Controls.Add(this.textBoxSizeY);
            this.Controls.Add(this.textBoxPositionY);
            this.Controls.Add(this.textBoxSizeX);
            this.Controls.Add(this.textBoxPositionX);
            this.Controls.Add(this.checkBoxSize);
            this.Controls.Add(this.checkBoxPosition);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.checkBoxDirection);
            this.Controls.Add(this.checkBoxAnimations);
            this.Controls.Add(this.labelURI);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "Form1";
            this.Text = "Preview Tool Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxURI;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelURI;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAnimations;
        private System.Windows.Forms.CheckBox checkBoxDirection;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.CheckBox checkBoxPosition;
        private System.Windows.Forms.TextBox textBoxPositionX;
        private System.Windows.Forms.TextBox textBoxPositionY;
        private System.Windows.Forms.CheckBox checkBoxAssemblyRedirect;
        private System.Windows.Forms.TextBox textBoxAssemblyRedirectFullPath;
        private System.Windows.Forms.CheckBox checkBoxMarkupRedirect;
        private System.Windows.Forms.TextBox textBoxMarkupRedirectBefore;
        private System.Windows.Forms.TextBox textBoxMarkupRedirectAfter;
        private System.Windows.Forms.TextBox textBoxMarkupRedirectSuffix;
        private System.Windows.Forms.Label labelAssemblyRedirectFullPath;
        private System.Windows.Forms.Label labelMarkupRedirectBefore;
        private System.Windows.Forms.Label labelMarkupRedirectAfter;
        private System.Windows.Forms.Label labelMarkupRedirectSuffix;
        private System.Windows.Forms.Label labelPositionX;
        private System.Windows.Forms.Label labelPositionY;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.CheckBox checkBoxDevice;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxSize;
        private System.Windows.Forms.TextBox textBoxSizeX;
        private System.Windows.Forms.TextBox textBoxSizeY;
        private System.Windows.Forms.Label labelSizeX;
        private System.Windows.Forms.Label labelSizeY;
        private System.Windows.Forms.ToolStripMenuItem reusePadMenuItem;
        private System.Windows.Forms.Label labelWatchFolderPath;
        private System.Windows.Forms.TextBox textBoxWatchFolderPath;
        private System.Windows.Forms.CheckBox checkBoxWatchFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label labelWatchedFolderInterval;
        private System.Windows.Forms.TextBox textBoxWatchFolderInterval;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentMCMLPreviewToolInstanceToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem openWithHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithLaunchcodelessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithLaunchcodedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

