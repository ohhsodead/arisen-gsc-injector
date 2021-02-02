using AtomicX.Constants;
using AtomicX.Database;
using AtomicX.Extensions;
using AtomicX.Properties;
using DevExpress.XtraEditors;
using JRPC_Client;
using Newtonsoft.Json;
using PS3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using XDevkit;

namespace AtomicX.Forms
{
    public partial class MainWindow : XtraForm
    {
        public MainWindow()
        {
            Window = this;
            InitializeComponent();
        }

        /// <summary>
        /// Store the current form instance
        /// </summary>
        public static MainWindow Window { get; set; }

        /// <summary>
        /// Store the application settings data
        /// </summary>
        public static SettingsData SettingsData { get; set; } = new SettingsData();

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = $"AtomicX - {UpdateExtensions.CurrentVersionName}";

            if (HttpExtensions.IsConnectedToInternet())
            {
                LoadSettingsData();
                UpdateExtensions.CheckApplicationVersion();
                WorkerExtensions.RunWorkAsync(LoadData, InitializeFinished);

                EnableConsoleActions();
            }
            else
            {
                SetStatus("Not connected to the interet. Enable this in your computer settings.");
                XtraMessageBox.Show(this, "You must be connected to the Internet to use this application.", "No Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsData();
        }

        public static DropboxData Database { get; private set; }

        /// <summary>
        /// Store the PS3 instance
        /// </summary>
        public static PS3API PS3 { get; set; } = new PS3API(SelectAPI.ControlConsole);

        /// <summary>
        /// Store the Xbox instance
        /// </summary>
        public static IXboxConsole Xbox { get; set; } = null;

        /// <summary>
        /// Store the connected console type
        /// </summary>
        public static string ConsoleType;

        /// <summary>
        /// Retrieve the mods data and gsc data dumps into application
        /// </summary>
        private void LoadData()
        {
            try
            {
                Database = new DropboxData();
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load database. Error: " + ex.Message, ex);
                XtraMessageBox.Show(Window, "There was an issue loading the database.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Finalize application data after the initialize completes
        /// </summary>
        private void InitializeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatus($"Successfully loaded database - Finalizing data...");

            LoadMods("",
                     "",
                     "");

            ComboBoxGameType.SelectedIndex = 0;
            ComboBoxModType.SelectedIndex = 0;

            ToolStripLabelStats.Text = $"{Database.Mods.TotalModsMP} Mods for Multiplayer, {Database.Mods.TotalModsZM} Mods for Zombies (Last Updated: {Database.Mods.LastUpdated.ToLocalTime().ToShortDateString()})";

            SetStatus($"Initialized AtomicX ({UpdateExtensions.CurrentVersionName}) - Ready to connect and attach to console...");
        }

        /// <summary>
        /// Store whether console is connected
        /// </summary>
        public static bool IsConsoleConnected { get; set; }

        private void MenuItemConnectPS3CCAPI_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
            ConnectPS3();
        }

        private void MenuItemConnectPS3TMAPI_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
            ConnectPS3();
        }

        private void MenuItemConnectPS3Disconnect_Click(object sender, EventArgs e)
        {
            DisconnectPS3();
        }

        private void MenuItemXBOXConnect_Click(object sender, EventArgs e)
        {
            ConnectXBOX();
        }

        private void MenuItemXBOXDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectXBOX();
        }

        private void MenuItemToolsFileInjector_Click(object sender, EventArgs e)
        {
            using (FileInjector fileInjector = new FileInjector())
            {
                fileInjector.ShowDialog(this);
            }
        }

        private void MenuItemReportIssue_Click(object sender, EventArgs e)
        {
            Process.Start($"{Urls.GitHubRepo}issues/new");
        }

        private void MenuItemDiscordServer_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sqpktsCHUg");
        }

        private void MenuItemCheckForUpdate_Click(object sender, EventArgs e)
        {
            UpdateExtensions.CheckApplicationVersion();
        }

