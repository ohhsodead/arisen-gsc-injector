using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;
using System.Net;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace atomic_tool
{
    public partial class frmInjector : Form
    {
        public uint Original;
        public uint New;
        public uint Pointer;
        public byte[] OriginalByte;
        public byte[] NewByte;

        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);

        public frmInjector()
        {
            InitializeComponent();
        }

        frmDialog PopupBox = new frmDialog();
        frmInformation InfoBox = new frmInformation();

        private void btnConnect_ClickButtonArea(object Sender, MouseEventArgs e)
        {

            if (PS3.ConnectTarget(0))
            {
                useCCAPI.Enabled = false;
                useTMAPI.Enabled = false;

                if (PS3.AttachProcess())
                {
                    notifyBlackOps2("^2Hooked to Atomic", "Successfully connected and attached", "party_ready");

                    PopupBox.lblStatus.Text = "Successfully connected and attached \nGsc mods restored";
                    PopupBox.Text = "Success";
                    PopupBox.ShowDialog(this);
                    btnConnectAttach.Text = "Connected && Attached to Black Ops II";

                    btnConnectAttach.Enabled = false;
                    btnSetName.Enabled = true;
                    txtChangeName.Enabled = true;

                    btnConnectAttach.ForeColor = Color.DarkGray;
                    btnSetName.ForeColor = Color.White;

                    lblTitleModMenu.ForeColor = Color.White;
                    cmboItemsGscMenus.Enabled = true;
                    lblTitleGameMode.ForeColor = Color.White;
                    cmboItemsGscModes.Enabled = true;
                    lblTitleModMenuZM.ForeColor = Color.White;
                    cmboItemsGscMenusZM.Enabled = true;


                    Original = 0x3045E820;
                    New = 0x10040000;
                    Pointer = 0x140C2D0;
                    OriginalByte = new byte[] { 0x30, 0x45, 0xE8, 0x20 };
                    NewByte = new byte[] { 0x10, 0x04, 0x00, 0x00 };

                    PS3.Extension.WriteUInt32(Pointer, Original);
                }
                else
                {
                    PopupBox.lblStatus.Text = "Unable to attach to game process";
                    PopupBox.Text = "Error";
                    PopupBox.ShowDialog(this);
                }
            }
            else
            {
                PopupBox.lblStatus.Text = "Unable to connect to PS3";
                PopupBox.Text = "Error";
                PopupBox.ShowDialog(this);
            }
        }

        uint gscPointer;
        List<string> lastUsedPointers = new List<string>();

        private void btnStartMenu_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try
            {
                if (useZombies == true)
                {
                    if (cmboItemsGscMenusZM.SelectedIndex == -1)
                    {

                    }
                    else
                    {
                        cButton2_ClickButtonArea(Sender, e);
                        lastUsedPointers.Clear();
                        string[] gscPaths = Directory.GetFiles(cmboItemsGscMenusPathsZM.GetItemText(cmboItemsGscMenusPathsZM.SelectedItem), "*", SearchOption.AllDirectories);

                        foreach (string gsc in gscPaths)
                        {
                            int countItem = 0;
                            foreach (object item in cmboItemsGscNameZM.Items)
                            {
                                countItem = countItem + 1;
                                if (item.ToString().Contains(gsc.Remove(0, cmboItemsGscMenusPathsZM.GetItemText(cmboItemsGscMenusPathsZM.SelectedItem).Length + 1)))
                                {
                                    cmboItemsGscNameZM.SelectedIndex = countItem - 1;
                                    lastUsedPointers.Add(cmboItemsGscPointerZM.GetItemText(cmboItemsGscPointerZM.SelectedItem));

                                    gscPointer = Convert.ToUInt32(cmboItemsGscPointerZM.GetItemText(cmboItemsGscPointerZM.SelectedItem), 16);

                                    byte[] gscModsFile = File.ReadAllBytes(gsc);

                                    PS3.SetMemory(gscPointer, new byte[] { 0x10, 0x04, 0x00, 0x00 });
                                    PS3.SetMemory(0x140C4F8, gscModsFile);
                                }
                            }
                        }

                        notifyBlackOps2("^2GSC Injected", "Loaded " + cmboItemsGscMenusZM.SelectedItem.ToString(), "party_ready");

                        PopupBox.lblStatus.Text = "Injected Mods (ZM): " + cmboItemsGscMenusZM.GetItemText(cmboItemsGscMenusZM.SelectedItem) + "\nTime: " + DateTime.Now.ToString("HH:mm:ss");
                        PopupBox.Text = "Success";
                        PopupBox.ShowDialog(this);
                    }
                }
                else
                {
                    if (cmboItemsGscMenus.SelectedIndex == -1)
                    {

                    }
                    else
                    {
                        //cButton2_ClickButtonArea(Sender, e);
                        lastUsedPointers.Clear();
                        string[] gscPaths = Directory.GetFiles(cmboItemsGscMenusPaths.GetItemText(cmboItemsGscMenusPaths.SelectedItem), "*", SearchOption.AllDirectories);

                        foreach (string gsc in gscPaths)
                        {
                            int countItem = 0;
                            foreach (object item in cmboItemsGscNameMP.Items)
                            {
                                countItem = countItem + 1;
                                if (item.ToString().Contains(gsc.Remove(0, cmboItemsGscMenusPaths.GetItemText(cmboItemsGscMenusPaths.SelectedItem).Length + 1)))
                                {
                                    cmboItemsGscNameMP.SelectedIndex = countItem - 1;
                                    lastUsedPointers.Add(cmboItemsGscPointerMP.GetItemText(cmboItemsGscPointerMP.SelectedItem));

                                    gscPointer = Convert.ToUInt32(cmboItemsGscPointerMP.GetItemText(cmboItemsGscPointerMP.SelectedItem), 16);

                                    byte[] gscModsFile = File.ReadAllBytes(gsc);

                                    PS3.SetMemory(gscPointer, new byte[] { 0x10, 0x04, 0x00, 0x00 });
                                    PS3.SetMemory(0x10040000, gscModsFile);
                                }                                    
                            }
                        }
                           
                        notifyBlackOps2("^2GSC Injected", "Loaded " + cmboItemsGscMenus.SelectedItem.ToString(), "party_ready");

                        PopupBox.lblStatus.Text = "Injected Mods: " + cmboItemsGscMenus.GetItemText(cmboItemsGscMenus.SelectedItem) + "\nTime: " + DateTime.Now.ToString("HH:mm:ss");
                        PopupBox.Text = "Success";
                        PopupBox.ShowDialog(this);
                    }

                    if (cmboItemsGscModes.SelectedIndex == -1)
                    {

                    }
                    else
                    {
                        cButton2_ClickButtonArea(Sender, e);
                        lastUsedPointers.Clear();
                        string[] gscPaths = Directory.GetFiles(cmboItemsGscModesPaths.GetItemText(cmboItemsGscModesPaths.SelectedItem), "*", SearchOption.AllDirectories);

                        foreach (string gsc in gscPaths)
                        {
                            int countItem = 0;
                            foreach (object item in cmboItemsGscNameMP.Items)
                            {
                                countItem = countItem + 1;
                                if (item.ToString().Contains(gsc.Remove(0, cmboItemsGscModesPaths.GetItemText(cmboItemsGscModesPaths.SelectedItem).Length + 1)))
                                {
                                    cmboItemsGscNameMP.SelectedIndex = countItem - 1;
                                    lastUsedPointers.Add(cmboItemsGscPointerMP.GetItemText(cmboItemsGscPointerMP.SelectedItem));

                                    gscPointer = Convert.ToUInt32(cmboItemsGscPointerMP.GetItemText(cmboItemsGscPointerMP.SelectedItem), 16);

                                    byte[] gscModsFile = File.ReadAllBytes(gsc);

                                    PS3.SetMemory(gscPointer, new byte[] { 0x10, 0x04, 0x00, 0x00 });
                                    PS3.SetMemory(0x10040000, gscModsFile);
                                }
                            }
                        }

                        notifyBlackOps2("^2GSC Injected", "Loaded " + cmboItemsGscModes.SelectedItem.ToString(), "party_ready");

                        PopupBox.lblStatus.Text = "Injected Mods: " + cmboItemsGscModes.SelectedItem.ToString() + "\n" + "Time: " + DateTime.Now.ToString("HH:mm:ss");
                        PopupBox.Text = "Success";
                        PopupBox.ShowDialog(this);
                    }
                }

                btnRestoreGsc.Enabled = true;
                btnRestoreGsc.ForeColor = Color.White;
            }
            catch
            {
                notifyBlackOps2("^1No GSC Injected", "Unable to load " + cmboItemsGscMenus.SelectedItem.ToString(), "party_notready");

                PopupBox.lblStatus.Text = "Unable to inject gsc mods";
                PopupBox.Text = "Error";
                PopupBox.ShowDialog(this);
            }

        }

        public static List<string> GetDirectories(string path, string searchPattern = "*",
        SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            if (searchOption == SearchOption.TopDirectoryOnly)
                return Directory.GetDirectories(path, searchPattern).ToList();

            var directories = new List<string>(GetDirectories(path, searchPattern));

            for (var i = 0; i < directories.Count; i++)
                directories.AddRange(GetDirectories(directories[i], searchPattern));

            return directories;
        }

        private void btnInformation_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            InfoBox.ShowDialog(this);
        }

        private void useCCAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void useTMAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void cButton1_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(txtChangeName.Text + "\0");
            PS3.SetMemory(0x026C0658, bytes);
        }

        string pathGscMods = "https://dl.dropbox.com/s/t5hn9orfzgagcs6/GSC%20Mods.zip?dl=0";
        string GscMods = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Atomic Tool GSC\";
        string GscModsMenuMP = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Atomic Tool GSC\Mod Menu\";
        string GscModsModeMP = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Atomic Tool GSC\Game Mode\";
        string GscModsMenuZM = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Atomic Tool GSC\Zombie Menu\";
        string zipPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Atomic Tool GSC\GSC Mods.zip";
        string gscLocationsMP = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Atomic Tool GSC\GSC Dump MP.txt";
        string gscLocationsZM = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Atomic Tool GSC\GSC Dump ZM.txt";

        private void InjectorForm_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://dl.dropbox.com/s/12q2xkdkzo6kek4/atomic-version.txt?dl=0");
            StreamReader reader = new StreamReader(stream);
            Version newVersion = new Version(reader.ReadToEnd());
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            if (curVersion.CompareTo(newVersion) < 0)
            {
                PopupBox.lblStatus.Text = "There is a new update available (" + newVersion.ToString() + "";
                PopupBox.Text = "Update Available";
                PopupBox.ShowDialog(this);
                try
                {
                    Process.Start(Application.StartupPath + @"\Atomic Tool Auto Updater.exe");
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    PopupBox.lblStatus.Text = ex.Message;
                    PopupBox.Text = "Unable to update tool";
                    PopupBox.ShowDialog(this);
                    Application.Restart();
                }
            }
            else
            { 
                try
                {
                    if (Directory.Exists(GscMods))
                    {
                        Directory.Delete(GscMods, true);
                    }
                    if (File.Exists(zipPath))
                    {
                        File.Delete(zipPath);
                    }
                    Directory.CreateDirectory(GscMods);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFile(new Uri(pathGscMods),
                            zipPath);

                        System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, GscMods);
                    }

                    cmboItemsGscMenus.Items.Clear();
                    cmboItemsGscMenusPaths.Items.Clear();
                    cmboItemsGscModes.Items.Clear();
                    cmboItemsGscModesPaths.Items.Clear();
                    cmboItemsGscMenusZM.Items.Clear();
                    cmboItemsGscMenusPathsZM.Items.Clear();

                    string pathMenuMP = GscModsMenuMP;
                    foreach (string s in Directory.GetDirectories(GscModsMenuMP))
                    {
                        cmboItemsGscMenus.Items.Add(s.Remove(0, pathMenuMP.Length));
                        cmboItemsGscMenusPaths.Items.Add(GscModsMenuMP + s.Remove(0, pathMenuMP.Length));
                    }

                    string pathModeMP = GscModsModeMP;
                    foreach (string s in Directory.GetDirectories(GscModsModeMP))
                    {
                        cmboItemsGscModes.Items.Add(s.Remove(0, pathModeMP.Length));
                        cmboItemsGscModesPaths.Items.Add(GscModsModeMP + s.Remove(0, pathModeMP.Length));
                    }

                    string pathMenuZM = GscModsMenuZM;
                    foreach (string s in Directory.GetDirectories(GscModsMenuZM))
                    {
                        cmboItemsGscMenusZM.Items.Add(s.Remove(0, pathMenuZM.Length));
                        cmboItemsGscMenusPathsZM.Items.Add(GscModsMenuZM + s.Remove(0, pathMenuZM.Length));
                    }
                }
                catch (Exception ex)
                {
                    PopupBox.lblStatus.Text = ex.Message;
                    PopupBox.Text = "Unable to download mods";
                    PopupBox.ShowDialog(this);
                }


                //GSC Pointers (Credit to SyGnUs : https://github.com/SyGnUs) - Thank you!
                try
                {
                    //Multiplayer
                    using (WebClient wc2 = new WebClient())
                    {
                        wc2.DownloadFile(new Uri("https://dl.dropbox.com/s/38dz0helzyh7qwo/GSC%20Dump%20MP.txt?dl=0"),
                        gscLocationsMP);
                    }

                    string[] gscMPNames = File.ReadAllLines(gscLocationsMP);
                    foreach (var gsc in gscMPNames)
                    {
                        string[] gscName = gsc.Split(':');
                        string[] gscPointers = gsc.Split();
                        gscPointers[0] = gscPointers[0].Substring(gscPointers[0].IndexOf(":") + 1);
                        cmboItemsGscNameMP.Items.Add(gscName[0]);
                        cmboItemsGscPointerMP.Items.Add(gscPointers[0]);
                    }


                    //Zombies
                    using (WebClient wc2 = new WebClient())
                    {
                        wc2.DownloadFile(new Uri("https://dl.dropbox.com/s/ieinxm7o2k5kes4/GSC%20Dump%20ZM.txt?dl=0"),
                        gscLocationsZM);
                    }

                    string[] gscNamesZM = File.ReadAllLines(gscLocationsZM);
                    foreach (var gsc in gscNamesZM)
                    {
                        string[] gscName = gsc.Split(':');
                        string[] gscPointers = gsc.Split();
                        gscPointers[0] = gscPointers[0].Substring(gscPointers[0].IndexOf(":") + 1);
                        cmboItemsGscNameZM.Items.Add(gscName[0]);
                        cmboItemsGscPointerZM.Items.Add(gscPointers[0]);
                    }

                }
                catch (Exception ex)
                {
                    PopupBox.lblStatus.Text = ex.Message;
                    PopupBox.Text = "Unable to download pointers";
                    PopupBox.ShowDialog(this);
                    Application.Restart();
                }
            }
        }

        private void cButton2_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            try
            {
                notifyBlackOps2("^2Restored GSC Mods", "Successfully unloaded GSC mods", "party_ready");

                foreach (string pointer in cmboItemsGscPointerMP.Items)
                {
                    if (lastUsedPointers.Contains(pointer))
                    {
                        gscPointer = Convert.ToUInt32(pointer, 16);
                        PS3.Extension.WriteUInt32(gscPointer, Original);
                    }
                }

                foreach (string pointer in cmboItemsGscPointerZM.Items)
                {
                    if (lastUsedPointers.Contains(pointer))
                    {
                        gscPointer = Convert.ToUInt32(pointer, 16);
                        PS3.Extension.WriteUInt32(gscPointer, Original);
                    }
                }

                PopupBox.lblStatus.Text = "Gsc mods cleared";
                PopupBox.Text = "Success";
                PopupBox.ShowDialog(this);
            }
            catch (Exception ex)
            {
                notifyBlackOps2("^1Unable to Clear Mods", ex.Message, "party_notready");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboItemsGscMenusPaths.SelectedIndex = cmboItemsGscMenus.SelectedIndex;
            btnStartMenu.Enabled = true;
            btnStartMenu.ForeColor = Color.White;

            if (cmboItemsGscMenus.SelectedIndex == -1)
            { }
            else
            {
                cmboItemsGscModes.SelectedIndex = -1;
            }
        }

        private void btnRefreshMods_ClickButtonArea(object Sender, MouseEventArgs e)
        {
            InjectorForm_Load(Sender, e);
        }

        private void cmboItemsGscModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboItemsGscModesPaths.SelectedIndex = cmboItemsGscModes.SelectedIndex;
            btnStartMenu.Enabled = true;
            btnStartMenu.ForeColor = Color.White;

            if (cmboItemsGscModes.SelectedIndex == -1)
            { }
            else
            {
                cmboItemsGscMenus.SelectedIndex = -1;
            }
        }

        private void notifyBlackOps2(string textHeader, string text, string Shader) //Credits to NotMyFaultv2 (https://cabconmodding.com/threads/c-c-bo2-notification.3013/)
        {
            try
            {
                timerNotificationOff.Enabled = false;
                PS3.SetMemory(0x1C1FE73, new byte[] { 0x28 });
                PS3.Extension.WriteString(0x01C1FC65, textHeader);
                PS3.Extension.WriteString(0x01C1FE65, Shader);
                PS3.Extension.WriteString(0x1C1FD65, text);
                PS3.SetMemory(0x1C1FF66, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x0D50025, new byte[] { 0x20 });
                timerNotificationOff.Enabled = true;
            }
            catch { }
        }

        private void timerNotificationOff_Tick(object sender, EventArgs e)
        {
            try
            {
                PS3.SetMemory(0x1C1FF66, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                PS3.Extension.WriteString(0x1C1FD65, "");
            }
            catch { }
            timerNotificationOff.Enabled = false;
        }

        private void cmboItemsGscName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboItemsGscPointerMP.SelectedIndex = cmboItemsGscNameMP.SelectedIndex;
        }

        private void cmboItemsGscMenusZM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboItemsGscMenusPathsZM.SelectedIndex = cmboItemsGscMenusZM.SelectedIndex;
            btnStartMenu.Enabled = true;
            btnStartMenu.ForeColor = Color.White;
        }

        bool useZombies = false;
        private void chkZombies_CheckedChanged(object sender, EventArgs e)
        {
            useZombies = chkZombies.Checked;

            if (chkZombies.Checked == true)
            {
                lblTitleModMenuZM.Visible = true;
                cmboItemsGscMenusPathsZM.Visible = true;
                cmboItemsGscMenusZM.Visible = true;

                lblTitleGameMode.Visible = false;
                lblTitleModMenu.Visible = false;
                cmboItemsGscMenusPaths.Visible = false;
                cmboItemsGscMenus.Visible = false;
                cmboItemsGscModesPaths.Visible = false;
                cmboItemsGscModes.Visible = false;
            }
            else if (chkZombies.Checked == false)
            {
                lblTitleGameMode.Visible = true;
                lblTitleModMenu.Visible = true;
                cmboItemsGscMenusPaths.Visible = true;
                cmboItemsGscMenus.Visible = true;
                cmboItemsGscModesPaths.Visible = true;
                cmboItemsGscModes.Visible = true;

                lblTitleModMenuZM.Visible = false;
                cmboItemsGscMenusPathsZM.Visible = false;
                cmboItemsGscMenusZM.Visible = false;
            }
        }

        private void cmboItemsGscNameZM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboItemsGscPointerZM.SelectedIndex = cmboItemsGscNameZM.SelectedIndex;
        }
    }
}