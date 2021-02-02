namespace AtomicX.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SectionModsLibrary = new DevExpress.XtraEditors.GroupControl();
            this.DgvMods = new DarkUI.Controls.DarkDataGridView();
            this.PanelFilterMods = new System.Windows.Forms.Panel();
            this.LabelTitleMods = new DevExpress.XtraEditors.LabelControl();
            this.LabelTitleFilterMods = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxSearch = new DevExpress.XtraEditors.TextEdit();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelSelectGameType = new DevExpress.XtraEditors.LabelControl();
            this.LabelSelectModType = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxGameType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SectionArchiveInformation = new DevExpress.XtraEditors.GroupControl();
            this.ScrollBarDetails = new DevExpress.XtraEditors.VScrollBar();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleDetails = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderName = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderNameNo = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderGameType = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameType = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderModType = new DevExpress.XtraEditors.LabelControl();
            this.LabelModType = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderAuthor = new DevExpress.XtraEditors.LabelControl();
            this.LabelAuthor = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelSubmittedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelTitleDescription = new DevExpress.XtraEditors.LabelControl();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.ToolStripModActions = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemInstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemUninstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemDownload = new System.Windows.Forms.ToolStripButton();
            this.TimerNotifyOff = new System.Windows.Forms.Timer(this.components);
            this.ToolStripFooter = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelHeaderConnected = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelHeaderStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.cONNECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3CCAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3TMAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectPS3Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectXBOX = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemXBOXConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemXBOXDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.offlineModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToolsFileInjector = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettingsAlwaysDownloadInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDiscordServer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClearGscMods = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnModId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDownload = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SectionModsLibrary)).BeginInit();
            this.SectionModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).BeginInit();
            this.PanelFilterMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionArchiveInformation)).BeginInit();
            this.SectionArchiveInformation.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.ToolStripModActions.SuspendLayout();
            this.ToolStripFooter.SuspendLayout();
            this.darkMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionModsLibrary
            // 
            this.SectionModsLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionModsLibrary.Controls.Add(this.DgvMods);
            this.SectionModsLibrary.Controls.Add(this.PanelFilterMods);
            this.SectionModsLibrary.Location = new System.Drawing.Point(12, 42);
            this.SectionModsLibrary.Name = "SectionModsLibrary";
            this.SectionModsLibrary.Size = new System.Drawing.Size(797, 512);
            this.SectionModsLibrary.TabIndex = 11;
            this.SectionModsLibrary.Text = "MODS LIBRARY";
            // 
            // DgvMods
            // 
            this.DgvMods.AllowUserToAddRows = false;
            this.DgvMods.AllowUserToDeleteRows = false;
            this.DgvMods.AllowUserToDragDropRows = false;
            this.DgvMods.AllowUserToPasteCells = false;
            this.DgvMods.AllowUserToResizeColumns = false;
            this.DgvMods.ColumnHeadersHeight = 21;
            this.DgvMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            this.DgvMods.Location = new System.Drawing.Point(2, 111);
            this.DgvMods.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgvMods.MultiSelect = false;
            this.DgvMods.Name = "DgvMods";
            this.DgvMods.ReadOnly = true;
            this.DgvMods.RowHeadersWidth = 41;
            this.DgvMods.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMods.RowTemplate.Height = 24;
            this.DgvMods.RowTemplate.ReadOnly = true;
            this.DgvMods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvMods.Size = new System.Drawing.Size(793, 399);
            this.DgvMods.TabIndex = 13;
            this.DgvMods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMods_CellClick);
            this.DgvMods.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.DgvMods.SelectionChanged += new System.EventHandler(this.DgvMods_SelectionChanged);
            // 
            // PanelFilterMods
            // 
            this.PanelFilterMods.Controls.Add(this.LabelTitleMods);
            this.PanelFilterMods.Controls.Add(this.LabelTitleFilterMods);
            this.PanelFilterMods.Controls.Add(this.TextBoxSearch);
            this.PanelFilterMods.Controls.Add(this.LabelSearch);
            this.PanelFilterMods.Controls.Add(this.ComboBoxModType);
            this.PanelFilterMods.Controls.Add(this.LabelSelectGameType);
            this.PanelFilterMods.Controls.Add(this.LabelSelectModType);
            this.PanelFilterMods.Controls.Add(this.ComboBoxGameType);
            this.PanelFilterMods.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFilterMods.Location = new System.Drawing.Point(2, 23);
            this.PanelFilterMods.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PanelFilterMods.Name = "PanelFilterMods";
            this.PanelFilterMods.Size = new System.Drawing.Size(793, 88);
            this.PanelFilterMods.TabIndex = 12;
            // 
            // LabelTitleMods
            // 
            this.LabelTitleMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleMods.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleMods.Appearance.Options.UseFont = true;
            this.LabelTitleMods.Location = new System.Drawing.Point(8, 62);
            this.LabelTitleMods.Name = "LabelTitleMods";
            this.LabelTitleMods.Size = new System.Drawing.Size(36, 15);
            this.LabelTitleMods.TabIndex = 1161;
            this.LabelTitleMods.Text = "MODS";
            // 
            // LabelTitleFilterMods
            // 
            this.LabelTitleFilterMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleFilterMods.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleFilterMods.Appearance.Options.UseFont = true;
            this.LabelTitleFilterMods.Location = new System.Drawing.Point(8, 8);
            this.LabelTitleFilterMods.Name = "LabelTitleFilterMods";
            this.LabelTitleFilterMods.Size = new System.Drawing.Size(76, 15);
            this.LabelTitleFilterMods.TabIndex = 1159;
            this.LabelTitleFilterMods.Text = "FILTER MODS";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(58, 32);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSearch.Size = new System.Drawing.Size(383, 22);
            this.TextBoxSearch.TabIndex = 1158;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(8, 35);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(44, 15);
            this.LabelSearch.TabIndex = 1157;
            this.LabelSearch.Text = "SEARCH";
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModType.EditValue = "ANY";
            this.ComboBoxModType.Location = new System.Drawing.Point(683, 32);
            this.ComboBoxModType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Properties.AllowFocused = false;
            this.ComboBoxModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxModType.Properties.Items.AddRange(new object[] {
            "ANY",
            "Mod Menu",
            "Game Mode"});
            this.ComboBoxModType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxModType.Size = new System.Drawing.Size(100, 22);
            this.ComboBoxModType.TabIndex = 4;
            this.ComboBoxModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModType_SelectedIndexChanged);
            // 
            // LabelSelectGameType
            // 
            this.LabelSelectGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectGameType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectGameType.Appearance.Options.UseFont = true;
            this.LabelSelectGameType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectGameType.Location = new System.Drawing.Point(450, 35);
            this.LabelSelectGameType.Margin = new System.Windows.Forms.Padding(6, 5, 3, 2);
            this.LabelSelectGameType.Name = "LabelSelectGameType";
            this.LabelSelectGameType.Size = new System.Drawing.Size(62, 15);
            this.LabelSelectGameType.TabIndex = 1156;
            this.LabelSelectGameType.Text = "GAME TYPE";
            // 
            // LabelSelectModType
            // 
            this.LabelSelectModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectModType.Appearance.Options.UseFont = true;
            this.LabelSelectModType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectModType.Location = new System.Drawing.Point(620, 35);
            this.LabelSelectModType.Margin = new System.Windows.Forms.Padding(6, 5, 3, 2);
            this.LabelSelectModType.Name = "LabelSelectModType";
            this.LabelSelectModType.Size = new System.Drawing.Size(57, 15);
            this.LabelSelectModType.TabIndex = 1122;
            this.LabelSelectModType.Text = "MOD TYPE";
            // 
            // ComboBoxGameType
            // 
            this.ComboBoxGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameType.EditValue = "ANY";
            this.ComboBoxGameType.Location = new System.Drawing.Point(518, 32);
            this.ComboBoxGameType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ComboBoxGameType.Name = "ComboBoxGameType";
            this.ComboBoxGameType.Properties.AllowFocused = false;
            this.ComboBoxGameType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameType.Properties.Items.AddRange(new object[] {
            "ANY",
            "Multiplayer",
            "Zombies"});
            this.ComboBoxGameType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameType.Size = new System.Drawing.Size(93, 22);
            this.ComboBoxGameType.TabIndex = 3;
            this.ComboBoxGameType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameType_SelectedIndexChanged);
            // 
            // SectionArchiveInformation
            // 
            this.SectionArchiveInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionArchiveInformation.Controls.Add(this.ScrollBarDetails);
            this.SectionArchiveInformation.Controls.Add(this.FlowPanelDetails);
            this.SectionArchiveInformation.Controls.Add(this.ToolStripModActions);
            this.SectionArchiveInformation.Location = new System.Drawing.Point(819, 42);
            this.SectionArchiveInformation.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.SectionArchiveInformation.Name = "SectionArchiveInformation";
            this.SectionArchiveInformation.Size = new System.Drawing.Size(350, 512);
            this.SectionArchiveInformation.TabIndex = 12;
            this.SectionArchiveInformation.Text = "MOD INFORMATION";
            // 
            // ScrollBarDetails
            // 
            this.ScrollBarDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarDetails.Location = new System.Drawing.Point(329, 25);
            this.ScrollBarDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.ScrollBarDetails.Name = "ScrollBarDetails";
            this.ScrollBarDetails.Size = new System.Drawing.Size(20, 449);
            this.ScrollBarDetails.TabIndex = 1133;
            this.ScrollBarDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarDetails_Scroll);
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.LabelTitleDetails);
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
            this.FlowPanelDetails.Controls.Add(this.LabelTitleDescription);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(2, 23);
            this.FlowPanelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(2, 5, 20, 5);
            this.FlowPanelDetails.Size = new System.Drawing.Size(346, 450);
            this.FlowPanelDetails.TabIndex = 15;
            // 
            // LabelTitleDetails
            // 
            this.LabelTitleDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleDetails.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelTitleDetails, true);
            this.LabelTitleDetails.Location = new System.Drawing.Point(8, 7);
            this.LabelTitleDetails.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.LabelTitleDetails.Name = "LabelTitleDetails";
            this.LabelTitleDetails.Size = new System.Drawing.Size(47, 15);
            this.LabelTitleDetails.TabIndex = 1163;
            this.LabelTitleDetails.Text = "DETAILS";
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.Appearance.Options.UseFont = true;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(8, 29);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(6, 3, 2, 3);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(36, 15);
            this.LabelHeaderName.TabIndex = 26;
            this.LabelHeaderName.Text = "Name:";
            // 
            // LabelHeaderNameNo
            // 
            this.LabelHeaderNameNo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelHeaderNameNo.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelHeaderNameNo, true);
            this.LabelHeaderNameNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderNameNo.Location = new System.Drawing.Point(49, 29);
            this.LabelHeaderNameNo.Name = "LabelHeaderNameNo";
            this.LabelHeaderNameNo.Size = new System.Drawing.Size(9, 15);
            this.LabelHeaderNameNo.TabIndex = 2;
            this.LabelHeaderNameNo.Text = "...";
            // 
            // LabelHeaderGameType
            // 
            this.LabelHeaderGameType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderGameType.Appearance.Options.UseFont = true;
            this.LabelHeaderGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameType.Location = new System.Drawing.Point(8, 50);
            this.LabelHeaderGameType.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.LabelHeaderGameType.Name = "LabelHeaderGameType";
            this.LabelHeaderGameType.Size = new System.Drawing.Size(66, 15);
            this.LabelHeaderGameType.TabIndex = 24;
            this.LabelHeaderGameType.Text = "Game Type:";
            // 
            // LabelGameType
            // 
            this.LabelGameType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameType.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelGameType, true);
            this.LabelGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameType.Location = new System.Drawing.Point(80, 50);
            this.LabelGameType.Name = "LabelGameType";
            this.LabelGameType.Size = new System.Drawing.Size(9, 15);
            this.LabelGameType.TabIndex = 23;
            this.LabelGameType.Text = "...";
            // 
            // LabelHeaderModType
            // 
            this.LabelHeaderModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderModType.Appearance.Options.UseFont = true;
            this.LabelHeaderModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModType.Location = new System.Drawing.Point(8, 71);
            this.LabelHeaderModType.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.LabelHeaderModType.Name = "LabelHeaderModType";
            this.LabelHeaderModType.Size = new System.Drawing.Size(58, 15);
            this.LabelHeaderModType.TabIndex = 16;
            this.LabelHeaderModType.Text = "Mod Type:";
            // 
            // LabelModType
            // 
            this.LabelModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelModType.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelModType, true);
            this.LabelModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelModType.Location = new System.Drawing.Point(72, 71);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(9, 15);
            this.LabelModType.TabIndex = 17;
            this.LabelModType.Text = "...";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.Appearance.Options.UseFont = true;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(8, 92);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(45, 15);
            this.LabelHeaderVersion.TabIndex = 3;
            this.LabelHeaderVersion.Text = "Version:";
            // 
            // LabelVersion
            // 
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelVersion, true);
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(59, 92);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(9, 15);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderAuthor
            // 
            this.LabelHeaderAuthor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderAuthor.Appearance.Options.UseFont = true;
            this.LabelHeaderAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderAuthor.Location = new System.Drawing.Point(8, 113);
            this.LabelHeaderAuthor.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.LabelHeaderAuthor.Name = "LabelHeaderAuthor";
            this.LabelHeaderAuthor.Size = new System.Drawing.Size(64, 15);
            this.LabelHeaderAuthor.TabIndex = 6;
            this.LabelHeaderAuthor.Text = "Created By:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAuthor.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelAuthor, true);
            this.LabelAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAuthor.Location = new System.Drawing.Point(78, 113);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(9, 15);
            this.LabelAuthor.TabIndex = 15;
            this.LabelAuthor.Text = "...";
            // 
            // LabelHeaderSubmittedBy
            // 
            this.LabelHeaderSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderSubmittedBy.Appearance.Options.UseFont = true;
            this.LabelHeaderSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(8, 134);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.LabelHeaderSubmittedBy.Name = "LabelHeaderSubmittedBy";
            this.LabelHeaderSubmittedBy.Size = new System.Drawing.Size(79, 15);
            this.LabelHeaderSubmittedBy.TabIndex = 13;
            this.LabelHeaderSubmittedBy.Text = "Submitted By:";
            // 
            // LabelSubmittedBy
            // 
            this.LabelSubmittedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSubmittedBy.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelSubmittedBy, true);
            this.LabelSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSubmittedBy.Location = new System.Drawing.Point(93, 134);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(9, 15);
            this.LabelSubmittedBy.TabIndex = 14;
            this.LabelSubmittedBy.Text = "...";
            // 
            // LabelTitleDescription
            // 
            this.LabelTitleDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleDescription.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelTitleDescription, true);
            this.LabelTitleDescription.Location = new System.Drawing.Point(8, 155);
            this.LabelTitleDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 0);
            this.LabelTitleDescription.Name = "LabelTitleDescription";
            this.LabelTitleDescription.Size = new System.Drawing.Size(77, 15);
            this.LabelTitleDescription.TabIndex = 1162;
            this.LabelTitleDescription.Text = "DESCRIPTION";
            // 
            // LabelDescription
            // 
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(8, 176);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(6, 3, 2, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(330, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(9, 15);
            this.LabelDescription.TabIndex = 12;
            this.LabelDescription.Text = "...";
            // 
            // ToolStripModActions
            // 
            this.ToolStripModActions.AutoSize = false;
            this.ToolStripModActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripModActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripModActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripModActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripModActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripModActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemInstall,
            this.ToolItemUninstall,
            this.ToolItemDownload});
            this.ToolStripModActions.Location = new System.Drawing.Point(2, 473);
            this.ToolStripModActions.Name = "ToolStripModActions";
            this.ToolStripModActions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripModActions.Size = new System.Drawing.Size(346, 37);
            this.ToolStripModActions.TabIndex = 16;
            this.ToolStripModActions.TabStop = true;
            this.ToolStripModActions.Text = "darkToolStrip2";
            // 
            // ToolItemInstall
            // 
            this.ToolItemInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemInstall.Enabled = false;
            this.ToolItemInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemInstall.Image = global::AtomicX.Properties.Resources.install;
            this.ToolItemInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemInstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemInstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemInstall.Name = "ToolItemInstall";
            this.ToolItemInstall.Size = new System.Drawing.Size(66, 27);
            this.ToolItemInstall.Text = "Install";
            // 
            // ToolItemUninstall
            // 
            this.ToolItemUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemUninstall.Enabled = false;
            this.ToolItemUninstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemUninstall.Image = global::AtomicX.Properties.Resources.uninstall;
            this.ToolItemUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemUninstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemUninstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemUninstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemUninstall.Name = "ToolItemUninstall";
            this.ToolItemUninstall.Size = new System.Drawing.Size(81, 27);
            this.ToolItemUninstall.Text = "Uninstall";
            // 
            // ToolItemDownload
            // 
            this.ToolItemDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemDownload.Image = global::AtomicX.Properties.Resources.download_from_the_cloud;
            this.ToolItemDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemDownload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemDownload.Name = "ToolItemDownload";
            this.ToolItemDownload.Size = new System.Drawing.Size(89, 27);
            this.ToolItemDownload.Text = "Download";
            // 
            // TimerNotifyOff
            // 
            this.TimerNotifyOff.Interval = 3500;
            this.TimerNotifyOff.Tick += new System.EventHandler(this.TimerNotifyOff_Tick);
            // 
            // ToolStripFooter
            // 
            this.ToolStripFooter.AutoSize = false;
            this.ToolStripFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripFooter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelHeaderConnected,
            this.ToolStripLabelStats,
            this.ToolStripLabelConsole,
            this.toolStripSeparator1,
            this.ToolStripLabelHeaderStatus,
            this.ToolStripLabelStatus});
            this.ToolStripFooter.Location = new System.Drawing.Point(0, 566);
            this.ToolStripFooter.Name = "ToolStripFooter";
            this.ToolStripFooter.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.ToolStripFooter.Size = new System.Drawing.Size(1181, 28);
            this.ToolStripFooter.Stretch = true;
            this.ToolStripFooter.TabIndex = 13;
            this.ToolStripFooter.Text = "darkToolStrip1";
            // 
            // ToolStripLabelHeaderConnected
            // 
            this.ToolStripLabelHeaderConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelHeaderConnected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripLabelHeaderConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelHeaderConnected.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripLabelHeaderConnected.Name = "ToolStripLabelHeaderConnected";
            this.ToolStripLabelHeaderConnected.Size = new System.Drawing.Size(119, 18);
            this.ToolStripLabelHeaderConnected.Text = "Connected Console :";
            // 
            // ToolStripLabelStats
            // 
            this.ToolStripLabelStats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLabelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStats.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripLabelStats.Name = "ToolStripLabelStats";
            this.ToolStripLabelStats.Size = new System.Drawing.Size(32, 18);
            this.ToolStripLabelStats.Text = "Stats";
            // 
            // ToolStripLabelConsole
            // 
            this.ToolStripLabelConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConsole.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripLabelConsole.Name = "ToolStripLabelConsole";
            this.ToolStripLabelConsole.Size = new System.Drawing.Size(26, 18);
            this.ToolStripLabelConsole.Text = "Idle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 18);
            // 
            // ToolStripLabelHeaderStatus
            // 
            this.ToolStripLabelHeaderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelHeaderStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripLabelHeaderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelHeaderStatus.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripLabelHeaderStatus.Name = "ToolStripLabelHeaderStatus";
            this.ToolStripLabelHeaderStatus.Size = new System.Drawing.Size(45, 18);
            this.ToolStripLabelHeaderStatus.Text = "Status:";
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(16, 18);
            this.ToolStripLabelStatus.Text = "...";
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONNECTToolStripMenuItem,
            this.MenuItemTools,
            this.sETTINGSToolStripMenuItem,
            this.hELPToolStripMenuItem,
            this.MenuItemClearGscMods});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 8, 5);
            this.darkMenuStrip1.Size = new System.Drawing.Size(1181, 29);
            this.darkMenuStrip1.TabIndex = 1166;
            this.darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // cONNECTToolStripMenuItem
            // 
            this.cONNECTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.cONNECTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemConnectPS3,
            this.MenuItemConnectXBOX,
            this.MenuItemSeperator0,
            this.offlineModeToolStripMenuItem});
            this.cONNECTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cONNECTToolStripMenuItem.Name = "cONNECTToolStripMenuItem";
            this.cONNECTToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.cONNECTToolStripMenuItem.Text = "CONNECT";
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
            this.MenuItemConnectPS3.Size = new System.Drawing.Size(144, 22);
            this.MenuItemConnectPS3.Text = "PS3";
            // 
            // MenuItemConnectPS3CCAPI
            // 
            this.MenuItemConnectPS3CCAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3CCAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3CCAPI.Name = "MenuItemConnectPS3CCAPI";
            this.MenuItemConnectPS3CCAPI.Size = new System.Drawing.Size(198, 22);
            this.MenuItemConnectPS3CCAPI.Text = "Connect using CCAPI...";
            this.MenuItemConnectPS3CCAPI.Click += new System.EventHandler(this.MenuItemConnectPS3CCAPI_Click);
            // 
            // MenuItemConnectPS3TMAPI
            // 
            this.MenuItemConnectPS3TMAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3TMAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3TMAPI.Name = "MenuItemConnectPS3TMAPI";
            this.MenuItemConnectPS3TMAPI.Size = new System.Drawing.Size(198, 22);
            this.MenuItemConnectPS3TMAPI.Text = "Connect using TMAPI...";
            this.MenuItemConnectPS3TMAPI.Click += new System.EventHandler(this.MenuItemConnectPS3TMAPI_Click);
            // 
            // MenuItemConnectPS3Disconnect
            // 
            this.MenuItemConnectPS3Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectPS3Disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectPS3Disconnect.Name = "MenuItemConnectPS3Disconnect";
            this.MenuItemConnectPS3Disconnect.Size = new System.Drawing.Size(198, 22);
            this.MenuItemConnectPS3Disconnect.Text = "Disconnect...";
            this.MenuItemConnectPS3Disconnect.Visible = false;
            this.MenuItemConnectPS3Disconnect.Click += new System.EventHandler(this.MenuItemConnectPS3Disconnect_Click);
            // 
            // MenuItemConnectXBOX
            // 
            this.MenuItemConnectXBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemConnectXBOX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemXBOXConnect,
            this.MenuItemXBOXDisconnect});
            this.MenuItemConnectXBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemConnectXBOX.Name = "MenuItemConnectXBOX";
            this.MenuItemConnectXBOX.Size = new System.Drawing.Size(144, 22);
            this.MenuItemConnectXBOX.Text = "XBOX";
            // 
            // MenuItemXBOXConnect
            // 
            this.MenuItemXBOXConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemXBOXConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemXBOXConnect.Name = "MenuItemXBOXConnect";
            this.MenuItemXBOXConnect.Size = new System.Drawing.Size(226, 22);
            this.MenuItemXBOXConnect.Text = "Connect to default console...";
            this.MenuItemXBOXConnect.Click += new System.EventHandler(this.MenuItemXBOXConnect_Click);
            // 
            // MenuItemXBOXDisconnect
            // 
            this.MenuItemXBOXDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemXBOXDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemXBOXDisconnect.Name = "MenuItemXBOXDisconnect";
            this.MenuItemXBOXDisconnect.Size = new System.Drawing.Size(226, 22);
            this.MenuItemXBOXDisconnect.Text = "Disconnect...";
            this.MenuItemXBOXDisconnect.Visible = false;
            this.MenuItemXBOXDisconnect.Click += new System.EventHandler(this.MenuItemXBOXDisconnect_Click);
            // 
            // MenuItemSeperator0
            // 
            this.MenuItemSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator0.Name = "MenuItemSeperator0";
            this.MenuItemSeperator0.Size = new System.Drawing.Size(141, 6);
            // 
            // offlineModeToolStripMenuItem
            // 
            this.offlineModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.offlineModeToolStripMenuItem.CheckOnClick = true;
            this.offlineModeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.offlineModeToolStripMenuItem.Name = "offlineModeToolStripMenuItem";
            this.offlineModeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.offlineModeToolStripMenuItem.Text = "Offline Mode";
            // 
            // MenuItemTools
            // 
            this.MenuItemTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemToolsFileInjector});
            this.MenuItemTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemTools.Name = "MenuItemTools";
            this.MenuItemTools.Size = new System.Drawing.Size(54, 19);
            this.MenuItemTools.Text = "TOOLS";
            // 
            // MenuItemToolsFileInjector
            // 
            this.MenuItemToolsFileInjector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemToolsFileInjector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemToolsFileInjector.Name = "MenuItemToolsFileInjector";
            this.MenuItemToolsFileInjector.Size = new System.Drawing.Size(160, 22);
            this.MenuItemToolsFileInjector.Text = "GSC File Injector";
            this.MenuItemToolsFileInjector.Click += new System.EventHandler(this.MenuItemToolsFileInjector_Click);
            // 
            // sETTINGSToolStripMenuItem
            // 
            this.sETTINGSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.sETTINGSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettingsAlwaysDownloadInstallFiles});
            this.sETTINGSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sETTINGSToolStripMenuItem.Name = "sETTINGSToolStripMenuItem";
            this.sETTINGSToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.sETTINGSToolStripMenuItem.Text = "SETTINGS";
            // 
            // MenuItemSettingsAlwaysDownloadInstallFiles
            // 
            this.MenuItemSettingsAlwaysDownloadInstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettingsAlwaysDownloadInstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Name = "MenuItemSettingsAlwaysDownloadInstallFiles";
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Size = new System.Drawing.Size(152, 22);
            this.MenuItemSettingsAlwaysDownloadInstallFiles.Text = "Placeholder #1";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReportIssue,
            this.MenuItemDiscordServer,
            this.MenuItemSeperator1,
            this.MenuItemCheckForUpdate,
            this.MenuItemSeperator2,
            this.MenuItemAbout});
            this.hELPToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // MenuItemReportIssue
            // 
            this.MenuItemReportIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemReportIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemReportIssue.Name = "MenuItemReportIssue";
            this.MenuItemReportIssue.Size = new System.Drawing.Size(166, 22);
            this.MenuItemReportIssue.Text = "Report Issue";
            this.MenuItemReportIssue.Click += new System.EventHandler(this.MenuItemReportIssue_Click);
            // 
            // MenuItemDiscordServer
            // 
            this.MenuItemDiscordServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemDiscordServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemDiscordServer.Name = "MenuItemDiscordServer";
            this.MenuItemDiscordServer.Size = new System.Drawing.Size(166, 22);
            this.MenuItemDiscordServer.Text = "Discord Server";
            this.MenuItemDiscordServer.Click += new System.EventHandler(this.MenuItemDiscordServer_Click);
            // 
            // MenuItemSeperator1
            // 
            this.MenuItemSeperator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator1.Name = "MenuItemSeperator1";
            this.MenuItemSeperator1.Size = new System.Drawing.Size(163, 6);
            // 
            // MenuItemCheckForUpdate
            // 
            this.MenuItemCheckForUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemCheckForUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemCheckForUpdate.Name = "MenuItemCheckForUpdate";
            this.MenuItemCheckForUpdate.Size = new System.Drawing.Size(166, 22);
            this.MenuItemCheckForUpdate.Text = "Check for Update";
            this.MenuItemCheckForUpdate.Click += new System.EventHandler(this.MenuItemCheckForUpdate_Click);
            // 
            // MenuItemSeperator2
            // 
            this.MenuItemSeperator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSeperator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSeperator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuItemSeperator2.Name = "MenuItemSeperator2";
            this.MenuItemSeperator2.Size = new System.Drawing.Size(163, 6);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(166, 22);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAboutAtomicX_Click);
            // 
            // MenuItemClearGscMods
            // 
            this.MenuItemClearGscMods.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemClearGscMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemClearGscMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemClearGscMods.Name = "MenuItemClearGscMods";
            this.MenuItemClearGscMods.Size = new System.Drawing.Size(116, 19);
            this.MenuItemClearGscMods.Text = "CLEAR GSC MODS";
            this.MenuItemClearGscMods.Click += new System.EventHandler(this.MenuItemClearGscMods_Click);
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
            this.ColumnInstall.HeaderText = "";
            this.ColumnInstall.MinimumWidth = 6;
            this.ColumnInstall.Name = "ColumnInstall";
            this.ColumnInstall.ReadOnly = true;
            this.ColumnInstall.Width = 28;
            // 
            // ColumnDownload
            // 
            this.ColumnDownload.HeaderText = "";
            this.ColumnDownload.MinimumWidth = 6;
            this.ColumnDownload.Name = "ColumnDownload";
            this.ColumnDownload.ReadOnly = true;
            this.ColumnDownload.Width = 28;
            // 
            // MainWindow
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.ToolStripFooter);
            this.Controls.Add(this.darkMenuStrip1);
            this.Controls.Add(this.SectionArchiveInformation);
            this.Controls.Add(this.SectionModsLibrary);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainWindow.IconOptions.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtomicX - Beta v2.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SectionModsLibrary)).EndInit();
            this.SectionModsLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMods)).EndInit();
            this.PanelFilterMods.ResumeLayout(false);
            this.PanelFilterMods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionArchiveInformation)).EndInit();
            this.SectionArchiveInformation.ResumeLayout(false);
            this.SectionArchiveInformation.PerformLayout();
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            this.ToolStripModActions.ResumeLayout(false);
            this.ToolStripModActions.PerformLayout();
            this.ToolStripFooter.ResumeLayout(false);
            this.ToolStripFooter.PerformLayout();
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl SectionModsLibrary;
        private System.Windows.Forms.Panel PanelFilterMods;
        private DevExpress.XtraEditors.LabelControl LabelTitleMods;
        private DevExpress.XtraEditors.LabelControl LabelTitleFilterMods;
        private DevExpress.XtraEditors.TextEdit TextBoxSearch;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxModType;
        private DevExpress.XtraEditors.LabelControl LabelSelectGameType;
        private DevExpress.XtraEditors.LabelControl LabelSelectModType;
        private DevExpress.XtraEditors.GroupControl SectionArchiveInformation;
        private DevExpress.XtraEditors.VScrollBar ScrollBarDetails;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private DevExpress.XtraEditors.LabelControl LabelTitleDetails;
        private DevExpress.XtraEditors.LabelControl LabelHeaderName;
        private DevExpress.XtraEditors.LabelControl LabelHeaderNameNo;
        private DevExpress.XtraEditors.LabelControl LabelHeaderGameType;
        private DevExpress.XtraEditors.LabelControl LabelGameType;
        private DevExpress.XtraEditors.LabelControl LabelHeaderModType;
        private DevExpress.XtraEditors.LabelControl LabelModType;
        private DevExpress.XtraEditors.LabelControl LabelHeaderVersion;
        private DevExpress.XtraEditors.LabelControl LabelVersion;
        private DevExpress.XtraEditors.LabelControl LabelHeaderAuthor;
        private DevExpress.XtraEditors.LabelControl LabelAuthor;
        private DevExpress.XtraEditors.LabelControl LabelHeaderSubmittedBy;
        private DevExpress.XtraEditors.LabelControl LabelSubmittedBy;
        private DevExpress.XtraEditors.LabelControl LabelTitleDescription;
        private DevExpress.XtraEditors.LabelControl LabelDescription;
        private DarkUI.Controls.DarkToolStrip ToolStripModActions;
        private DarkUI.Controls.DarkDataGridView DgvMods;
        private System.Windows.Forms.Timer TimerNotifyOff;
        private System.Windows.Forms.ToolStripButton ToolItemInstall;
        private System.Windows.Forms.ToolStripButton ToolItemUninstall;
        private System.Windows.Forms.ToolStripButton ToolItemDownload;
        private DarkUI.Controls.DarkToolStrip ToolStripFooter;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStats;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelHeaderStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsole;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONNECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem sETTINGSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClearGscMods;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3CCAPI;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3TMAPI;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectPS3Disconnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectXBOX;
        private System.Windows.Forms.ToolStripMenuItem MenuItemXBOXConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemXBOXDisconnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemToolsFileInjector;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettingsAlwaysDownloadInstallFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator0;
        private System.Windows.Forms.ToolStripMenuItem offlineModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportIssue;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDiscordServer;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCheckForUpdate;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeperator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxGameType;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelHeaderConnected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModAuthor;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInstall;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownload;
    }
}