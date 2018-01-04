using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomic_tool
{
    public partial class frmDialog : Form
    {
        public frmDialog()
        {
            InitializeComponent();
        }

        private void btnOk_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
