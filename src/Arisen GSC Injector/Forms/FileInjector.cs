using Arisen_GSC_Injector.Database;
using DevExpress.XtraEditors;
using JRPC_Client;
using System;
using System.IO;
using System.Windows.Forms;

namespace Arisen_GSC_Injector.Forms
{
    public partial class FileInjector : XtraForm
    {
        public FileInjector()
        {
            InitializeComponent();
        }

        private void FileInjector_Load(object sender, EventArgs e)
        {
            LoadGscFilePaths("MP");

            SetStatus("Ready to inject files...");
        }

        private void RadioGroupGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioGroupGameMode.SelectedIndex == 0)
            {
                LoadGscFilePaths("MP");
            }
            else if (RadioGroupGameMode.SelectedIndex == 1)
            {
                LoadGscFilePaths("ZM");
            }
        }

        private void TextBoxLocalFile_TextChanged(object sender, EventArgs e)
        {
            ButtonInjectFile.Enabled = !string.IsNullOrWhiteSpace(TextBoxLocalFile.Text) && ComboBoxInstallPath.SelectedIndex != -1;
        }

        private void ButtonBrowseLocalFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new() { Filter = "GSC File (*.gsc)|*.gsc|All Files (*.*)|*.*" };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxLocalFile.Text = openFileDialog.FileName;
            }
        }

        private void ComboBoxInstallPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonInjectFile.Enabled = !string.IsNullOrWhiteSpace(TextBoxLocalFile.Text) && ComboBoxInstallPath.SelectedIndex != -1;
        }

        private void ButtonInjectFile_Click(object sender, EventArgs e)
        {
            InjectGSCFile();
        }

        /// <summary>
        ///     
        /// </summary>
        private void InjectGSCFile()
        {
            if (MainWindow.Window.IsInGame())
            {
                SetStatus("You must be in pre-game lobby before injecting any GSC files.");
                XtraMessageBox.Show(this, "You must be in pre-game lobby before injecting any GSC files.", "Not In Lobby", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(TextBoxLocalFile.Text))
            {
                SetStatus("The file you specified doesn't exist on your computer, choose another file.");
                XtraMessageBox.Show(this, "The file you specified doesn't exist on your computer, choose another file.", "File Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SetStatus("Read to inject.");
            if (ComboBoxInstallPath.SelectedIndex == -1)
            {
                SetStatus("You must specify a GSC file path for this file to be injected to.");
                XtraMessageBox.Show(this, "You must specify a GSC file path for this file to be injected to.", "No GSC Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MainWindow.Window.ClearGscMods();
            MainWindow.Window.LastUsedGscFiles.Clear();

            string gameType = RadioGroupGameMode.SelectedIndex == 0 ? "MP" : "ZM";
            string localFile = TextBoxLocalFile.Text;
            string installPath = (string)ComboBoxInstallPath.SelectedItem;

            GscData.FileItem gscFileData = MainWindow.GetGscFileData(MainWindow.ConsoleType, gameType, installPath);

            MainWindow.Window.LastUsedGscFiles.Add(installPath);

            byte[] gscFile = File.ReadAllBytes(localFile);

            SetStatus($"Injecting GSC file '{Path.GetFileName(localFile)}'...");

            if (MainWindow.ConsoleType.Equals("PS3"))
            {
                MainWindow.PS3.Extension.WriteUInt32(gscFileData.Pointer, 0x51000000); // Overwrite script pointer 
                MainWindow.PS3.Extension.WriteBytes(0x51000000, gscFile); // Write compiled script buffer to free memory location 
            }
            else if (MainWindow.ConsoleType.Equals("XBOX"))
            {
                MainWindow.XBOX.WriteUInt32(gscFileData.Pointer, 0x40300000);
                MainWindow.XBOX.WriteByte(0x40300000, gscFile);
            }

            MainWindow.Window.LastInjectedGameType = gameType;

            if (MainWindow.ConsoleType.Equals("PS3"))
            {
                MainWindow.Window.NotifyMessagePS3("^2GSC File Injected", $"{Path.GetFileName(localFile)} to {installPath}", "party_ready");
            }

            XtraMessageBox.Show(this, $"Injected File: {localFile}\nTime: {DateTime.Now:H:mm:ss}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameType"></param>
        private void LoadGscFilePaths(string gameType)
        {
            ComboBoxInstallPath.Properties.Items.Clear();

            if (MainWindow.ConsoleType.Equals("PS3"))
            {
                if (gameType.Equals("MP"))
                {
                    foreach (GscData.FileItem fileItem in MainWindow.Database.GscMultiplayerPS3.Files)
                    {
                        ComboBoxInstallPath.Properties.Items.Add(fileItem.Name);
                    }
                }
                else if (gameType.Equals("ZM"))
                {
                    foreach (GscData.FileItem fileItem in MainWindow.Database.GscZombiesPS3.Files)
                    {
                        ComboBoxInstallPath.Properties.Items.Add(fileItem.Name);
                    }
                }
            }
            else if (MainWindow.ConsoleType.Equals("XBOX"))
            {
                if (gameType.Equals("MP"))
                {
                    foreach (GscData.FileItem fileItem in MainWindow.Database.GscMultiplayerXBOX.Files)
                    {
                        ComboBoxInstallPath.Properties.Items.Add(fileItem.Name);
                    }
                }
                else if (gameType.Equals("ZM"))
                {
                    foreach (GscData.FileItem fileItem in MainWindow.Database.GscZombiesXBOX.Files)
                    {
                        ComboBoxInstallPath.Properties.Items.Add(fileItem.Name);
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
            LabelStatus.Caption = status;

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
    }
}