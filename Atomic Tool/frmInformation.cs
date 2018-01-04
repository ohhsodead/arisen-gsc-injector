using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace atomic_tool
{
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
        }

        private void btnOk_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:bettercodes1@gmail.com");
        }
    }
}
