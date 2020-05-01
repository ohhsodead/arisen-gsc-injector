using AtomicX.Database;
using AtomicX.Extensions;
using DarkUI.Forms;
using System;
using System.IO;
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
            if (MainForm.mainForm.IsInGame())
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

            GscData.FileItem gscFileData = MainForm.GetGscFileData(MainForm.ConsoleType, gameType, installPath);

            MainForm.mainForm.LastUsedGscFiles.Add(installPath);

            byte[] gscFile = File.ReadAllBytes(localFile);

            SetStatus($"Injecting GSC file '{Path.GetFileName(localFile)}'...");

            if (MainForm.ConsoleType.Equals("PS3"))
            {
                MainForm.PS3.Extension.WriteUInt32(gscFileData.Pointer, 0x51000000); // Overwrite script pointer 
                MainForm.PS3.Extension.WriteBytes(0x51000000, gscFile); // Write compiled script buffer to free memory location 
            }
            else if (MainForm.ConsoleType.Equals("XBOX"))
            {
                MainForm.XboxConsole.WriteUInt32(gscFileData.Pointer, 0x40300000);
                MainForm.XboxConsole.WriteBytes(0x40300000, gscFile);
            }

            MainForm.mainForm.LastInjectedGameType = gameType;

            if (MainForm.ConsoleType.Equals("PS3"))
            {
                MainForm.mainForm.NotifyMessageBO2("^2GSC File Injected", $"{Path.GetFileName(localFile)} to {installPath}", "party_ready");
            }

            _ = DarkMessageBox.Show(this, $"Injected File: {localFile}\nTime: {DateTime.Now:H:mm:ss}", "Success", MessageBoxIcon.Information);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameType"></param>
        private void LoadGscFilePaths(string gameType)
        {
            ComboBoxInstallPath.Items.Clear();

            if (MainForm.ConsoleType.Equals("PS3"))
            {
                if (gameType.Equals("MP"))
                {
                    foreach (GscData.FileItem fileItem in MainForm.GscDumpMultiplayerPS3.Files)
                    {
                        ComboBoxInstallPath.Items.Add(fileItem.Name);
                    }
                }
                else if (gameType.Equals("ZM"))
                {
                    foreach (GscData.FileItem fileItem in MainForm.GscDumpZombiesPS3.Files)
                    {
                        ComboBoxInstallPath.Items.Add(fileItem.Name);
                    }
                }
            }
            else if (MainForm.ConsoleType.Equals("XBOX"))
            {
                if (gameType.Equals("MP"))
                {
                    foreach (GscData.FileItem fileItem in MainForm.GscDumpMultiplayerXBOX.Files)
                    {
                        ComboBoxInstallPath.Items.Add(fileItem.Name);
                    }
                }
                else if (gameType.Equals("ZM"))
                {
                    foreach (GscData.FileItem fileItem in MainForm.GscDumpZombiesXBOX.Files)
                    {
                        ComboBoxInstallPath.Items.Add(fileItem.Name);
                    }
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