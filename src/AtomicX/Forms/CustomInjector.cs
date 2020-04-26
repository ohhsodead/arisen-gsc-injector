using AtomicX.Database;
using AtomicX.Extensions;
using AtomicX.Properties;
using DarkUI.Forms;
using Newtonsoft.Json;
using PS3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtomicX.Forms
{
    public partial class CustomInjector : DarkForm
    {
        public CustomInjector()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RadioButtonMP.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void RadioButtonMP_CheckedChanged(object sender, EventArgs e)
        {
            LoadGscFilePaths("MP");
        }

        private void RadioButtonZM_CheckedChanged(object sender, EventArgs e)
        {
            LoadGscFilePaths("ZM");
        }


        private void ToolStripItemInjectGscFile_Click(object sender, EventArgs e)
        {
            InjectGSCFile();
        }

        /// <summary>
        ///     
        /// </summary>
        private void InjectGSCFile()
        {
            if (MainForm.IsInGame())
            {
                _ = DarkMessageBox.Show(this, "You must be in the pre-game lobby before injecting GSC files.", "Can't Inject Now", MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(TextBoxLocalFile.Text))
            {
                _ = DarkMessageBox.Show(this, "The file you specified doesn't exist on your computer, choose another file.", "File Doesn't Exist", MessageBoxIcon.Exclamation);
                return;
            }

            if (ComboBoxInstallPath.SelectedIndex == -1)
            {
                _ = DarkMessageBox.Show(this, "You haven't specified an inject path for this GSC file.", "No GSC Path", MessageBoxIcon.Exclamation);
                return;
            }

            MainForm.mainForm.ClearGscMods();
            MainForm.mainForm.LastUsedGscFiles.Clear();

            string gameType = RadioButtonMP.Checked ? "MP" : "ZM";
            string localFile = TextBoxLocalFile.Text;
            string installPath = ComboBoxInstallPath.GetItemText(ComboBoxInstallPath.SelectedItem);

            GscData.FileItem gscFileData = MainForm.GetGscFileData(gameType, installPath);

            MainForm.mainForm.LastUsedGscFiles.Add(installPath);

            byte[] gscFile = File.ReadAllBytes(localFile);

            MainForm.PS3.Extension.WriteUInt32(gscFileData.Pointer, 0x10400000); // Overwrite script pointer 
            MainForm.PS3.Extension.WriteBytes(0x10400000, gscFile); // Write compiled script buffer to free memory location 

            MainForm.mainForm.LastInjectedGameType = gameType;

            MainForm.mainForm.NotifyMessageBO2("^2GSC File Injected", $"{Path.GetFileName(localFile)} to {installPath}", "party_ready");
            _ = DarkMessageBox.Show(this, $"Injected File: {localFile}\nTime: {DateTime.Now:H:mm:ss}", "Success", MessageBoxIcon.Information);
        }

        private void LoadGscFilePaths(string gameType)
        {
            ComboBoxInstallPath.Items.Clear();

            if (gameType.Equals("MP"))
            {
                foreach (GscData.FileItem fileItem in MainForm.GscDumpMP.Files)
                {
                    ComboBoxInstallPath.Items.Add(fileItem.Name);
                }
            }
            else if (gameType.Equals("ZM"))
            {
                foreach (GscData.FileItem fileItem in MainForm.GscDumpZM.Files)
                {
                    ComboBoxInstallPath.Items.Add(fileItem.Name);
                }
            }
        }

        /// <summary>
        ///     Set the current process status in the tool strip
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
        {
            ToolStripLabelStatus.Text = status;

            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(status, ex);
            }

            Refresh();
        }

        private void ButtonLocalFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "GSC files (*.gsc)|*.gsc|All files (*.*)|*.*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxLocalFile.Text = openFileDialog.FileName;
                }
            }
        }
    }
}