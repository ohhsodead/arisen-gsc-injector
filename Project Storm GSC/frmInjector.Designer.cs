using ChreneLib;

namespace AtomicToolGSC
{
    partial class frmInjector
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
            CButtonLib.cBlendItems cBlendItems1 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems2 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems3 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems4 = new CButtonLib.cBlendItems();
            CButtonLib.cBlendItems cBlendItems5 = new CButtonLib.cBlendItems();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInjector));
            this.btnConnectAttach = new CButtonLib.CButton();
            this.btnStartMenu = new CButtonLib.CButton();
            this.btnInformation = new CButtonLib.CButton();
            this.useCCAPI = new System.Windows.Forms.RadioButton();
            this.useTMAPI = new System.Windows.Forms.RadioButton();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnSetName = new CButtonLib.CButton();
            this.cmboItemsGscMenus = new System.Windows.Forms.ComboBox();
            this.btnRestoreGsc = new CButtonLib.CButton();
            this.cmboItemsGscMenusPaths = new System.Windows.Forms.ComboBox();
            this.lblTitleModMenu = new System.Windows.Forms.Label();
            this.cmboItemsGscModesPaths = new System.Windows.Forms.ComboBox();
            this.cmboItemsGscModes = new System.Windows.Forms.ComboBox();
            this.lblTitleGameMode = new System.Windows.Forms.Label();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.timerNotificationOff = new System.Windows.Forms.Timer(this.components);
            this.cmboItemsGscPointerMP = new System.Windows.Forms.ComboBox();
            this.cmboItemsGscNameMP = new System.Windows.Forms.ComboBox();
            this.cmboItemsGscPointerZM = new System.Windows.Forms.ComboBox();
            this.cmboItemsGscNameZM = new System.Windows.Forms.ComboBox();
            this.chkZombies = new System.Windows.Forms.CheckBox();
            this.lblTitleModMenuZM = new System.Windows.Forms.Label();
            this.cmboItemsGscMenusZM = new System.Windows.Forms.ComboBox();
            this.cmboItemsGscMenusPathsZM = new System.Windows.Forms.ComboBox();
            this.txtChangeName = new CueTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnectAttach
            // 
            this.btnConnectAttach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectAttach.BorderColor = System.Drawing.Color.Black;
            cBlendItems1.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))))};
            cBlendItems1.iPoint = new float[] {
        0F,
        1F};
            this.btnConnectAttach.ColorFillBlend = cBlendItems1;
            this.btnConnectAttach.DesignerSelected = false;
            this.btnConnectAttach.DimFactorClick = -10;
            this.btnConnectAttach.DimFactorHover = 20;
            this.btnConnectAttach.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnConnectAttach.ImageIndex = 0;
            this.btnConnectAttach.Location = new System.Drawing.Point(9, 146);
            this.btnConnectAttach.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectAttach.Name = "btnConnectAttach";
            this.btnConnectAttach.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.btnConnectAttach.Size = new System.Drawing.Size(314, 37);
            this.btnConnectAttach.TabIndex = 2;
            this.btnConnectAttach.Text = "Connect && Attach to Black Ops II";
            this.btnConnectAttach.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnConnectAttach.TextShadowShow = false;
            this.btnConnectAttach.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnConnect_ClickButtonArea);
            // 
            // btnStartMenu
            // 
            this.btnStartMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartMenu.BorderColor = System.Drawing.Color.Black;
            cBlendItems2.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))))};
            cBlendItems2.iPoint = new float[] {
        0F,
        1F};
            this.btnStartMenu.ColorFillBlend = cBlendItems2;
            this.btnStartMenu.DesignerSelected = false;
            this.btnStartMenu.DimFactorClick = -10;
            this.btnStartMenu.DimFactorHover = 20;
            this.btnStartMenu.Enabled = false;
            this.btnStartMenu.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnStartMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.btnStartMenu.ImageIndex = 0;
            this.btnStartMenu.Location = new System.Drawing.Point(9, 235);
            this.btnStartMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartMenu.Name = "btnStartMenu";
            this.btnStartMenu.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.btnStartMenu.Size = new System.Drawing.Size(314, 37);
            this.btnStartMenu.TabIndex = 7;
            this.btnStartMenu.Text = "Inject Selected GSC Mods";
            this.btnStartMenu.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnStartMenu.TextShadowShow = false;
            this.btnStartMenu.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnStartMenu_ClickButtonArea);
            // 
            // btnInformation
            // 
            this.btnInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInformation.BorderColor = System.Drawing.Color.Black;
            cBlendItems3.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))))};
            cBlendItems3.iPoint = new float[] {
        0F,
        1F};
            this.btnInformation.ColorFillBlend = cBlendItems3;
            this.btnInformation.DesignerSelected = false;
            this.btnInformation.DimFactorClick = -10;
            this.btnInformation.DimFactorHover = 20;
            this.btnInformation.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnInformation.ImageIndex = 0;
            this.btnInformation.Location = new System.Drawing.Point(9, 317);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.btnInformation.Size = new System.Drawing.Size(314, 37);
            this.btnInformation.TabIndex = 9;
            this.btnInformation.Text = "Information";
            this.btnInformation.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnInformation.TextShadowShow = false;
            this.btnInformation.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnInformation_ClickButtonArea);
            // 
            // useCCAPI
            // 
            this.useCCAPI.AutoSize = true;
            this.useCCAPI.Checked = true;
            this.useCCAPI.ForeColor = System.Drawing.Color.White;
            this.useCCAPI.Location = new System.Drawing.Point(9, 123);
            this.useCCAPI.Name = "useCCAPI";
            this.useCCAPI.Size = new System.Drawing.Size(55, 17);
            this.useCCAPI.TabIndex = 0;
            this.useCCAPI.TabStop = true;
            this.useCCAPI.Text = "CCAPI";
            this.useCCAPI.UseVisualStyleBackColor = true;
            this.useCCAPI.CheckedChanged += new System.EventHandler(this.useCCAPI_CheckedChanged);
            // 
            // useTMAPI
            // 
            this.useTMAPI.AutoSize = true;
            this.useTMAPI.ForeColor = System.Drawing.Color.White;
            this.useTMAPI.Location = new System.Drawing.Point(70, 123);
            this.useTMAPI.Name = "useTMAPI";
            this.useTMAPI.Size = new System.Drawing.Size(56, 17);
            this.useTMAPI.TabIndex = 1;
            this.useTMAPI.Text = "TMAPI";
            this.useTMAPI.UseVisualStyleBackColor = true;
            this.useTMAPI.CheckedChanged += new System.EventHandler(this.useTMAPI_CheckedChanged);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.White;
            this.lblDeveloper.Location = new System.Drawing.Point(269, 91);
            this.lblDeveloper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(46, 17);
            this.lblDeveloper.TabIndex = 999;
            this.lblDeveloper.Text = "by NV";
            // 
            // btnSetName
            // 
            this.btnSetName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetName.BorderColor = System.Drawing.Color.Black;
            cBlendItems4.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))))};
            cBlendItems4.iPoint = new float[] {
        0F,
        1F};
            this.btnSetName.ColorFillBlend = cBlendItems4;
            this.btnSetName.DesignerSelected = false;
            this.btnSetName.DimFactorClick = -10;
            this.btnSetName.DimFactorHover = 20;
            this.btnSetName.Enabled = false;
            this.btnSetName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSetName.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSetName.ImageIndex = 0;
            this.btnSetName.Location = new System.Drawing.Point(287, 359);
            this.btnSetName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.btnSetName.Size = new System.Drawing.Size(36, 23);
            this.btnSetName.TabIndex = 11;
            this.btnSetName.Text = "Set";
            this.btnSetName.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnSetName.TextShadowShow = false;
            this.btnSetName.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.cButton1_ClickButtonArea);
            // 
            // cmboItemsGscMenus
            // 
            this.cmboItemsGscMenus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscMenus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItemsGscMenus.Enabled = false;
            this.cmboItemsGscMenus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscMenus.FormattingEnabled = true;
            this.cmboItemsGscMenus.Location = new System.Drawing.Point(9, 206);
            this.cmboItemsGscMenus.Name = "cmboItemsGscMenus";
            this.cmboItemsGscMenus.Size = new System.Drawing.Size(155, 23);
            this.cmboItemsGscMenus.TabIndex = 3;
            this.cmboItemsGscMenus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRestoreGsc
            // 
            this.btnRestoreGsc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRestoreGsc.BorderColor = System.Drawing.Color.Black;
            cBlendItems5.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))))};
            cBlendItems5.iPoint = new float[] {
        0F,
        1F};
            this.btnRestoreGsc.ColorFillBlend = cBlendItems5;
            this.btnRestoreGsc.DesignerSelected = false;
            this.btnRestoreGsc.DimFactorClick = -10;
            this.btnRestoreGsc.DimFactorHover = 20;
            this.btnRestoreGsc.Enabled = false;
            this.btnRestoreGsc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRestoreGsc.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRestoreGsc.ImageIndex = 0;
            this.btnRestoreGsc.Location = new System.Drawing.Point(9, 276);
            this.btnRestoreGsc.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreGsc.Name = "btnRestoreGsc";
            this.btnRestoreGsc.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.btnRestoreGsc.Size = new System.Drawing.Size(314, 37);
            this.btnRestoreGsc.TabIndex = 8;
            this.btnRestoreGsc.Text = "Restore Default GSCs";
            this.btnRestoreGsc.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnRestoreGsc.TextShadowShow = false;
            this.btnRestoreGsc.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.cButton2_ClickButtonArea);
            // 
            // cmboItemsGscMenusPaths
            // 
            this.cmboItemsGscMenusPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscMenusPaths.Enabled = false;
            this.cmboItemsGscMenusPaths.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscMenusPaths.FormattingEnabled = true;
            this.cmboItemsGscMenusPaths.Location = new System.Drawing.Point(9, 206);
            this.cmboItemsGscMenusPaths.Name = "cmboItemsGscMenusPaths";
            this.cmboItemsGscMenusPaths.Size = new System.Drawing.Size(155, 23);
            this.cmboItemsGscMenusPaths.TabIndex = 1006;
            // 
            // lblTitleModMenu
            // 
            this.lblTitleModMenu.AutoSize = true;
            this.lblTitleModMenu.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleModMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleModMenu.Location = new System.Drawing.Point(6, 187);
            this.lblTitleModMenu.Name = "lblTitleModMenu";
            this.lblTitleModMenu.Size = new System.Drawing.Size(95, 15);
            this.lblTitleModMenu.TabIndex = 1007;
            this.lblTitleModMenu.Text = "Mod Menu (MP)";
            // 
            // cmboItemsGscModesPaths
            // 
            this.cmboItemsGscModesPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscModesPaths.Enabled = false;
            this.cmboItemsGscModesPaths.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscModesPaths.FormattingEnabled = true;
            this.cmboItemsGscModesPaths.Location = new System.Drawing.Point(168, 206);
            this.cmboItemsGscModesPaths.Name = "cmboItemsGscModesPaths";
            this.cmboItemsGscModesPaths.Size = new System.Drawing.Size(155, 23);
            this.cmboItemsGscModesPaths.TabIndex = 1009;
            this.cmboItemsGscModesPaths.Visible = false;
            // 
            // cmboItemsGscModes
            // 
            this.cmboItemsGscModes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItemsGscModes.Enabled = false;
            this.cmboItemsGscModes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscModes.FormattingEnabled = true;
            this.cmboItemsGscModes.Location = new System.Drawing.Point(168, 206);
            this.cmboItemsGscModes.Name = "cmboItemsGscModes";
            this.cmboItemsGscModes.Size = new System.Drawing.Size(155, 23);
            this.cmboItemsGscModes.TabIndex = 4;
            this.cmboItemsGscModes.SelectedIndexChanged += new System.EventHandler(this.cmboItemsGscModes_SelectedIndexChanged);
            // 
            // lblTitleGameMode
            // 
            this.lblTitleGameMode.AutoSize = true;
            this.lblTitleGameMode.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleGameMode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleGameMode.Location = new System.Drawing.Point(165, 187);
            this.lblTitleGameMode.Name = "lblTitleGameMode";
            this.lblTitleGameMode.Size = new System.Drawing.Size(101, 15);
            this.lblTitleGameMode.TabIndex = 1010;
            this.lblTitleGameMode.Text = "Game Mode (MP)";
            // 
            // imgBanner
            // 
            this.imgBanner.Image = global::AtomicToolGSC.Properties.Resources.Atomic_Menu;
            this.imgBanner.Location = new System.Drawing.Point(19, 32);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(295, 63);
            this.imgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBanner.TabIndex = 1000;
            this.imgBanner.TabStop = false;
            // 
            // timerNotificationOff
            // 
            this.timerNotificationOff.Interval = 3000;
            this.timerNotificationOff.Tick += new System.EventHandler(this.timerNotificationOff_Tick);
            // 
            // cmboItemsGscPointerMP
            // 
            this.cmboItemsGscPointerMP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscPointerMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItemsGscPointerMP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscPointerMP.FormattingEnabled = true;
            this.cmboItemsGscPointerMP.Location = new System.Drawing.Point(9, 3);
            this.cmboItemsGscPointerMP.Name = "cmboItemsGscPointerMP";
            this.cmboItemsGscPointerMP.Size = new System.Drawing.Size(314, 23);
            this.cmboItemsGscPointerMP.TabIndex = 1012;
            this.cmboItemsGscPointerMP.Visible = false;
            // 
            // cmboItemsGscNameMP
            // 
            this.cmboItemsGscNameMP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscNameMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItemsGscNameMP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscNameMP.FormattingEnabled = true;
            this.cmboItemsGscNameMP.Location = new System.Drawing.Point(9, 3);
            this.cmboItemsGscNameMP.Name = "cmboItemsGscNameMP";
            this.cmboItemsGscNameMP.Size = new System.Drawing.Size(314, 23);
            this.cmboItemsGscNameMP.TabIndex = 1011;
            this.cmboItemsGscNameMP.Visible = false;
            this.cmboItemsGscNameMP.SelectedIndexChanged += new System.EventHandler(this.cmboItemsGscName_SelectedIndexChanged);
            // 
            // cmboItemsGscPointerZM
            // 
            this.cmboItemsGscPointerZM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscPointerZM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItemsGscPointerZM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscPointerZM.FormattingEnabled = true;
            this.cmboItemsGscPointerZM.Location = new System.Drawing.Point(9, 3);
            this.cmboItemsGscPointerZM.Name = "cmboItemsGscPointerZM";
            this.cmboItemsGscPointerZM.Size = new System.Drawing.Size(314, 23);
            this.cmboItemsGscPointerZM.TabIndex = 1014;
            this.cmboItemsGscPointerZM.Visible = false;
            // 
            // cmboItemsGscNameZM
            // 
            this.cmboItemsGscNameZM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscNameZM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItemsGscNameZM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscNameZM.FormattingEnabled = true;
            this.cmboItemsGscNameZM.Location = new System.Drawing.Point(9, 3);
            this.cmboItemsGscNameZM.Name = "cmboItemsGscNameZM";
            this.cmboItemsGscNameZM.Size = new System.Drawing.Size(314, 23);
            this.cmboItemsGscNameZM.TabIndex = 1013;
            this.cmboItemsGscNameZM.Visible = false;
            this.cmboItemsGscNameZM.SelectedIndexChanged += new System.EventHandler(this.cmboItemsGscNameZM_SelectedIndexChanged);
            // 
            // chkZombies
            // 
            this.chkZombies.AutoSize = true;
            this.chkZombies.ForeColor = System.Drawing.Color.White;
            this.chkZombies.Location = new System.Drawing.Point(262, 124);
            this.chkZombies.Name = "chkZombies";
            this.chkZombies.Size = new System.Drawing.Size(69, 17);
            this.chkZombies.TabIndex = 1015;
            this.chkZombies.Text = "Zombies";
            this.chkZombies.UseVisualStyleBackColor = true;
            this.chkZombies.CheckedChanged += new System.EventHandler(this.chkZombies_CheckedChanged);
            // 
            // lblTitleModMenuZM
            // 
            this.lblTitleModMenuZM.AutoSize = true;
            this.lblTitleModMenuZM.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleModMenuZM.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleModMenuZM.Location = new System.Drawing.Point(6, 187);
            this.lblTitleModMenuZM.Name = "lblTitleModMenuZM";
            this.lblTitleModMenuZM.Size = new System.Drawing.Size(95, 15);
            this.lblTitleModMenuZM.TabIndex = 1018;
            this.lblTitleModMenuZM.Text = "Mod Menu (ZM)";
            this.lblTitleModMenuZM.Visible = false;
            // 
            // cmboItemsGscMenusZM
            // 
            this.cmboItemsGscMenusZM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscMenusZM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItemsGscMenusZM.Enabled = false;
            this.cmboItemsGscMenusZM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscMenusZM.FormattingEnabled = true;
            this.cmboItemsGscMenusZM.Location = new System.Drawing.Point(9, 206);
            this.cmboItemsGscMenusZM.Name = "cmboItemsGscMenusZM";
            this.cmboItemsGscMenusZM.Size = new System.Drawing.Size(314, 23);
            this.cmboItemsGscMenusZM.TabIndex = 1016;
            this.cmboItemsGscMenusZM.Visible = false;
            this.cmboItemsGscMenusZM.SelectedIndexChanged += new System.EventHandler(this.cmboItemsGscMenusZM_SelectedIndexChanged);
            // 
            // cmboItemsGscMenusPathsZM
            // 
            this.cmboItemsGscMenusPathsZM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboItemsGscMenusPathsZM.Enabled = false;
            this.cmboItemsGscMenusPathsZM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItemsGscMenusPathsZM.FormattingEnabled = true;
            this.cmboItemsGscMenusPathsZM.Location = new System.Drawing.Point(9, 206);
            this.cmboItemsGscMenusPathsZM.Name = "cmboItemsGscMenusPathsZM";
            this.cmboItemsGscMenusPathsZM.Size = new System.Drawing.Size(314, 23);
            this.cmboItemsGscMenusPathsZM.TabIndex = 1017;
            this.cmboItemsGscMenusPathsZM.Visible = false;
            // 
            // txtChangeName
            // 
            this.txtChangeName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtChangeName.Cue = "Change Name...";
            this.txtChangeName.Enabled = false;
            this.txtChangeName.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtChangeName.Location = new System.Drawing.Point(9, 359);
            this.txtChangeName.MaxLength = 16;
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(272, 23);
            this.txtChangeName.TabIndex = 10;
            // 
            // frmInjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(332, 391);
            this.Controls.Add(this.cmboItemsGscMenusZM);
            this.Controls.Add(this.lblTitleModMenuZM);
            this.Controls.Add(this.chkZombies);
            this.Controls.Add(this.cmboItemsGscPointerZM);
            this.Controls.Add(this.cmboItemsGscNameZM);
            this.Controls.Add(this.cmboItemsGscPointerMP);
            this.Controls.Add(this.cmboItemsGscNameMP);
            this.Controls.Add(this.lblTitleGameMode);
            this.Controls.Add(this.cmboItemsGscModes);
            this.Controls.Add(this.cmboItemsGscModesPaths);
            this.Controls.Add(this.lblTitleModMenu);
            this.Controls.Add(this.txtChangeName);
            this.Controls.Add(this.btnRestoreGsc);
            this.Controls.Add(this.cmboItemsGscMenus);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.imgBanner);
            this.Controls.Add(this.useTMAPI);
            this.Controls.Add(this.useCCAPI);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnStartMenu);
            this.Controls.Add(this.btnConnectAttach);
            this.Controls.Add(this.cmboItemsGscMenusPaths);
            this.Controls.Add(this.cmboItemsGscMenusPathsZM);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInjector";
            this.Opacity = 0.98D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atomic Tool for Black Ops II";
            this.Load += new System.EventHandler(this.InjectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CButtonLib.CButton btnConnectAttach;
        private CButtonLib.CButton btnStartMenu;
        private CButtonLib.CButton btnInformation;
        private System.Windows.Forms.RadioButton useCCAPI;
        private System.Windows.Forms.RadioButton useTMAPI;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.PictureBox imgBanner;
        private CButtonLib.CButton btnSetName;
        private System.Windows.Forms.ComboBox cmboItemsGscMenus;
        private CButtonLib.CButton btnRestoreGsc;
        private System.Windows.Forms.ComboBox cmboItemsGscMenusPaths;
        private CueTextBox txtChangeName;
        private System.Windows.Forms.Label lblTitleModMenu;
        private System.Windows.Forms.ComboBox cmboItemsGscModesPaths;
        private System.Windows.Forms.ComboBox cmboItemsGscModes;
        private System.Windows.Forms.Label lblTitleGameMode;
        private System.Windows.Forms.Timer timerNotificationOff;
        private System.Windows.Forms.ComboBox cmboItemsGscPointerMP;
        private System.Windows.Forms.ComboBox cmboItemsGscNameMP;
        private System.Windows.Forms.ComboBox cmboItemsGscPointerZM;
        private System.Windows.Forms.ComboBox cmboItemsGscNameZM;
        private System.Windows.Forms.CheckBox chkZombies;
        private System.Windows.Forms.Label lblTitleModMenuZM;
        private System.Windows.Forms.ComboBox cmboItemsGscMenusZM;
        private System.Windows.Forms.ComboBox cmboItemsGscMenusPathsZM;
    }
}