        private void MenuItemAboutAtomicX_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(this, "AtomicX was developed by @ohhsodead and few friends, with the only intention of providing an efficient tool for browsing, downloading and injecting GSC mods. All credits are given to those appropriate creators/authors of the mods used in this project. If you have any questions please send a message at my Discord: ohhsodead#2519 with your much welcomed comments, suggestions and feedback to help support this project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuItemClearGscMods_Click(object sender, EventArgs e)
        {
            ClearGscMods();
            MenuItemClearGscMods.Enabled = false;
        }

        /// <summary>
        /// Connect to PS3 console
        /// </summary>
        private void ConnectPS3()
        {
            try
            {
                if (PS3.ConnectTarget())
                {
                    if (PS3.AttachProcess())
                    {
                        IsConsoleConnected = true;
                        SetStatusConsole(PS3.GetConsoleName());
                        ConsoleType = "PS3";
                        EnableConsoleActions();

                        MenuItemConnectPS3CCAPI.Visible = false;
                        MenuItemConnectPS3TMAPI.Visible = false;
                        MenuItemConnectPS3Disconnect.Visible = true;

                        MenuItemConnectXBOX.Enabled = false;

                        if (!IsInGame())
                        {
                            NotifyMessagePS3("^2Hooked to AtomicX", "Successfully connected and attached!", "party_ready");
                        }

                        XtraMessageBox.Show(this, "Connected and attached to Black Ops II", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show(this, "Unable to attach to game process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, "Unable to connect to console.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "Unable to connect to console.\n\nError Message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Disconnect from PS3 console
        /// </summary>
        private void DisconnectPS3()
        {
            try
            {
                PS3.DisconnectTarget();

                IsConsoleConnected = false;
                ConsoleType = "";

                SetStatusConsole(null);
                EnableConsoleActions();

                MenuItemConnectPS3CCAPI.Visible = true;
                MenuItemConnectPS3TMAPI.Visible = true;
                MenuItemConnectPS3Disconnect.Visible = false;

                MenuItemConnectXBOX.Enabled = true;
                MenuItemXBOXConnect.Visible = true;
                MenuItemXBOXDisconnect.Visible = false;

                SetStatus("Successfully disconnected from console.");
                XtraMessageBox.Show(this, "Successfully disconnected from console", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus("Unable to disconnect from console - Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "Unable to disconnect from console.\\n\nError Message:\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Connect to default xbox console
        /// </summary>
        private void ConnectXBOX()
        {
            try
            {
                var XboxManager = new XboxManager();
                Xbox = XboxManager.OpenConsole(XboxManager.DefaultConsole);
                Xbox.OpenConnection(null);

                IsConsoleConnected = true;
                ConsoleType = "XBOX";

                SetStatusConsole(Xbox.Name);
                EnableConsoleActions();

                MenuItemConnectPS3.Enabled = false;

                MenuItemXBOXConnect.Visible = false;
                MenuItemXBOXDisconnect.Visible = true;

                SetStatus("Successfully connected to console.");
                XtraMessageBox.Show(this, "Connected to console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus("Couldn't connect to console - Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "Unable to connect to console.\n\nError Message:/n: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Disconnect from Xbox console
        /// </summary>
        private void DisconnectXBOX()
        {
            try
            {
                Xbox.CloseConnection(0);

                IsConsoleConnected = false;
                SetStatusConsole(null);
                ConsoleType = "";
                EnableConsoleActions();

                MenuItemConnectPS3.Enabled = true;
                MenuItemConnectPS3Disconnect.Visible = false;

                MenuItemXBOXConnect.Visible = true;
                MenuItemXBOXDisconnect.Visible = false;

                SetStatus("Successfully disconnected from console.");
                XtraMessageBox.Show(this, "Successfully disconnected from console", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus("Unable to disconnect from console - Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "Unable to disconnect from console - Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Store the name filter mods option
        /// </summary>
        private string FilterModsName { get; set; } = "";

        /// <summary>
        /// Store the game type filter mods option
        /// </summary>
        private string FilterModsGameType { get; set; } = "";

        /// <summary>
        /// Store the mod type filter mods option
        /// </summary>
        private string FilterModType { get; set; } = "";

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterModsName = TextBoxSearch.Text;

            LoadMods(
                FilterModsName,
                FilterModsGameType,
                FilterModType);
        }

        private void ComboBoxGameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterModsGameType = ComboBoxGameType.SelectedItem.ToString();

            LoadMods(FilterModsName,
                     FilterModsGameType,
                     FilterModType);
        }

        private void ComboBoxModType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxModType.SelectedIndex == 0)
            {
                FilterModType = "";
            }
            else
            {
                FilterModType = ComboBoxModType.SelectedItem.ToString();
            }

            LoadMods(FilterModsName,
                     FilterModsGameType,
                     FilterModType);
        }

        /// <summary>
        /// Loops and adds either entire or users favourites mods from the database for the given game and filter into the gridview
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gameType"></param>
        /// <param name="modType"></param>
        private void LoadMods(string name, string gameType, string modType)
        {
            DgvMods.Rows.Clear();

            foreach (ModsData.ModItem modItem in Database.Mods.GetModItems(name, gameType, modType))
            {
                DgvMods.Rows.Add(
                    modItem.Id,
                    modItem.Name,
                    modItem.GetGameType(),
                    modItem.GetModType(),
                    "v" + modItem.Version,
                    modItem.CreatedBy,
                    ImageExtensions.ResizeBitmap(Resources.install, 19, 19),
                    ImageExtensions.ResizeBitmap(Resources.download_from_the_cloud, 19, 19));
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
        /// Get the last injected gsc files
        /// </summary>
        public List<string> LastUsedGscFiles { get; set; } = new List<string>();

        /// <summary>
        /// Get the last injected gametype
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
                ToolItemInstall.Enabled = DgvMods.CurrentRow != null && IsConsoleConnected;
                ToolItemDownload.Enabled = DgvMods.CurrentRow != null;

                ModsData.ModItem modItem = Database.Mods.GetModById(int.Parse(DgvMods.CurrentRow.Cells[0].Value.ToString()));

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

            ToolItemInstall.Enabled = DgvMods.SelectedRows.Count != 0 && IsConsoleConnected;
            ToolItemDownload.Enabled = DgvMods.SelectedRows.Count != 0;
        }

        private void ScrollBarDetails_Scroll(object sender, ScrollEventArgs e)
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
        /// Restores all the custom gsc pointers to their correct buffers
        /// </summary>
        public void ClearGscMods()
        {
            try
            {
                if (IsInGame())
                {
                    SetStatus($"You must be in pre-game lobby before clearing GSC files.");
                    XtraMessageBox.Show(this, "You must be in pre-game lobby before clearing GSC files.", "Can't Inject", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach (string gscFile in LastUsedGscFiles)
                {
                    GscData.FileItem gscFileData = GetGscFileData(ConsoleType, LastInjectedGameType, gscFile);

                    if (ConsoleType.Equals("PS3"))
                    {
                        PS3.Extension.WriteUInt32(gscFileData.Pointer, gscFileData.Buffer);
                    }
                    else if (ConsoleType.Equals("XBOX"))
                    {
                        Xbox.WriteUInt32(gscFileData.Pointer, gscFileData.Buffer);
                    }
                }

                if (ConsoleType.Equals("PS3"))
                {
                    NotifyMessagePS3("^2Cleared GSC Mods", "Successfully cleared all mods", "party_ready");
                }

                SetStatus($"All GSC files have been restored.");
                XtraMessageBox.Show(this, "All GSC files have been restored.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to clear GSC files. Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "Unable to clear GSC files.\n\nMessage:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Injects the specified GSC mods to the their correct game locations
        /// </summary>
        /// <param name="modItem"></param>
        private void InjectModItem(ModsData.ModItem modItem)
        {
            try
            {
                if (IsInGame())
                {
                    SetStatus($"You must be in pre-game lobby before injecting mods.");
                    XtraMessageBox.Show(this, "You must be in pre-game lobby before injecting mods.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ClearGscMods();
                LastUsedGscFiles.Clear();

                modItem.DownloadInstallFiles();

                // Free Memory Offsets
                uint freeMemoryOffset;

                if (ConsoleType.Equals("PS3"))
                {
                    freeMemoryOffset = 0x51000000;
                }
                else
                {
                    freeMemoryOffset = 0x40300000;
                }

                foreach (string installFilePath in modItem.InstallPaths)
                {
                    foreach (string localFilePath in Directory.GetFiles(modItem.GetDownloadDataPath(), "*.*", SearchOption.AllDirectories))
                    {
                        string installFileName = Path.GetFileName(installFilePath);

                        if (string.Equals(installFileName, Path.GetFileName(localFilePath), StringComparison.CurrentCultureIgnoreCase))
                        {
                            GscData.FileItem gscFileData = GetGscFileData(ConsoleType, modItem.GameType, installFilePath);

                            LastUsedGscFiles.Add(installFilePath);

                            byte[] gscFile = File.ReadAllBytes(localFilePath);

                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.GetGameType()}) - Injecting GSC file: {installFileName} ...");

                            if (ConsoleType.Equals("PS3"))
                            {
                                PS3.Extension.WriteUInt32(gscFileData.Pointer, 0x51000000); // Overwrite script pointer 
                                PS3.Extension.WriteBytes(0x51000000, gscFile); // Write compiled script buffer to free memory location 
                            }
                            else if (ConsoleType.Equals("XBOX"))
                            {
                                Xbox.WriteUInt32(gscFileData.Pointer, 0x40300000);
                                Xbox.WriteByte(0x40300000, gscFile);
                            }

                            /* TESTS FOR INJECTING MUTIPLE GSC FILES aZaZ..
                            if (ConsoleType.Equals("PS3"))
                            {
                                freeMemoryOffset = GET_ALIGNED_DWORD(freeMemoryOffset + 1);

                                PS3.Extension.WriteUInt32(gscFileData.Pointer, freeMemoryOffset); // Overwrite script pointer 
                                PS3.Extension.WriteBytes(freeMemoryOffset, new byte[gscFile.Length + 1]);
                                PS3.Extension.WriteBytes(freeMemoryOffset, gscFile); // Write compiled script buffer to free memory location 

                                freeMemoryOffset += (uint)(gscFile.Length + 1);
                            }
                            else if (ConsoleType.Equals("XBOX"))
                            {
                                freeMemoryOffset = GET_ALIGNED_DWORD(freeMemoryOffset + 1);

                                XBOX.SetMemory(gscFileData.Pointer, BitConverter.GetBytes(freeMemoryOffset).Reverse().ToArray());
                                XBOX.SetMemory(freeMemoryOffset, new byte[gscFile.Length + 1]);
                                XBOX.SetMemory(freeMemoryOffset, gscFile);
                                

                                freeMemoryOffset += (uint)(gscFile.Length + 1);
                            }
                            

                            Xbox.WriteUInt32(gscFileData.Pointer, freeMemoryOffset);
                            */

                            SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.GetGameType()}) - Injected GSC file: {installFileName}");
                            MenuItemClearGscMods.Enabled = true;
                        }
                    }
                }

                LastInjectedGameType = modItem.GameType;

                SettingsData.UpdateInstalledMod(modItem.GameType, modItem.Id);
                SaveSettingsData();

                if (ConsoleType.Equals("PS3"))
                {
                    NotifyMessagePS3("^2Injected GSC Mods", $"{modItem.Name} v{modItem.Version} by {modItem.CreatedBy}", "party_ready");
                }

                SetStatus($"{modItem.Name} v{modItem.Version} ({modItem.GetGameType()}) - Injected all GSC files.");

                XtraMessageBox.Show(this, $"Injected Mods: {modItem.Name}\nTime: {DateTime.Now:H:mm:ss}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus($"Unable to inject GSC files. Error: {ex.Message}", ex);
                XtraMessageBox.Show(this, $"There was a problem injecting gsc files. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public uint GET_ALIGNED_DWORD(uint address)
        {
            return (address + 3) & 0xFFFFFFFC;
        }

        /// <summary>
        /// Download the mods archive to the directory selected by user.
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
        /// Returns whether the user is in a game or pre-game lobby.
        /// </summary>
        /// <returns></returns>
        public bool IsInGame()
        {
            if (ConsoleType.Equals("PS3"))
            {
                return Convert.ToBoolean(PS3.Extension.ReadUInt32(0x1CB68C0 + 0x18));
            }
            else if (ConsoleType.Equals("XBOX"))
            {
                return Convert.ToBoolean(Xbox.CallString(0x82154FF8, new object[] { 0, "cl_ingame" }));
            }

            return false;
        }

        /// <summary>
        /// Display a custom notification in-game (Credits to NotMyFaultv2 - https://cabconmodding.com/threads/c-c-bo2-notification.3013/).
        /// </summary>
        /// <param name="title"></param>
        /// <param name="caption"></param>
        /// <param name="shader"></param>
        public void NotifyMessagePS3(string title, string caption, string shader)
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
        /// Set the UI to display the selected mod details.
        /// </summary>
        /// <param name="modId">Mod Id to display information</param>
        private void ShowModDetails(int modId)
        {
            ModsData.ModItem modItem = Database.Mods.GetModById(modId);

            if (modItem == null)
            {
                return;
            }

            // Get the mod data from the specified modId

            // Set the selected mod item property
            SelectedModItem = modItem;

            // Display details in UI
            LabelHeaderNameNo.Text = modItem.Name;
            LabelGameType.Text = modItem.GetGameType();
            LabelModType.Text = modItem.GetModType();
            LabelVersion.Text = modItem.Version;
            LabelAuthor.Text = modItem.CreatedBy.Replace("&", "&&");
            LabelSubmittedBy.Text = modItem.SubmittedBy.Replace("&", "&&");
            LabelDescription.Text = string.IsNullOrWhiteSpace(modItem.Description) ? "Can't find any description for this yet." : modItem.Description.Replace("&", "&&");

            ToolItemInstall.Enabled = IsConsoleConnected;

            ToolItemUninstall.Enabled = SettingsData.GetInstalledGameMod(modItem.GetGameType()) != null
                && IsConsoleConnected 
                && SettingsData.GetInstalledGameMod(modItem.GetGameType()).ModId.Equals(modItem.Id);

            UpdateScrollBarDetails();
        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateScrollBarDetails()
        {
            ScrollBarDetails.Minimum = FlowPanelDetails.VerticalScroll.Minimum;
            ScrollBarDetails.Maximum = FlowPanelDetails.VerticalScroll.Maximum;
            ScrollBarDetails.SmallChange = FlowPanelDetails.VerticalScroll.SmallChange;
            ScrollBarDetails.LargeChange = FlowPanelDetails.VerticalScroll.LargeChange;
            ScrollBarDetails.Value = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consoleType"></param>
        /// <param name="gameType"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static GscData.FileItem GetGscFileData(string consoleType, string gameType, string filePath)
        {
            if (consoleType.Equals("PS3"))
            {
                if (gameType.Equals("MP"))
                {
                    foreach (GscData.FileItem fileItem in Database.GscMultiplayerPS3.Files)
                    {
                        if (fileItem.Name.ToLower().Equals(filePath.ToLower()))
                        {
                            return fileItem;
                        }
                    }
                }
                else if (gameType.Equals("ZM"))
                {
                    foreach (GscData.FileItem fileItem in Database.GscZombiesPS3.Files)
                    {
                        if (fileItem.Name.ToLower().Equals(filePath.ToLower()))
                        {
                            return fileItem;
                        }
                    }
                }
            }
            else if (consoleType.Equals("XBOX"))
            {
                if (gameType.Equals("MP"))
                {
                    foreach (GscData.FileItem fileItem in Database.GscMultiplayerXBOX.Files)
                    {
                        if (fileItem.Name.ToLower().Equals(filePath.ToLower()))
                        {
                            return fileItem;
                        }
                    }
                }
                else if (gameType.Equals("ZM"))
                {
                    foreach (GscData.FileItem fileItem in Database.GscZombiesXBOX.Files)
                    {
                        if (fileItem.Name.ToLower().Equals(filePath.ToLower()))
                        {
                            return fileItem;
                        }
                    }
                }
            }

            throw new Exception($"Can't find any gsc data for Console: {consoleType}, Game Type: {gameType}, File Path: {filePath}");
        }

        /// <summary>
        /// Enable/disable console controls
        /// </summary>
        private void EnableConsoleActions()
        {
            MenuItemToolsFileInjector.Enabled = IsConsoleConnected;
            MenuItemClearGscMods.Enabled = IsConsoleConnected;
            ToolItemInstall.Enabled = IsConsoleConnected;
            ToolItemDownload.Enabled = IsConsoleConnected;
        }

        /// <summary>
        /// Set the current connected console status in the tool strip
        /// </summary>
        /// <param name="consoleName"></param>
        private void SetStatusConsole(string consoleName)
        {
            ToolStripLabelConsole.Text = string.IsNullOrEmpty(consoleName) ? "Idle" : consoleName;
        }

        /// <summary>
        /// Set the current process status in the tool strip
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
        /// Save application settings json data file
        /// </summary>
        public void SaveSettingsData()
        {
            using (StreamWriter streamWriter = new StreamWriter(SettingsData.SettingsDataFile))
            {
                streamWriter.Write(JsonConvert.SerializeObject(SettingsData));
            }
        }

        /// <summary>
        /// Load application settings json data file
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
    }
}