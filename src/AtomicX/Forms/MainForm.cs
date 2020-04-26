using AtomicX.Database;
using AtomicX.Extensions;
using AtomicX.Properties;
using DarkUI.Forms;
using Newtonsoft.Json;
using PS3Lib;
using XRPCLib;
using Microsoft.Test.Xbox.XDRPC;
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
using XDevkit;

namespace AtomicX.Forms
{
    public partial class MainForm : DarkForm
    {
        public MainForm()
        {
            mainForm = this;
            InitializeComponent();
        }

        /// <summary>
        ///     
        /// </summary>
        public static MainForm mainForm;

        /// <summary>
        ///     
        /// </summary>
        public static SettingsData SettingsData { get; set; } = new SettingsData();

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = string.Format("AtomicX - Beta {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString().Remove(0, 2));

            Utilities.CheckApplicationVersion();
            LoadSettingsData();
            Worker.RunWorkAsync(LoadData, InitializeFinished);

            EnableConsoleActions();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsData();
        }

        /// <summary>
        ///     
        /// </summary>
        public static GscData GscDumpMP;

        /// <summary>
        ///     
        /// </summary>
        public static GscData GscDumpZM;

        /// <summary>
        ///     
        /// </summary>
        public static ModsData Mods;

        /// <summary>
        /// 
        /// </summary>
        public static PS3API PS3;

        /// <summary>
        /// 
        /// </summary>
        public IXboxManager xbManager = null;
        public IXboxConsole xbCon = null;

        public bool activeConnection = false;
        public uint xboxConnection = 0;

        private string debuggerName = null;
        private string userName = null;

        /// <summary>
        ///     Retrieves the games and mods data into the application
        /// </summary>
        private static void LoadData()
        {
            GscDumpMP = Utilities.GetGscMultiplayerData();
            GscDumpZM = Utilities.GetGscZombiesData();
            Mods = Utilities.GetModsData();
        }

        /// <summary>
        ///     Finalize application data properties after being initialized
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Successfully loaded the database - Finalizing data...");

            LoadMods(
                "",
                "",
                "");

            ComboBoxGameType.SelectedIndex = 0;
            ComboBoxModType.SelectedIndex = 0;

            ToolStripLabelStats.Text = string.Format("{0} Mods for Multiplayer, {1} Mods for Zombies", Mods.TotalModsMP, Mods.TotalModsZM);

            SetStatus($"Initialized AtomicX (Version Beta {Utilities.CurrentVersion.ToString().Remove(0, 2)}) - Ready to connect and attach...");
        }

        /// <summary>
        ///     
        /// </summary>
        public static bool IsConsoleConnected { get; set; }

