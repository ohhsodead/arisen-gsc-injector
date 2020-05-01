namespace AtomicX.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SectionModsLibrary = new DarkUI.Controls.DarkSectionPanel();
            this.DgvMods = new DarkUI.Controls.DarkDataGridView();
            this.ColumnModId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkTitle3 = new DarkUI.Controls.DarkTitle();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.TextBoxSearch = new DarkUI.Controls.DarkTextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ComboBoxModType = new DarkUI.Controls.DarkComboBox();
            this.LabelSelectGameType = new System.Windows.Forms.Label();
            this.LabelSelectModType = new System.Windows.Forms.Label();
            this.ComboBoxGameType = new DarkUI.Controls.DarkComboBox();
            this.SectionArchiveInformation = new DarkUI.Controls.DarkSectionPanel();
            this.ScrollBarDetails = new DarkUI.Controls.DarkScrollBar();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.darkTitle9 = new DarkUI.Controls.DarkTitle();
            this.LabelHeaderName = new System.Windows.Forms.Label();
            this.LabelHeaderNameNo = new System.Windows.Forms.Label();
            this.LabelHeaderGameType = new System.Windows.Forms.Label();
            this.LabelGameType = new System.Windows.Forms.Label();
            this.LabelHeaderModType = new System.Windows.Forms.Label();
            this.LabelModType = new System.Windows.Forms.Label();
            this.LabelHeaderVersion = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelHeaderAuthor = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelHeaderSubmittedBy = new System.Windows.Forms.Label();
            this.LabelSubmittedBy = new System.Windows.Forms.Label();
            this.darkTitle8 = new DarkUI.Controls.DarkTitle();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemInstallMod = new System.Windows.Forms.ToolStripButton();
            this.ToolItemUninstallMod = new System.Windows.Forms.ToolStripButton();
            this.ToolItemDownloadMod = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3CCAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3TMAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectXBOX = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemXBOXConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemXBOXDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemConnectOfflineMode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsCustomInjector = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsAlwaysDownloadInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRequestGscMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClearGscMods = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStatusStrip = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelConnectedConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.TimerNotifyOff = new System.Windows.Forms.Timer(this.components);
            this.SectionModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).BeginInit();
            this.panel1.SuspendLayout();
            this.SectionArchiveInformation.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.ToolStripArchiveInformation.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.MenuStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionModsLibrary
            // 
            this.SectionModsLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionModsLibrary.Controls.Add(this.DgvMods);
            this.SectionModsLibrary.Controls.Add(this.panel1);
            this.SectionModsLibrary.Location = new System.Drawing.Point(14, 40);
            this.SectionModsLibrary.Margin = new System.Windows.Forms.Padding(5);
            this.SectionModsLibrary.Name = "SectionModsLibrary";
            this.SectionModsLibrary.SectionHeader = "MODS LIBRARY";
            this.SectionModsLibrary.Size = new System.Drawing.Size(708, 526);
            this.SectionModsLibrary.TabIndex = 11;
            // 
            // DgvMods
            // 
            this.DgvMods.AllowUserToAddRows = false;
            this.DgvMods.AllowUserToDeleteRows = false;
            this.DgvMods.AllowUserToDragDropRows = false;
            this.DgvMods.AllowUserToPasteCells = false;
            this.DgvMods.AllowUserToResizeColumns = false;
            this.DgvMods.ColumnHeadersHeight = 29;
            this.DgvMods.ColumnHeadersVisible = false;
            this.DgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModId,
            this.ColumnModName,
            this.ColumnGameType,
            this.ColumnModType,
            this.ColumnModVersion,
            this.ColumnModAuthor,
            this.ColumnInstall,
            this.ColumnDownload});
            this.DgvMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMods.Location = new System.Drawing.Point(1, 113);
            this.DgvMods.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgvMods.MultiSelect = false;
            this.DgvMods.Name = "DgvMods";
            this.DgvMods.ReadOnly = true;
            this.DgvMods.RowHeadersWidth = 41;
            this.DgvMods.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMods.RowTemplate.Height = 24;
            this.DgvMods.RowTemplate.ReadOnly = true;
            this.DgvMods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvMods.Size = new System.Drawing.Size(706, 412);
            this.DgvMods.TabIndex = 13;
            this.DgvMods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMods_CellClick);
            this.DgvMods.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvMods.SelectionChanged += new System.EventHandler(this.DgvMods_SelectionChanged);
            // 
            // ColumnModId
            // 
            this.ColumnModId.HeaderText = "Id";
            this.ColumnModId.MinimumWidth = 6;
            this.ColumnModId.Name = "ColumnModId";
            this.ColumnModId.ReadOnly = true;
            this.ColumnModId.Visible = false;
            this.ColumnModId.Width = 125;
            // 
            // ColumnModName
            // 
            this.ColumnModName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModName.HeaderText = "Name";
            this.ColumnModName.MinimumWidth = 6;
            this.ColumnModName.Name = "ColumnModName";
            this.ColumnModName.ReadOnly = true;
            // 
            // ColumnGameType
            // 
            this.ColumnGameType.HeaderText = "Game Type";
            this.ColumnGameType.MinimumWidth = 6;
            this.ColumnGameType.Name = "ColumnGameType";
            this.ColumnGameType.ReadOnly = true;
            this.ColumnGameType.Width = 80;
            // 
            // ColumnModType
            // 
            this.ColumnModType.HeaderText = "Mod Type";
            this.ColumnModType.MinimumWidth = 6;
            this.ColumnModType.Name = "ColumnModType";
            this.ColumnModType.ReadOnly = true;
            this.ColumnModType.Width = 80;
            // 
            // ColumnModVersion
            // 
            this.ColumnModVersion.HeaderText = "Version";
            this.ColumnModVersion.MinimumWidth = 6;
            this.ColumnModVersion.Name = "ColumnModVersion";
            this.ColumnModVersion.ReadOnly = true;
            this.ColumnModVersion.Width = 50;
            // 
            // ColumnModAuthor
            // 
            this.ColumnModAuthor.HeaderText = "Author";
            this.ColumnModAuthor.MinimumWidth = 6;
            this.ColumnModAuthor.Name = "ColumnModAuthor";
            this.ColumnModAuthor.ReadOnly = true;
            this.ColumnModAuthor.Width = 145;
            // 
            // ColumnInstall
            // 
            this.ColumnInstall.HeaderText = "Install";
            this.ColumnInstall.MinimumWidth = 6;
            this.ColumnInstall.Name = "ColumnInstall";
            this.ColumnInstall.ReadOnly = true;
            this.ColumnInstall.Width = 28;
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "Download";
            this.ColumnDownload.MinimumWidth = 6;
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.darkTitle3);
            this.panel1.Controls.Add(this.darkTitle1);
            this.panel1.Controls.Add(this.TextBoxSearch);
            this.panel1.Controls.Add(this.LabelSearch);
            this.panel1.Controls.Add(this.ComboBoxModType);
            this.panel1.Controls.Add(this.LabelSelectGameType);
            this.panel1.Controls.Add(this.LabelSelectModType);
            this.panel1.Controls.Add(this.ComboBoxGameType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 88);
            this.panel1.TabIndex = 12;
            // 
            // darkTitle3
            // 
            this.darkTitle3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTitle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.darkTitle3.Location = new System.Drawing.Point(8, 62);
            this.darkTitle3.Name = "darkTitle3";
            this.darkTitle3.Size = new System.Drawing.Size(688, 20);
            this.darkTitle3.TabIndex = 1161;
            this.darkTitle3.Text = "MODS";
            // 
            // darkTitle1
            // 
            this.darkTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTitle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.darkTitle1.Location = new System.Drawing.Point(8, 8);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(688, 20);
            this.darkTitle1.TabIndex = 1159;
            this.darkTitle1.Text = "FILTER MODS";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(62, 32);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(278, 27);
            this.TextBoxSearch.TabIndex = 1158;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(5, 35);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(64, 20);
            this.LabelSearch.TabIndex = 1157;
            this.LabelSearch.Text = "SEARCH";
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModType.FormattingEnabled = true;
            this.ComboBoxModType.Items.AddRange(new object[] {
            "ANY",
            "Mod Menu",
            "Game Mode"});
            this.ComboBoxModType.Location = new System.Drawing.Point(596, 32);
            this.ComboBoxModType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Size = new System.Drawing.Size(100, 28);
            this.ComboBoxModType.TabIndex = 4;
            this.ComboBoxModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModType_SelectedIndexChanged);
            // 
            // LabelSelectGameType
            // 
            this.LabelSelectGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectGameType.AutoSize = true;
            this.LabelSelectGameType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectGameType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectGameType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectGameType.Location = new System.Drawing.Point(349, 35);
            this.LabelSelectGameType.Margin = new System.Windows.Forms.Padding(6, 5, 3, 2);
            this.LabelSelectGameType.Name = "LabelSelectGameType";
            this.LabelSelectGameType.Size = new System.Drawing.Size(86, 20);
            this.LabelSelectGameType.TabIndex = 1156;
            this.LabelSelectGameType.Text = "GAME TYPE";
            // 
            // LabelSelectModType
            // 
            this.LabelSelectModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectModType.AutoSize = true;
            this.LabelSelectModType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectModType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectModType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectModType.Location = new System.Drawing.Point(526, 35);
            this.LabelSelectModType.Margin = new System.Windows.Forms.Padding(6, 5, 3, 2);
            this.LabelSelectModType.Name = "LabelSelectModType";
            this.LabelSelectModType.Size = new System.Drawing.Size(80, 20);
            this.LabelSelectModType.TabIndex = 1122;
            this.LabelSelectModType.Text = "MOD TYPE";
            // 
            // ComboBoxGameType
            // 
            this.ComboBoxGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameType.FormattingEnabled = true;
            this.ComboBoxGameType.Items.AddRange(new object[] {
            "Multiplayer",
            "Zombies"});
            this.ComboBoxGameType.Location = new System.Drawing.Point(424, 32);
            this.ComboBoxGameType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ComboBoxGameType.Name = "ComboBoxGameType";
            this.ComboBoxGameType.Size = new System.Drawing.Size(93, 28);
            this.ComboBoxGameType.TabIndex = 3;
            this.ComboBoxGameType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameType_SelectedIndexChanged);
            // 
            // SectionArchiveInformation
            // 
            this.SectionArchiveInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionArchiveInformation.Controls.Add(this.ScrollBarDetails);
            this.SectionArchiveInformation.Controls.Add(this.FlowPanelDetails);
            this.SectionArchiveInformation.Controls.Add(this.ToolStripArchiveInformation);
            this.SectionArchiveInformation.Location = new System.Drawing.Point(732, 40);
            this.SectionArchiveInformation.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.SectionArchiveInformation.Name = "SectionArchiveInformation";
            this.SectionArchiveInformation.SectionHeader = "MOD INFORMATION";
            this.SectionArchiveInformation.Size = new System.Drawing.Size(350, 526);
            this.SectionArchiveInformation.TabIndex = 12;
            // 
            // ScrollBarDetails
            // 
            this.ScrollBarDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarDetails.Location = new System.Drawing.Point(329, 25);
            this.ScrollBarDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.ScrollBarDetails.Name = "ScrollBarDetails";
            this.ScrollBarDetails.Size = new System.Drawing.Size(20, 463);
            this.ScrollBarDetails.TabIndex = 1133;
            this.ScrollBarDetails.Text = "darkScrollBar1";
            this.ScrollBarDetails.ViewSize = 1;
            this.ScrollBarDetails.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarDetails_ValueChanged);
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.darkTitle9);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderName);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderNameNo);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderGameType);
            this.FlowPanelDetails.Controls.Add(this.LabelGameType);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderModType);
            this.FlowPanelDetails.Controls.Add(this.LabelModType);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.LabelSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.darkTitle8);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(2, 5, 20, 5);
            this.FlowPanelDetails.Size = new System.Drawing.Size(348, 463);
            this.FlowPanelDetails.TabIndex = 15;
            // 
            // darkTitle9
            // 
            this.darkTitle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.darkTitle9.Location = new System.Drawing.Point(8, 7);
            this.darkTitle9.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.darkTitle9.Name = "darkTitle9";
            this.darkTitle9.Size = new System.Drawing.Size(314, 18);
            this.darkTitle9.TabIndex = 1163;
            this.darkTitle9.Text = "DETAILS";
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.AutoSize = true;
            this.LabelHeaderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(5, 30);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(55, 20);
            this.LabelHeaderName.TabIndex = 26;
            this.LabelHeaderName.Text = "Name:";
            // 
            // LabelHeaderNameNo
            // 
            this.LabelHeaderNameNo.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderNameNo, true);
            this.LabelHeaderNameNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelHeaderNameNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderNameNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderNameNo.Location = new System.Drawing.Point(62, 30);
            this.LabelHeaderNameNo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelHeaderNameNo.Name = "LabelHeaderNameNo";
            this.LabelHeaderNameNo.Size = new System.Drawing.Size(18, 20);
            this.LabelHeaderNameNo.TabIndex = 2;
            this.LabelHeaderNameNo.Text = "...";
            // 
            // LabelHeaderGameType
            // 
            this.LabelHeaderGameType.AutoSize = true;
            this.LabelHeaderGameType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGameType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameType.Location = new System.Drawing.Point(5, 56);
            this.LabelHeaderGameType.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderGameType.Name = "LabelHeaderGameType";
            this.LabelHeaderGameType.Size = new System.Drawing.Size(91, 20);
            this.LabelHeaderGameType.TabIndex = 24;
            this.LabelHeaderGameType.Text = "Game Type:";
            // 
            // LabelGameType
            // 
            this.LabelGameType.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelGameType, true);
            this.LabelGameType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameType.Location = new System.Drawing.Point(98, 56);
            this.LabelGameType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelGameType.Name = "LabelGameType";
            this.LabelGameType.Size = new System.Drawing.Size(18, 20);
            this.LabelGameType.TabIndex = 23;
            this.LabelGameType.Text = "...";
            // 
            // LabelHeaderModType
            // 
            this.LabelHeaderModType.AutoSize = true;
            this.LabelHeaderModType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderModType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModType.Location = new System.Drawing.Point(5, 82);
            this.LabelHeaderModType.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderModType.Name = "LabelHeaderModType";
            this.LabelHeaderModType.Size = new System.Drawing.Size(82, 20);
            this.LabelHeaderModType.TabIndex = 16;
            this.LabelHeaderModType.Text = "Mod Type:";
            // 
            // LabelModType
            // 
            this.LabelModType.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModType, true);
            this.LabelModType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelModType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModType.Location = new System.Drawing.Point(89, 82);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(18, 20);
            this.LabelModType.TabIndex = 17;
            this.LabelModType.Text = "...";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.AutoSize = true;
            this.LabelHeaderVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(5, 108);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(65, 20);
            this.LabelHeaderVersion.TabIndex = 3;
            this.LabelHeaderVersion.Text = "Version:";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelVersion, true);
            this.LabelVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(72, 108);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(18, 20);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderAuthor
            // 
            this.LabelHeaderAuthor.AutoSize = true;
            this.LabelHeaderAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderAuthor.Location = new System.Drawing.Point(5, 134);
            this.LabelHeaderAuthor.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderAuthor.Name = "LabelHeaderAuthor";
            this.LabelHeaderAuthor.Size = new System.Drawing.Size(89, 20);
            this.LabelHeaderAuthor.TabIndex = 6;
            this.LabelHeaderAuthor.Text = "Created By:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelAuthor, true);
            this.LabelAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAuthor.Location = new System.Drawing.Point(96, 134);
            this.LabelAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(18, 20);
            this.LabelAuthor.TabIndex = 15;
            this.LabelAuthor.Text = "...";
            // 
            // LabelHeaderSubmittedBy
            // 
            this.LabelHeaderSubmittedBy.AutoSize = true;
            this.LabelHeaderSubmittedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderSubmittedBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(5, 160);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.LabelHeaderSubmittedBy.Name = "LabelHeaderSubmittedBy";
            this.LabelHeaderSubmittedBy.Size = new System.Drawing.Size(108, 20);
            this.LabelHeaderSubmittedBy.TabIndex = 13;
            this.LabelHeaderSubmittedBy.Text = "Submitted By:";
            // 
            // LabelSubmittedBy
            // 
            this.LabelSubmittedBy.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelSubmittedBy, true);
            this.LabelSubmittedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSubmittedBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSubmittedBy.Location = new System.Drawing.Point(115, 160);
            this.LabelSubmittedBy.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(18, 20);
            this.LabelSubmittedBy.TabIndex = 14;
            this.LabelSubmittedBy.Text = "...";
            // 
            // darkTitle8
            // 
            this.darkTitle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.darkTitle8.Location = new System.Drawing.Point(8, 186);
            this.darkTitle8.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.darkTitle8.Name = "darkTitle8";
            this.darkTitle8.Size = new System.Drawing.Size(314, 18);
            this.darkTitle8.TabIndex = 1162;
            this.darkTitle8.Text = "DESCRIPTION";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(5, 209);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 2, 2, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(478, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.LabelDescription.Size = new System.Drawing.Size(18, 35);
            this.LabelDescription.TabIndex = 12;
            this.LabelDescription.Text = "...";
            // 
            // ToolStripArchiveInformation
            // 
            this.ToolStripArchiveInformation.AutoSize = false;
            this.ToolStripArchiveInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripArchiveInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripArchiveInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripArchiveInformation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripArchiveInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripArchiveInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemInstallMod,
            this.ToolItemUninstallMod,
            this.ToolItemDownloadMod});
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 488);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(348, 37);
            this.ToolStripArchiveInformation.TabIndex = 16;
            this.ToolStripArchiveInformation.TabStop = true;
            this.ToolStripArchiveInformation.Text = "darkToolStrip2";
            // 
            // ToolItemInstallMod
            // 
            this.ToolItemInstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemInstallMod.Enabled = false;
            this.ToolItemInstallMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemInstallMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemInstallMod.Image = global::AtomicX.Properties.Resources.icons8_software_installer_22;
            this.ToolItemInstallMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemInstallMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemInstallMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemInstallMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemInstallMod.Name = "ToolItemInstallMod";
            this.ToolItemInstallMod.Size = new System.Drawing.Size(78, 27);
            this.ToolItemInstallMod.Text = "Install";
            this.ToolItemInstallMod.Click += new System.EventHandler(this.ToolItemInstallMod_Click);
            // 
            // ToolItemUninstallMod
            // 
            this.ToolItemUninstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemUninstallMod.Enabled = false;
            this.ToolItemUninstallMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemUninstallMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemUninstallMod.Image = global::AtomicX.Properties.Resources.icons8_uninstall_programs_22;
            this.ToolItemUninstallMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemUninstallMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemUninstallMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemUninstallMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemUninstallMod.Name = "ToolItemUninstallMod";
            this.ToolItemUninstallMod.Size = new System.Drawing.Size(97, 27);
            this.ToolItemUninstallMod.Text = "Uninstall";
            this.ToolItemUninstallMod.Click += new System.EventHandler(this.ToolItemUninstallMod_Click);
            // 
            // ToolItemDownloadMod
            // 
            this.ToolItemDownloadMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDownloadMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDownloadMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDownloadMod.Image = global::AtomicX.Properties.Resources.icons8_download_from_the_cloud_22;
            this.ToolItemDownloadMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemDownloadMod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemDownloadMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemDownloadMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemDownloadMod.Name = "ToolItemDownloadMod";
            this.ToolItemDownloadMod.Size = new System.Drawing.Size(106, 27);
            this.ToolItemDownloadMod.Text = "Download";
            this.ToolItemDownloadMod.Click += new System.EventHandler(this.ToolItemDownloadMod_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuItemTools,
            this.MenuItemSettings,
            this.MenuItemHelp,
            this.MenuItemRequestGscMods,
            this.MenuItemClearGscMods});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.MenuStrip.Size = new System.Drawing.Size(1094, 34);
            this.MenuStrip.TabIndex = 1141;
            this.MenuStrip.Text = "darkMenuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemConnectPS3,
            this.MenuItemConnectXBOX,
            this.MenuItemFileSeparator0,
            this.MenuItemConnectOfflineMode});
            this.MenuStripFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(90, 24);
            this.MenuStripFile.Text = "CONNECT";
            // 
            // MenuItemConnectPS3
            // 
            this.MenuItemConnectPS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemConnectPS3CCAPI,
            this.MenuItemConnectPS3TMAPI,
            this.MenuItemConnectPS3Disconnect});
            this.MenuItemConnectPS3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3.Name = "MenuItemConnectPS3";
            this.MenuItemConnectPS3.Size = new System.Drawing.Size(180, 26);
            this.MenuItemConnectPS3.Text = "PS3";
            // 
            // MenuItemConnectPS3CCAPI
            // 
            this.MenuItemConnectPS3CCAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3CCAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3CCAPI.Name = "MenuItemConnectPS3CCAPI";
            this.MenuItemConnectPS3CCAPI.Size = new System.Drawing.Size(241, 26);
            this.MenuItemConnectPS3CCAPI.Text = "Connect using CCAPI...";
            this.MenuItemConnectPS3CCAPI.Click += new System.EventHandler(this.MenuStripConnectPS3CCAPI_Click);
            // 
            // MenuItemConnectPS3TMAPI
            // 
            this.MenuItemConnectPS3TMAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3TMAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3TMAPI.Name = "MenuItemConnectPS3TMAPI";
            this.MenuItemConnectPS3TMAPI.Size = new System.Drawing.Size(241, 26);
            this.MenuItemConnectPS3TMAPI.Text = "Connect using TMAPI...";
            this.MenuItemConnectPS3TMAPI.Click += new System.EventHandler(this.MenuStripConnectPS3TMAPI_Click);
            // 
            // MenuItemConnectPS3Disconnect
            // 
            this.MenuItemConnectPS3Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3Disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3Disconnect.Name = "MenuItemConnectPS3Disconnect";
            this.MenuItemConnectPS3Disconnect.Size = new System.Drawing.Size(241, 26);
            this.MenuItemConnectPS3Disconnect.Text = "Disconnect...";
            this.MenuItemConnectPS3Disconnect.Visible = false;
            this.MenuItemConnectPS3Disconnect.Click += new System.EventHandler(this.MenuItemPS3Disconnect_Click);
            // 
            // MenuItemConnectXBOX
            // 
            this.MenuItemConnectXBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectXBOX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemXBOXConnect,
            this.MenuItemXBOXDisconnect});
            this.MenuItemConnectXBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectXBOX.Name = "MenuItemConnectXBOX";
            this.MenuItemConnectXBOX.Size = new System.Drawing.Size(180, 26);
            this.MenuItemConnectXBOX.Text = "XBOX";
            // 
            // MenuItemXBOXConnect
            // 
            this.MenuItemXBOXConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemXBOXConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemXBOXConnect.Name = "MenuItemXBOXConnect";
            this.MenuItemXBOXConnect.Size = new System.Drawing.Size(279, 26);
            this.MenuItemXBOXConnect.Text = "Connect to default console...";
            this.MenuItemXBOXConnect.Click += new System.EventHandler(this.MenuItemXBOXConnect_Click);
            // 
            // MenuItemXBOXDisconnect
            // 
            this.MenuItemXBOXDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemXBOXDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemXBOXDisconnect.Name = "MenuItemXBOXDisconnect";
            this.MenuItemXBOXDisconnect.Size = new System.Drawing.Size(279, 26);
            this.MenuItemXBOXDisconnect.Text = "Disconnect...";
            this.MenuItemXBOXDisconnect.Visible = false;
            this.MenuItemXBOXDisconnect.Click += new System.EventHandler(this.MenuItemXBOXDisconnect_Click);
            // 
            // MenuItemFileSeparator0
            // 
            this.MenuItemFileSeparator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemFileSeparator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemFileSeparator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemFileSeparator0.Name = "MenuItemFileSeparator0";
            this.MenuItemFileSeparator0.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemConnectOfflineMode
            // 
            this.MenuItemConnectOfflineMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectOfflineMode.CheckOnClick = true;
            this.MenuItemConnectOfflineMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectOfflineMode.Name = "MenuItemConnectOfflineMode";
            this.MenuItemConnectOfflineMode.Size = new System.Drawing.Size(180, 26);
            this.MenuItemConnectOfflineMode.Text = "Offline Mode";
            // 
            // MenuItemTools
            // 
            this.MenuItemTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemToolsCustomInjector});
            this.MenuItemTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemTools.Name = "MenuItemTools";
            this.MenuItemTools.Size = new System.Drawing.Size(67, 24);
            this.MenuItemTools.Text = "TOOLS";
            // 
            // MenuItemToolsCustomInjector
            // 
            this.MenuItemToolsCustomInjector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsCustomInjector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsCustomInjector.Name = "MenuItemToolsCustomInjector";
            this.MenuItemToolsCustomInjector.Size = new System.Drawing.Size(223, 26);
            this.MenuItemToolsCustomInjector.Text = "Custom File Injector";
            this.MenuItemToolsCustomInjector.Click += new System.EventHandler(this.MenuItemToolsCustomInjector_Click);
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettingsAlwaysDownloadInstallFiles});
            this.MenuItemSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettings.Name = "MenuItemSettings";
            this.MenuItemSettings.Size = new System.Drawing.Size(88, 24);
            this.MenuItemSettings.Text = "SETTINGS";
            // 
            // MenuItemSettingsAlwaysDownloadInstallFiles
            // 
            this.MenuItemSettingsAlwaysDownloadInstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsAlwaysDownloadInstallFiles.CheckOnClick = true;
            this.MenuItemSettingsAlwaysDownloadInstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Name = "MenuItemSettingsAlwaysDownloadInstallFiles";
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Size = new System.Drawing.Size(287, 26);
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Text = "Always Download Install Files";
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReportIssue,
            this.MenuItemSourceCode,
            this.MenuItemCheckForUpdates,
            this.MenuItemSeperator3,
            this.MenuItemAbout});
            this.MenuItemHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(57, 24);
            this.MenuItemHelp.Text = "HELP";
            // 
            // MenuItemReportIssue
            // 
            this.MenuItemReportIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemReportIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemReportIssue.Name = "MenuItemReportIssue";
            this.MenuItemReportIssue.Size = new System.Drawing.Size(265, 26);
            this.MenuItemReportIssue.Text = "Report Issues/Suggestions";
            this.MenuItemReportIssue.Click += new System.EventHandler(this.MenuItemReportIssue_Click);
            // 
            // MenuItemSourceCode
            // 
            this.MenuItemSourceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSourceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSourceCode.Name = "MenuItemSourceCode";
            this.MenuItemSourceCode.Size = new System.Drawing.Size(265, 26);
            this.MenuItemSourceCode.Text = "Source Code (GitHub)";
            this.MenuItemSourceCode.Click += new System.EventHandler(this.MenuItemSourceCode_Click);
            // 
            // MenuItemCheckForUpdates
            // 
            this.MenuItemCheckForUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemCheckForUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemCheckForUpdates.Name = "MenuItemCheckForUpdates";
            this.MenuItemCheckForUpdates.Size = new System.Drawing.Size(265, 26);
            this.MenuItemCheckForUpdates.Text = "Check for Update";
            this.MenuItemCheckForUpdates.Click += new System.EventHandler(this.MenuItemCheckForUpdates_Click);
            // 
            // MenuItemSeperator3
            // 
            this.MenuItemSeperator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator3.Name = "MenuItemSeperator3";
            this.MenuItemSeperator3.Size = new System.Drawing.Size(262, 6);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(265, 26);
            this.MenuItemAbout.Text = "About AtomicX";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MenuItemRequestGscMods
            // 
            this.MenuItemRequestGscMods.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemRequestGscMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemRequestGscMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemRequestGscMods.Name = "MenuItemRequestGscMods";
            this.MenuItemRequestGscMods.Size = new System.Drawing.Size(132, 24);
            this.MenuItemRequestGscMods.Text = "REQUEST MODS";
            this.MenuItemRequestGscMods.Click += new System.EventHandler(this.MenuStripRequestGscMods_Click);
            // 
            // MenuItemClearGscMods
            // 
            this.MenuItemClearGscMods.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemClearGscMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemClearGscMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemClearGscMods.Name = "MenuItemClearGscMods";
            this.MenuItemClearGscMods.Size = new System.Drawing.Size(144, 24);
            this.MenuItemClearGscMods.Text = "CLEAR GSC MODS";
            this.MenuItemClearGscMods.Click += new System.EventHandler(this.MenuItemClearGscMods_Click);
            // 
            // MenuStatusStrip
            // 
            this.MenuStatusStrip.AllowMerge = false;
            this.MenuStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStatusStrip.CanOverflow = false;
            this.MenuStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuStatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelConnectedConsole,
            this.ToolStripLabelConsole,
            this.toolStripSeparator3,
            this.ToolStripLabelStatus,
            this.ToolStripLabelStats});
            this.MenuStatusStrip.Location = new System.Drawing.Point(0, 572);
            this.MenuStatusStrip.Name = "MenuStatusStrip";
            this.MenuStatusStrip.Padding = new System.Windows.Forms.Padding(11, 0, 8, 5);
            this.MenuStatusStrip.Size = new System.Drawing.Size(1094, 31);
            this.MenuStatusStrip.Stretch = true;
            this.MenuStatusStrip.TabIndex = 1147;
            this.MenuStatusStrip.Text = "darkToolStrip1";
            // 
            // ToolStripLabelConnectedConsole
            // 
            this.ToolStripLabelConnectedConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConnectedConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConnectedConsole.Name = "ToolStripLabelConnectedConsole";
            this.ToolStripLabelConnectedConsole.Size = new System.Drawing.Size(148, 23);
            this.ToolStripLabelConnectedConsole.Text = "Console Connected  :";
            // 
            // ToolStripLabelConsole
            // 
            this.ToolStripLabelConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConsole.Name = "ToolStripLabelConsole";
            this.ToolStripLabelConsole.Size = new System.Drawing.Size(34, 23);
            this.ToolStripLabelConsole.Text = "Idle";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(106, 23);
            this.ToolStripLabelStatus.Text = "Loading data...";
            this.ToolStripLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripLabelStats
            // 
            this.ToolStripLabelStats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLabelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStats.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.ToolStripLabelStats.Name = "ToolStripLabelStats";
            this.ToolStripLabelStats.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ToolStripLabelStats.Size = new System.Drawing.Size(68, 23);
            this.ToolStripLabelStats.Text = "## Mods";
            // 
            // TimerNotifyOff
            // 
            this.TimerNotifyOff.Interval = 3500;
            this.TimerNotifyOff.Tick += new System.EventHandler(this.TimerNotifyOff_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 603);
            this.Controls.Add(this.MenuStatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.SectionArchiveInformation);
            this.Controls.Add(this.SectionModsLibrary);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtomicX - Beta v2.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SectionModsLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SectionArchiveInformation.ResumeLayout(false);
            this.SectionArchiveInformation.PerformLayout();
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            this.ToolStripArchiveInformation.ResumeLayout(false);
            this.ToolStripArchiveInformation.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MenuStatusStrip.ResumeLayout(false);
            this.MenuStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkSectionPanel SectionModsLibrary;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkTitle darkTitle3;
        private DarkUI.Controls.DarkTitle darkTitle1;
        private DarkUI.Controls.DarkTextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private DarkUI.Controls.DarkComboBox ComboBoxModType;
        private System.Windows.Forms.Label LabelSelectGameType;
        private System.Windows.Forms.Label LabelSelectModType;
        private DarkUI.Controls.DarkComboBox ComboBoxGameType;
        private DarkUI.Controls.DarkSectionPanel SectionArchiveInformation;
        private DarkUI.Controls.DarkScrollBar ScrollBarDetails;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private DarkUI.Controls.DarkTitle darkTitle9;
        private System.Windows.Forms.Label LabelHeaderName;
        private System.Windows.Forms.Label LabelHeaderNameNo;
        private System.Windows.Forms.Label LabelHeaderGameType;
        private System.Windows.Forms.Label LabelGameType;
        private System.Windows.Forms.Label LabelHeaderModType;
        private System.Windows.Forms.Label LabelModType;
        private System.Windows.Forms.Label LabelHeaderVersion;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelHeaderAuthor;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelHeaderSubmittedBy;
        private System.Windows.Forms.Label LabelSubmittedBy;
        private DarkUI.Controls.DarkTitle darkTitle8;
        private System.Windows.Forms.Label LabelDescription;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private System.Windows.Forms.ToolStripButton ToolItemInstallMod;
        private System.Windows.Forms.ToolStripButton ToolItemUninstallMod;
        private System.Windows.Forms.ToolStripButton ToolItemDownloadMod;
        private DarkUI.Controls.DarkMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3CCAPI;
        private System.Windows.Forms.ToolStripSeparator MenuItemFileSeparator0;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectOfflineMode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsAlwaysDownloadInstallFiles;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportIssue;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSourceCode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRequestGscMods;
        private DarkUI.Controls.DarkDataGridView DgvMods;
        private DarkUI.Controls.DarkToolStrip MenuStatusStrip;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnectedConsole;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStats;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3TMAPI;
        private System.Windows.Forms.Timer TimerNotifyOff;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3Disconnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsCustomInjector;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClearGscMods;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModAuthor;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInstall;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownload;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectXBOX;
        private System.Windows.Forms.ToolStripMenuItem MenuItemXBOXConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemXBOXDisconnect;
    }
}