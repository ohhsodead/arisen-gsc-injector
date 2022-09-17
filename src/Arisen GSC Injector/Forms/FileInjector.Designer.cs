namespace Arisen_GSC_Injector.Forms
{
    partial class FileInjector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileInjector));
            this.TimerNotifyOff = new System.Windows.Forms.Timer(this.components);
            this.RadioGroupGameMode = new DevExpress.XtraEditors.RadioGroup();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.ToolStripStatus = new DevExpress.XtraBars.Bar();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ButtonInjectFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonBrowseLocalFile = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxInstallPath = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxLocalFile = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupGameMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstallPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerNotifyOff
            // 
            this.TimerNotifyOff.Interval = 3500;
            // 
            // RadioGroupGameMode
            // 
            this.RadioGroupGameMode.Location = new System.Drawing.Point(8, 4);
            this.RadioGroupGameMode.Name = "RadioGroupGameMode";
            this.RadioGroupGameMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupGameMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupGameMode.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupGameMode.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupGameMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupGameMode.Properties.Columns = 2;
            this.RadioGroupGameMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Multiplayer"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Zombies")});
            this.RadioGroupGameMode.Size = new System.Drawing.Size(182, 28);
            this.RadioGroupGameMode.TabIndex = 4;
            this.RadioGroupGameMode.SelectedIndexChanged += new System.EventHandler(this.RadioGroupGameMode_SelectedIndexChanged);
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.ToolStripStatus});
            this.BarManager.DockControls.Add(this.barDockControl1);
            this.BarManager.DockControls.Add(this.barDockControl2);
            this.BarManager.DockControls.Add(this.barDockControl3);
            this.BarManager.DockControls.Add(this.barDockControl4);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.LabelStatus});
            this.BarManager.MaxItemId = 2;
            this.BarManager.StatusBar = this.ToolStripStatus;
            // 
            // ToolStripStatus
            // 
            this.ToolStripStatus.BarName = "Status bar";
            this.ToolStripStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.ToolStripStatus.DockCol = 0;
            this.ToolStripStatus.DockRow = 0;
            this.ToolStripStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.ToolStripStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.ToolStripStatus.OptionsBar.AllowQuickCustomization = false;
            this.ToolStripStatus.OptionsBar.DrawDragBorder = false;
            this.ToolStripStatus.OptionsBar.UseWholeRow = true;
            this.ToolStripStatus.Text = "Status bar";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Waiting...";
            this.LabelStatus.Id = 1;
            this.LabelStatus.LeftIndent = 2;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.BarManager;
            this.barDockControl1.Size = new System.Drawing.Size(488, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 198);
            this.barDockControl2.Manager = this.BarManager;
            this.barDockControl2.Size = new System.Drawing.Size(488, 21);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.BarManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 198);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(488, 0);
            this.barDockControl4.Manager = this.BarManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 198);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ButtonInjectFile);
            this.groupControl1.Controls.Add(this.ButtonBrowseLocalFile);
            this.groupControl1.Controls.Add(this.ComboBoxInstallPath);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TextBoxLocalFile);
            this.groupControl1.Location = new System.Drawing.Point(12, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(464, 148);
            this.groupControl1.TabIndex = 1158;
            this.groupControl1.Text = "GSC File Injector";
            // 
            // ButtonInjectFile
            // 
            this.ButtonInjectFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonInjectFile.Appearance.Options.UseFont = true;
            this.ButtonInjectFile.Enabled = false;
            this.ButtonInjectFile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonInjectFile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonInjectFile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonInjectFile.Location = new System.Drawing.Point(12, 112);
            this.ButtonInjectFile.Name = "ButtonInjectFile";
            this.ButtonInjectFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInjectFile.Size = new System.Drawing.Size(97, 23);
            this.ButtonInjectFile.TabIndex = 3;
            this.ButtonInjectFile.Text = "Inject File";
            this.ButtonInjectFile.Click += new System.EventHandler(this.ButtonInjectFile_Click);
            // 
            // ButtonBrowseLocalFile
            // 
            this.ButtonBrowseLocalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseLocalFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonBrowseLocalFile.Appearance.Options.UseFont = true;
            this.ButtonBrowseLocalFile.Location = new System.Drawing.Point(406, 33);
            this.ButtonBrowseLocalFile.Name = "ButtonBrowseLocalFile";
            this.ButtonBrowseLocalFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonBrowseLocalFile.Size = new System.Drawing.Size(46, 22);
            this.ButtonBrowseLocalFile.TabIndex = 1;
            this.ButtonBrowseLocalFile.Text = "...";
            this.ButtonBrowseLocalFile.Click += new System.EventHandler(this.ButtonBrowseLocalFile_Click);
            // 
            // ComboBoxInstallPath
            // 
            this.ComboBoxInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxInstallPath.Location = new System.Drawing.Point(12, 82);
            this.ComboBoxInstallPath.Name = "ComboBoxInstallPath";
            this.ComboBoxInstallPath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxInstallPath.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxInstallPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInstallPath.Size = new System.Drawing.Size(440, 22);
            this.ComboBoxInstallPath.TabIndex = 2;
            this.ComboBoxInstallPath.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstallPath_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 15);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Injection Path:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Local File:";
            // 
            // TextBoxLocalFile
            // 
            this.TextBoxLocalFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalFile.Location = new System.Drawing.Point(12, 33);
            this.TextBoxLocalFile.Name = "TextBoxLocalFile";
            this.TextBoxLocalFile.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxLocalFile.Properties.Appearance.Options.UseFont = true;
            this.TextBoxLocalFile.Size = new System.Drawing.Size(388, 22);
            this.TextBoxLocalFile.TabIndex = 0;
            this.TextBoxLocalFile.TextChanged += new System.EventHandler(this.TextBoxLocalFile_TextChanged);
            // 
            // FileInjector
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 219);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.RadioGroupGameMode);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FileInjector.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "FileInjector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSC File Injector";
            this.Load += new System.EventHandler(this.FileInjector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupGameMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstallPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalFile.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerNotifyOff;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonInjectFile;
        private DevExpress.XtraEditors.SimpleButton ButtonBrowseLocalFile;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxInstallPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TextBoxLocalFile;
        private DevExpress.XtraEditors.RadioGroup RadioGroupGameMode;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar ToolStripStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
    }
}