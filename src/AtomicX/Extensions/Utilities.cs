using AtomicX.Database;
using AtomicX.Forms;
using DarkUI.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AtomicX.Extensions
{
    internal static class Utilities
    {
        /// <summary>
        ///     Application user's data roaming directory
        /// </summary>
        internal static string AppDataPath { get; } = $@"{Application.UserAppDataPath}\";

        /// <summary>
        ///     Web URL pointing to the project repo hosted on GitHub
        /// </summary>
        internal const string ProjectRepoUrl = "https://github.com/ohhsodead/AtomicX/";

        /// <summary>
        ///     Web URL pointing to the project's version file
        /// </summary>
        internal const string ProjectAppDataUrl = "https://dl.dropbox.com/s/05fbf7raf4sm98l/app-version.json?raw=true";

        /// <summary>
        ///     Get the current application product version
        /// </summary>
        /// <returns></returns>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
        public static bool IsConnectedToInternet()
        {
            return InternetGetConnectedState(out _, 0);
        }

        /// <summary>
        ///     
        /// </summary>
        public static void CheckApplicationVersion()
        {
            try
            {
                Program.Log.Info("Checking for a new update...");

                using (StreamReader streamReader = new StreamReader(HttpExtensions.GetStream(ProjectAppDataUrl)))
                {
                    AppData appData = JsonConvert.DeserializeObject<AppData>(streamReader.ReadToEnd());

                    Version newVersion = new Version(appData.AppVersion);

                    if (CurrentVersion.CompareTo(newVersion) < 0)
                    {
                        RunInstaller(newVersion);
                    }
                    else
                    {
                        Program.Log.InfoFormat("ModioX is running latest available update (Version: {0})", newVersion);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.Log.Info("Failed to update. Message : " + ex.Message, ex);
                Application.Exit();
            }
        }

        /// <summary>
        ///     Downloads the new version installer from GitHub releases to the users downloads folder, closes the application and runs the installer
        /// </summary>
        /// <param name="newVersion">Newest update version</param>
        private static void RunInstaller(Version newVersion)
        {
            try
            {
                Program.Log.Info(@"New update available - Starting to download the installer...");
                DarkMessageBox.Show(MainForm.mainForm, $@"This version of AtomicX is now outdated. An update (v{newVersion}) has been released on GitHub. Click OK to download and run the installer.", @"Update Available", MessageBoxIcon.Information);

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile($"{ProjectRepoUrl}releases/download/{newVersion}/AtomicX.Installer.Windows.exe", $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\AtomicX.Installer.Windows.exe");
                }

                Process.Start($@"{KnownFolders.GetPath(KnownFolder.Downloads)}\AtomicX.Installer.Windows.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                Program.Log.Error("There was a problem starting the update installer : " + ex.Message, ex);
                DarkMessageBox.Show(MainForm.mainForm, @"There was an issue. You will need to manually install the latest available update from the GitHub releases page.", "Error", MessageBoxIcon.Error);
                Process.Start($"{ProjectRepoUrl}releases/latest");
                Application.Exit();
            }
        }

        /// <summary>
        ///     Download and return the gsc multiplayer dump data
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscMultiplayerDataPS3()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://dl.dropbox.com/s/kepaclyfif9t6qr/ps3-gsc-dump-mp.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the gsc zombies dump data
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscZombiesDataPS3()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://dl.dropbox.com/s/1bpjh455amuphq7/ps3-gsc-dump-zm.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the gsc multiplayer dump data
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscMultiplayerDataXBOX()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://dl.dropbox.com/s/oz3r3db5h51rrlm/xbox-gsc-dump-mp.json?aw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the gsc zombies dump data
        /// </summary>
        /// <returns></returns>
        internal static GscData GetGscZombiesDataXBOX()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://dl.dropbox.com/s/wech3c18ss667zd/xbox-gsc-dump-zm.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<GscData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Download and return the gsc mods data
        /// </summary>
        /// <returns></returns>
        internal static ModsData GetModsData()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://dl.dropbox.com/s/y71y5z2g9if89rw/gsc-mods.json?raw=true").Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception($"Bad response {response.StatusCode}");
                    }

                    string responseData = response.Content.ReadAsStringAsync().Result;

                    if (IsValidJson(responseData))
                    {
                        return JsonConvert.DeserializeObject<ModsData>(responseData);
                    }

                    dynamic data = JsonConvert.DeserializeObject(responseData);

                    throw new Exception(data.data.Message.ToString());
                }
            }
        }

        /// <summary>
        ///     Depth-first recursive delete, with handling for descendant 
        /// directories open in Windows Explorer.
        /// </summary>
        internal static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="zipPath"></param>
        /// <param name="files"></param>
        public static void AddFilesToZip(string zipPath, string[] files)
        {
            if (files == null || files.Length == 0)
            {
                return;
            }

            using (var zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
                }
            }
        }

        /// <summary>
        ///     Determines a valid json response
        /// </summary>
        /// <param name="data">Json data to validate</param>
        /// <returns>Whether text is valid json format</returns>
        public static bool IsValidJson(string data)
        {
            try
            {
                JToken unused = JToken.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        ///     Open a new issue template for requesting mods
        /// </summary>
        internal static void OpenRequestTemplate()
        {
            _ = Process.Start($"{ProjectRepoUrl}issues/new?"
                              + $"title=[Request] Official Mod Name"
                              + $"&labels=mod request&"
                              + $"body=Enter some information about the mods here, add any links you can find that showcase the mods too.%0A"
                              + $"Game Type: Multiplayer / Zombies%0A"
                              + $"Mod Type: Mod Menu / Game Mode%0A"
                              + $"Author: Creator / Developer%0A"
                              + $"Version: Version%0A"
                              + $"Files: Download Link%0A"
                              + "----------------------- %0A"
                              + "*Please include any other additional information you can find for the mods.");
        }
    }
}