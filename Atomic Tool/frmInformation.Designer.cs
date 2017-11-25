namespace AtomicToolGSC
{
    partial class frmInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformation));
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.LinkLabel();
            this.btnOk = new CButtonLib.CButton();
            this.imgInformation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(58, 12);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(285, 60);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "This application was developed by nv.\r\nAll credits goes to the appropriate creato" +
    "rs of the gsc\r\nmods used in this application.\r\nIf you have any questions, please" +
    "";
            // 
            // lblEmail
            // 
            this.lblEmail.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblEmail.Location = new System.Drawing.Point(235, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.TabStop = true;
            this.lblEmail.Text = "email us.";
            this.lblEmail.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BorderColor = System.Drawing.Color.Black;
            cBlendItems1.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))))};
            cBlendItems1.iPoint = new float[] {
        0F,
        1F};
            this.btnOk.ColorFillBlend = cBlendItems1;
            this.btnOk.DesignerSelected = false;
            this.btnOk.DimFactorClick = -10;
            this.btnOk.DimFactorHover = 20;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ImageIndex = 0;
            this.btnOk.Location = new System.Drawing.Point(277, 91);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.ShowFocus = CButtonLib.CButton.eFocus.Dim;
            this.btnOk.Size = new System.Drawing.Size(79, 26);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.TextMargin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.btnOk.TextShadowShow = false;
            this.btnOk.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnOk_ClickButtonArea);
            // 
            // imgInformation
            // 
            this.imgInformation.Image = global::AtomicToolGSC.Properties.Resources.Info_Icon;
            this.imgInformation.Location = new System.Drawing.Point(12, 12);
            this.imgInformation.Name = "imgInformation";
            this.imgInformation.Size = new System.Drawing.Size(40, 40);
            this.imgInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInformation.TabIndex = 11;
            this.imgInformation.TabStop = false;
            // 
            // frmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(367, 128);
            this.Controls.Add(this.imgInformation);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInformation";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.LinkLabel lblEmail;
        private CButtonLib.CButton btnOk;
        private System.Windows.Forms.PictureBox imgInformation;
    }
}