        private void MenuStripConnectPS3CCAPI_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
            ConnectPS3();
        }

        private void MenuStripConnectPS3TMAPI_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
            ConnectPS3();
        }

        private void MenuItemPS3Disconnect_Click(object sender, EventArgs e)
        {
            DisconnectPS3();
        }

        private void MenuItemXBOXConnect_Click(object sender, EventArgs e)
        {
            ConnectXBOX();
        }

        private void MenuItemXBOXDisconnect_Click(object sender, EventArgs e)
        {
            //DisconnectXBOX();
        }

        private void MenuItemReportIssue_Click(object sender, EventArgs e)
        {
            _ = Process.Start($"{Utilities.ProjectRepoUrl}issues/new");
        }

        private void MenuItemSourceCode_Click(object sender, EventArgs e)
        {
            _ = Process.Start(Utilities.ProjectRepoUrl);
        }

        private void MenuItemCheckForUpdates_Click(object sender, EventArgs e)
        {
            Utilities.CheckApplicationVersion();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            _ = DarkMessageBox.Show(this, "AtomicX was developed by @ohhsodead and few friends, with the only intention of providing an efficient tool for browsing, downloading and injecting GSC mods. All credits are given to those appropriate creators/authors of the mods used in this project. If you have any questions please send a message at my Discord: ohhsodead#2519 with your much welcomed comments, suggestions and feedback to help support this project.", "About", MessageBoxIcon.Information);
        }

        private void MenuItemClearGscMods_Click(object sender, EventArgs e)
        {
            ClearGscMods();
        }

        private void MenuStripRequestGscMods_Click(object sender, EventArgs e)
        {
            Utilities.OpenRequestTemplate();
        }

        /// <summary>
        ///     
        /// </summary>
        private void ConnectPS3()
        {
            try
            {
                if (PS3.ConnectTarget())
                {
                    if (PS3.AttachProcess())
                    {
                        NotifyMessageBO2("^2Hooked to AtomicX", "Successfully connected and attached", "party_ready");

                        IsConsoleConnected = true;
                        SetStatusConsole(PS3.GetConsoleName());
                        EnableConsoleActions();

                        MenuItemConnectPS3CCAPI.Visible = false;
                        MenuItemConnectPS3TMAPI.Visible = false;
                        MenuItemConnectPS3Disconnect.Visible = true;
                        
                        _ = DarkMessageBox.Show(this, "Connected and attached to Black Ops II", "Success", MessageBoxIcon.Information);
                    }
                    else
                    {
                        _ = DarkMessageBox.Show(this, "Unable to attach to game process. Make sure you have Black Ops II started.", "Error", MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _ = DarkMessageBox.Show(this, "Unable to connect to console.", "Error", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _ = DarkMessageBox.Show(this, "There was a problem trying to connect to console. Error Message: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        private void DisconnectPS3()
        {
            try
            {
                PS3.DisconnectTarget();
                IsConsoleConnected = false;
                SetStatusConsole(null);
                EnableConsoleActions();

                MenuItemConnectPS3CCAPI.Visible = true;
                MenuItemConnectPS3TMAPI.Visible = true;
                MenuItemConnectPS3Disconnect.Visible = false;

                SetStatus("Successfully disconnected console.");
                _ = DarkMessageBox.Show(this, "Successfully disconnected console", "Success", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus("Couldn't disconnect from console - Error Message: " + ex.Message, ex);
                _ = DarkMessageBox.Show(this, "There was a problem disconnecting from console - Error Message: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        private void ConnectXBOX()
        {
            try
            {
                if (ConnectToXbox())
                {
                    IsConsoleConnected = true;
                    SetStatusConsole(xbCon.Name);
                    EnableConsoleActions();

                    //xbCon.WriteUInt32();
                    //xbCon.WriteBytes();

                    //CPUKeyLabel.Text = xbCon.GetCPUKey();
                    //TitleIDLabel.Text = string.Format("Current Title ID: 0x{0}", xbCon.GetCurrentTitleId().ToString("X"));
                    //ConsoleDebugIPLabel.Text = string.Format("Console Debug IP: {0}", xbCon.GetConsoleIP());
                }
                else
                {
                    //CPUKeyLabel.Text = "00000000000000000000000000000000";
                    //TitleIDLabel.Text = "Current Title ID: 0x00000000";
                    //ConsoleDebugIPLabel.Text = "Console Debug IP: 192.168.1.1";
                }
            }
            catch (Exception ex)
            {
                _ = DarkMessageBox.Show(this, "Couldn't connect to console. Error Message: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        public bool ConnectToXbox()
        {
            if (!activeConnection)
            {
                xbManager = new XboxManager();
                xbCon = xbManager.OpenConsole(xbManager.DefaultConsole);

                try
                {
                    xboxConnection = xbCon.OpenConnection(null);
                }
                catch (Exception ex)
                {
                    _ = DarkMessageBox.Show(this, $"Couldn't connect to console: {xbManager.DefaultConsole}. Error Message: " + ex.Message, "Error", MessageBoxIcon.Error);
                    return false;
                }
                if (xbCon.DebugTarget.IsDebuggerConnected(out debuggerName, out userName))
                {
                    activeConnection = true;
                    _ = DarkMessageBox.Show(this, $"Succesfully connected to console: {xbManager.DefaultConsole}.", "Success", MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    xbCon.DebugTarget.ConnectAsDebugger("AtomicX", XboxDebugConnectFlags.Force);
                    if (!xbCon.DebugTarget.IsDebuggerConnected(out debuggerName, out userName))
                    {
                        _ = DarkMessageBox.Show(this, $"Attempted to connect to console: {xbCon.Name}, but failed", "Error", MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        activeConnection = true;
                        _ = DarkMessageBox.Show(this, $"Succesfully connected to console: {xbCon.Name}.", "Success", MessageBoxIcon.Information);
                        return true;
                    }
                }
            }
            else if (xbCon.DebugTarget.IsDebuggerConnected(out debuggerName, out userName))
            {
                _ = DarkMessageBox.Show(this, $"Already connected to console: {xbCon.Name}.", "Success", MessageBoxIcon.Information);
                return true;
            }
            else
            {
                activeConnection = false;
                return ConnectToXbox();
            }
        }

        /// <summary>
        ///     Get/set the name to filter mods by
        /// </summary>
        private string FilterModsName { get; set; } = "";

        /// <summary>
        ///     Get/set the game type to filter mods by
        /// </summary>
        private string FilterModsGameType { get; set; } = "";

        /// <summary>
        ///     Get/set the mods type to filter mods by
        /// </summary>
        private string FilterModsType { get; set; } = "";

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterModsName = TextBoxSearch.Text;

            LoadMods(
                FilterModsName,
                FilterModsGameType,
                FilterModsType);
        }

        private void ComboBoxGameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsGameType = ComboBoxGameType.GetItemText(ComboBoxGameType.SelectedItem);

            LoadMods(
                FilterModsName,
                FilterModsGameType,
                FilterModsType);
        }

        private void ComboBoxModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxModType.SelectedIndex == 0)
            {
                FilterModsType = "";
            }
            else
            {
                FilterModsType = ComboBoxModType.GetItemText(ComboBoxModType.SelectedItem);
            }

            LoadMods(
                FilterModsName,
                FilterModsGameType,
                FilterModsType);
        }

        /// <summary>
        ///     Loops and adds either entire or users favourites mods from the database for the given game and filter into the gridview
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gameType"></param>
        /// <param name="modType"></param>
        private void LoadMods(string name, string gameType, string modType)
        {
            DgvMods.Rows.Clear();

            foreach (ModsData.ModItem modItem in Mods.GetModItems(name, gameType, modType))
            {
                _ = DgvMods.Rows.Add(
                    modItem.Id,
                    modItem.Name,
                    modItem.GetGameType(),
                    modItem.GetModType(),
                    "v" + modItem.Version,
                    modItem.CreatedBy,
                    ImageExtensions.ResizeBitmap(Resources.icons8_software_installer_22, 19, 19),
                    ImageExtensions.ResizeBitmap(Resources.icons8_download_from_the_cloud_22, 19, 19));
            }

            DgvMods.Sort(DgvMods.Columns[1], ListSortDirection.Ascending);

            if (DgvMods.Rows.Count > 0)
            {
                DgvMods.CurrentCell = DgvMods[1, 0];
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
                DgvMods.Enabled = true;
            }
            else
            {
                DgvMods.Enabled = false;
            }
        }

        /// <summary>
        ///     Get the last injected gsc files
        /// </summary>
        public List<string> LastUsedGscFiles { get; set; } = new List<string>();

        /// <summary>
        ///     Get the last injected gametype
        /// </summary>
        public string LastInjectedGameType { get; set; } = "MP";

        /// <summary>
        ///     
        /// </summary>
        private static ModsData.ModItem SelectedModItem { get; set; }

        private void DgvMods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ToolItemInstallMod.Enabled = e.RowIndex != -1 && IsConsoleConnected;
                ToolItemDownloadMod.Enabled = e.RowIndex != -1;

                ModsData.ModItem modItem = Mods.GetModById(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

                if (DgvMods.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
                {
                    if (IsConsoleConnected)
                    {
                        InjectModItem(modItem);
                    }
                }
                else if (DgvMods.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
                {
                    DownloadModArchive(modItem);
                }
            }
        }

        private void DgvMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvMods.CurrentRow != null)
            {
                ShowModDetails(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));
            }

            ToolItemInstallMod.Enabled = DgvMods.SelectedRows.Count != 0 && IsConsoleConnected;
            ToolItemDownloadMod.Enabled = DgvMods.SelectedRows.Count != 0;
        }

        private void ScrollBarDetails_ValueChanged(object sender, DarkUI.Controls.ScrollValueEventArgs e)
        {
            FlowPanelDetails.VerticalScroll.Value = ScrollBarDetails.Value;
            FlowPanelDetails.Update();
        }

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Remove dotted borders from the cells upon focus
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void ToolItemInstallMod_Click(object sender, EventArgs e)
        {
            InjectModItem(SelectedModItem);
        }

        private void ToolItemUninstallMod_Click(object sender, EventArgs e)
        {
            ClearGscMods();
        }

        private void ToolItemDownloadMod_Click(object sender, EventArgs e)
        {
            DownloadModArchive(SelectedModItem);
        }

        /// <summary>
        ///     Restores all the custom gsc pointers to their correct buffers
        /// </summary>
        public void ClearGscMods()
        {
            try
            {
                if (IsInGame())
                {
                    _ = DarkMessageBox.Show(this, "You must be in the pre-game lobby before clearing GSC mods.", "Can't Inject", MessageBoxIcon.Exclamation);
                    return;
                }

                NotifyMessageBO2("^2Cleared GSC Mods", "Successfully cleared all mods", "party_ready");

                foreach (string gscFile in LastUsedGscFiles)
                {
                    GscData.FileItem gscFileData = GetGscFileData(LastInjectedGameType, gscFile);
                    PS3.Extension.WriteUInt32(Convert.ToUInt32(gscFileData.Pointer), Convert.ToUInt32(gscFileData.Buffer));
                }

                _ = DarkMessageBox.Show(this, "All GSC mods have been cleared.", "Success", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                NotifyMessageBO2("^1Unable to Clear Mods", ex.Message, "party_notready");
                _ = DarkMessageBox.Show(this, "Unable to clear GSC mods.\n\nMessage:\n" + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Injects the specified GSC mods to the their correct game locations
        /// </summary>
        /// <param name="modItem"></param>
        private void InjectModItem(ModsData.ModItem modItem)
        {
            if (IsInGame())
            {
                _ = DarkMessageBox.Show(this, "You must be in the pre-game lobby before injecting GSC mods.", "Can't Inject", MessageBoxIcon.Exclamation);
                return;
            }          

            ClearGscMods();
            LastUsedGscFiles.Clear();
            modItem.DownloadInstallFiles();
            
            foreach (string installFilePath in modItem.InstallPaths)
            {
                foreach (string localFilePath in Directory.GetFiles(modItem.GetDirectoryDownloadData(), "*.*", SearchOption.AllDirectories))
                {
                    string installFileName = Path.GetFileName(installFilePath);

                    if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.CurrentCultureIgnoreCase))
                    {
                        GscData.FileItem gscFileData = GetGscFileData(modItem.GameType, installFilePath);

                        LastUsedGscFiles.Add(installFilePath);

                        byte[] gscFile = File.ReadAllBytes(localFilePath);

                        PS3.Extension.WriteUInt32(gscFileData.Pointer, 0x10400000); // Overwrite script pointer 
                        PS3.Extension.WriteBytes(0x10400000, gscFile); // Write compiled script buffer to free memory location 
                    }
                }
            }

            LastInjectedGameType = modItem.GameType;

            SettingsData.UpdateInstalledMod(modItem.GameType, modItem.Id);
            SaveSettingsData();

            NotifyMessageBO2("^2GSC Injected", $"{modItem.Name} v{modItem.Version} by {modItem.CreatedBy}", "party_ready");
            _ = DarkMessageBox.Show(this, $"Injected Mods: {modItem.Name}\nTime: {DateTime.Now:H:mm:ss}", "Success", MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Download the mods archive to the directory selected by user
        /// </summary>
        /// <param name="modItem"></param>
        public void DownloadModArchive(ModsData.ModItem modItem)
        {
            try
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        SetStatus($"{modItem.Name} ({modItem.GetGameType()}) - Downloading archive...");
                        modItem.DownloadArchiveAtPath(folderBrowser.SelectedPath);
                        SetStatus($"{modItem.Name} ({modItem.GetGameType()}) - Successfully downloaded archive at path: {folderBrowser.SelectedPath}");
                    }
                    else
                    {
                        SetStatus($"{modItem.Name} ({modItem.GetGameType()}) - Cancelled archive download.");
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus($"Error download archive '{modItem.Name} ({modItem.Id}) (Access maybe denied to this path, try a different one) - {ex.Message}", ex);
            }
        }

        /// <summary>
        ///     Returns whether the user is in a game or pre-game lobby
        /// </summary>
        /// <returns></returns>
        public static bool IsInGame()
        {
            return Convert.ToBoolean(PS3.Extension.ReadUInt32(0x1CB68C0 + 0x18));
        }

        /// <summary>
        ///     Display a custom notification in-game (Credits to NotMyFaultv2 - https://cabconmodding.com/threads/c-c-bo2-notification.3013/)
        /// </summary>
        /// <param name="title"></param>
        /// <param name="caption"></param>
        /// <param name="shader"></param>
        public void NotifyMessageBO2(string title, string caption, string shader) 
        {
            try
            {
                TimerNotifyOff.Enabled = false;
                PS3.SetMemory(0x1C1FE73, new byte[] { 0x28 });
                PS3.Extension.WriteString(0x01C1FC65, title);
                PS3.Extension.WriteString(0x01C1FE65, shader);
                PS3.Extension.WriteString(0x1C1FD65, caption);
                PS3.SetMemory(0x1C1FF66, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x0D50025, new byte[] { 0x20 });
                TimerNotifyOff.Enabled = true;
            }
            catch { }
        }

        private void TimerNotifyOff_Tick(object sender, EventArgs e)
        {
            try
            {
                PS3.SetMemory(0x1C1FF66, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                PS3.Extension.WriteString(0x1C1FD65, "");
            }
            catch { }

            TimerNotifyOff.Enabled = false;
        }

        /// <summary>
        ///     Set the UI to display the selected mod details
        /// </summary>
        /// <param name="modId">Mod Id to display information</param>
        private void ShowModDetails(long modId)
        {
            if (Mods.GetModById(modId) == null)
            {
                return;
            }

            // Get the mod data from the specified modId
            ModsData.ModItem modItem = Mods.GetModById(modId);

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelHeaderNameNo.Text = modItem.Name;
            LabelGameType.Text = modItem.GetGameType();
            LabelModType.Text = modItem.GetModType();
            LabelVersion.Text = modItem.Version;
            LabelAuthor.Text = modItem.CreatedBy.Replace("&", "&&");
            LabelSubmittedBy.Text = modItem.SubmittedBy.Replace("&", "&&");
            LabelDescription.Text = string.IsNullOrWhiteSpace(modItem.Description) ? "Can't find any description for this." : modItem.Description.Replace("&", "&&");

            ToolItemInstallMod.Enabled = IsConsoleConnected;

            ToolItemUninstallMod.Enabled = SettingsData.GetInstalledGameMod(modItem.GetGameType()) != null
                    ? IsConsoleConnected && SettingsData.GetInstalledGameMod(modItem.GetGameType()).ModId.Equals(modItem.Id)
                    : false;

            UpdateScrollBarDetails();
        }

        /// <summary>
        ///     
        /// </summary>
        public void UpdateScrollBarDetails()
        {
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.ViewSize = FlowPanelDetails.VerticalScroll.LargeChange - 30;
            ScrollBarDetails.Value = 0;
            ScrollBarDetails.UpdateScrollBar();
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="gameType"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static GscData.FileItem GetGscFileData(string gameType, string filePath)
        {
            if (gameType.Equals("MP"))
            {
                foreach (GscData.FileItem fileItem in GscDumpMP.Files)
                {
                    if (fileItem.Name.ToLower().Equals(filePath.ToLower()))
                    {
                        return fileItem;
                    }
                }
            }
            else if (gameType.Equals("ZM"))
            {
                foreach (GscData.FileItem fileItem in GscDumpZM.Files)
                {
                    if (fileItem.Name.ToLower().Equals(filePath.ToLower()))
                    {
                        return fileItem;
                    }
                }
            }

            throw new Exception("Can't find any gsc data for this game type and file path.");
        }

        /// <summary>
        ///     
        /// </summary>
        private void EnableConsoleActions()
        {
            //MenuItemToolsCustomInjector.Enabled = IsConsoleConnected;
            MenuItemClearGscMods.Enabled = IsConsoleConnected;
            ToolItemInstallMod.Enabled = IsConsoleConnected;
            ToolItemDownloadMod.Enabled = IsConsoleConnected;
        }

        /// <summary>
        ///     Set the current connected console status in the tool strip
        /// </summary>
        /// <param name="consoleName"></param>
        private void SetStatusConsole(string consoleName)
        {
            ToolStripLabelConsole.Text = string.IsNullOrEmpty(consoleName) ? "Idle" : consoleName;
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

        /// <summary>
        ///     Save application settings json data file
        /// </summary>
        public void SaveSettingsData()
        {
            using (StreamWriter streamWriter = new StreamWriter(SettingsData.SettingsDataFile))
            {
                streamWriter.Write(JsonConvert.SerializeObject(SettingsData));
            }
        }

        /// <summary>
        ///     Load application settings json data file
        /// </summary>
        public void LoadSettingsData()
        {
            if (File.Exists(SettingsData.SettingsDataFile))
            {
                using (StreamReader streamReader = new StreamReader(SettingsData.SettingsDataFile))
                {
                    SettingsData = JsonConvert.DeserializeObject<SettingsData>(streamReader.ReadToEnd());
                }
            }

            // Load Settings UI
            MenuItemSettingsAlwaysDownloadInstallFiles.Checked = SettingsData.AlwaysDownloadInstallFiles;
        }

        private void MenuItemToolsCustomInjector_Click(object sender, EventArgs e)
        {
            using (CustomInjector customInjector = new CustomInjector())
            {
                _ = customInjector.ShowDialog(this);
            }
        }
    }
}