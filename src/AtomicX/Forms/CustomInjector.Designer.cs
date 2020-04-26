namespace AtomicX.Forms
{
    partial class CustomInjector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomInjector));
            this.MenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStatusStrip = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.TimerNotifyOff = new System.Windows.Forms.Timer(this.components);
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.ToolStripLocalFiles = new DarkUI.Controls.DarkToolStrip();
            this.ToolStripItemInjectGscFile = new System.Windows.Forms.ToolStripButton();
            this.ButtonLocalFile = new DarkUI.Controls.DarkButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.TextBoxLocalFile = new DarkUI.Controls.DarkTextBox();
            this.LabelFilename = new DarkUI.Controls.DarkLabel();
            this.ComboBoxInstallPath = new DarkUI.Controls.DarkComboBox();
            this.RadioButtonMP = new DarkUI.Controls.DarkRadioButton();
            this.RadioButtonZM = new DarkUI.Controls.DarkRadioButton();
            this.MenuStrip.SuspendLayout();
            this.MenuStatusStrip.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.ToolStripLocalFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettings});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.MenuStrip.Size = new System.Drawing.Size(487, 29);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "darkMenuStrip1";
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuItemSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuItemSettings.Name = "MenuItemSettings";
            this.MenuItemSettings.ShortcutKeyDisplayString = "";
            this.MenuItemSettings.Size = new System.Drawing.Size(69, 19);
            this.MenuItemSettings.Text = "SETTINGS";
            // 
            // MenuStatusStrip
            // 
            this.MenuStatusStrip.AutoSize = false;
            this.MenuStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MenuStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuStatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelStatus});
            this.MenuStatusStrip.Location = new System.Drawing.Point(0, 211);
            this.MenuStatusStrip.Name = "MenuStatusStrip";
            this.MenuStatusStrip.Padding = new System.Windows.Forms.Padding(11, 0, 8, 5);
            this.MenuStatusStrip.Size = new System.Drawing.Size(487, 32);
            this.MenuStatusStrip.TabIndex = 1147;
            this.MenuStatusStrip.Text = "darkToolStrip1";
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(85, 24);
            this.ToolStripLabelStatus.Text = "Loading data...";
            // 
            // TimerNotifyOff
            // 
            this.TimerNotifyOff.Interval = 3500;
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkSectionPanel1.Controls.Add(this.ToolStripLocalFiles);
            this.darkSectionPanel1.Controls.Add(this.ButtonLocalFile);
            this.darkSectionPanel1.Controls.Add(this.darkLabel1);
            this.darkSectionPanel1.Controls.Add(this.TextBoxLocalFile);
            this.darkSectionPanel1.Controls.Add(this.LabelFilename);
            this.darkSectionPanel1.Controls.Add(this.ComboBoxInstallPath);
            this.darkSectionPanel1.Location = new System.Drawing.Point(14, 40);
            this.darkSectionPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Custom GSC File";
            this.darkSectionPanel1.Size = new System.Drawing.Size(459, 166);
            this.darkSectionPanel1.TabIndex = 1148;
            // 
            // ToolStripLocalFiles
            // 
            this.ToolStripLocalFiles.AutoSize = false;
            this.ToolStripLocalFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLocalFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripLocalFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLocalFiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripLocalFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripLocalFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemInjectGscFile});
            this.ToolStripLocalFiles.Location = new System.Drawing.Point(1, 129);
            this.ToolStripLocalFiles.Name = "ToolStripLocalFiles";
            this.ToolStripLocalFiles.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripLocalFiles.Size = new System.Drawing.Size(457, 36);
            this.ToolStripLocalFiles.TabIndex = 3;
            this.ToolStripLocalFiles.TabStop = true;
            this.ToolStripLocalFiles.Text = "darkToolStrip3";
            // 
            // ToolStripItemInjectGscFile
            // 
            this.ToolStripItemInjectGscFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripItemInjectGscFile.Enabled = false;
            this.ToolStripItemInjectGscFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripItemInjectGscFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripItemInjectGscFile.Image = global::AtomicX.Properties.Resources.icons8_software_installer_22;
            this.ToolStripItemInjectGscFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripItemInjectGscFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripItemInjectGscFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripItemInjectGscFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolStripItemInjectGscFile.Name = "ToolStripItemInjectGscFile";
            this.ToolStripItemInjectGscFile.Size = new System.Drawing.Size(113, 26);
            this.ToolStripItemInjectGscFile.Text = "Inject GSC File";
            this.ToolStripItemInjectGscFile.Click += new System.EventHandler(this.ToolStripItemInjectGscFile_Click);
            // 
            // ButtonLocalFile
            // 
            this.ButtonLocalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalFile.Location = new System.Drawing.Point(407, 52);
            this.ButtonLocalFile.Name = "ButtonLocalFile";
            this.ButtonLocalFile.Size = new System.Drawing.Size(43, 23);
            this.ButtonLocalFile.TabIndex = 1;
            this.ButtonLocalFile.Text = "...";
            this.ButtonLocalFile.Click += new System.EventHandler(this.ButtonLocalFile_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(6, 30);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(59, 15);
            this.darkLabel1.TabIndex = 5;
            this.darkLabel1.Text = "Local File:";
            // 
            // TextBoxLocalFile
            // 
            this.TextBoxLocalFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalFile.Location = new System.Drawing.Point(8, 52);
            this.TextBoxLocalFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxLocalFile.Name = "TextBoxLocalFile";
            this.TextBoxLocalFile.Size = new System.Drawing.Size(393, 23);
            this.TextBoxLocalFile.TabIndex = 0;
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilename.Location = new System.Drawing.Point(6, 82);
            this.LabelFilename.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(91, 15);
            this.LabelFilename.TabIndex = 14;
            this.LabelFilename.Text = "Inject GSC Path:";
            // 
            // ComboBoxInstallPath
            // 
            this.ComboBoxInstallPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxInstallPath.FormattingEnabled = true;
            this.ComboBoxInstallPath.Location = new System.Drawing.Point(8, 104);
            this.ComboBoxInstallPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ComboBoxInstallPath.Name = "ComboBoxInstallPath";
            this.ComboBoxInstallPath.Size = new System.Drawing.Size(442, 24);
            this.ComboBoxInstallPath.TabIndex = 2;
            // 
            // RadioButtonMP
            // 
            this.RadioButtonMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonMP.AutoSize = true;
            this.RadioButtonMP.Location = new System.Drawing.Point(321, 11);
            this.RadioButtonMP.Name = "RadioButtonMP";
            this.RadioButtonMP.Size = new System.Drawing.Size(85, 19);
            this.RadioButtonMP.TabIndex = 6;
            this.RadioButtonMP.Text = "Multiplayer";
            this.RadioButtonMP.CheckedChanged += new System.EventHandler(this.RadioButtonMP_CheckedChanged);
            // 
            // RadioButtonZM
            // 
            this.RadioButtonZM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonZM.AutoSize = true;
            this.RadioButtonZM.Location = new System.Drawing.Point(409, 11);
            this.RadioButtonZM.Name = "RadioButtonZM";
            this.RadioButtonZM.Size = new System.Drawing.Size(71, 19);
            this.RadioButtonZM.TabIndex = 7;
            this.RadioButtonZM.Text = "Zombies";
            this.RadioButtonZM.CheckedChanged += new System.EventHandler(this.RadioButtonZM_CheckedChanged);
            // 
            // CustomInjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 243);
            this.Controls.Add(this.RadioButtonZM);
            this.Controls.Add(this.RadioButtonMP);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.MenuStatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "CustomInjector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom File Injector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MenuStatusStrip.ResumeLayout(false);
            this.MenuStatusStrip.PerformLayout();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.ToolStripLocalFiles.ResumeLayout(false);
            this.ToolStripLocalFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private DarkUI.Controls.DarkToolStrip MenuStatusStrip;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.Timer TimerNotifyOff;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox TextBoxLocalFile;
        private DarkUI.Controls.DarkLabel LabelFilename;
        private DarkUI.Controls.DarkToolStrip ToolStripLocalFiles;
        private System.Windows.Forms.ToolStripButton ToolStripItemInjectGscFile;
        private DarkUI.Controls.DarkButton ButtonLocalFile;
        private DarkUI.Controls.DarkRadioButton RadioButtonZM;
        private DarkUI.Controls.DarkRadioButton RadioButtonMP;
        private DarkUI.Controls.DarkComboBox ComboBoxInstallPath;
    }
}