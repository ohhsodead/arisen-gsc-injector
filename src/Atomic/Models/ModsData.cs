using Atomic.Extensions;
using Atomic.Forms;
using Atomic.Io;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace Atomic.Database
{
    public partial class ModsData
    {
        public DateTime LastUpdated { get; set; }

        public List<ModItem> Mods { get; set; }

        public class ModItem
        {
            public int Id { get; set; }

            public string GameType { get; set; }

            public string ModType { get; set; }

            public string Name { get; set; }

            public string CreatedBy { get; set; }

            public string SubmittedBy { get; set; }

            public string Version { get; set; }

            public string Description { get; set; }

            public string Url { get; set; }

            public string[] InstallPaths { get; set; }

            /// <summary>
            ///     
            /// </summary>
            /// <returns></returns>
            public string GetGameType()
            {
                if (GameType.Equals("MP"))
                {
                    return "Multiplayer";
                }
                else if (GameType.Equals("ZM"))
                {
                    return "Zombies";
                }
                else
                {
                    return "n/a";
                }
            }

            /// <summary>
            ///     
            /// </summary>
            /// <returns></returns>
            public string GetModType()
            {
                if (ModType.Equals("Menu"))
                {
                    return "Mod Menu";
                }
                else if (ModType.Equals("Mode"))
                {
                    return "Game Mode";
                }
                else
                {
                    return "n/a";
                }
            }

            /// <summary>
            ///     Downloads the modded files archive and extracts the files to the user's appdata path
            /// </summary>
            public void DownloadInstallFiles()
            {
                string archivePath = GetDownloadDataPath();
                string archiveFilePath = GetArchiveZipFilePath();

                if (!MainWindow.SettingsData.AlwaysDownloadInstallFiles && File.Exists(archiveFilePath))
                {
                    return;
                }

                if (Directory.Exists(archivePath))
                {
                    UserFolders.DeleteDirectory(archivePath);
                }

                if (File.Exists(archiveFilePath))
                {
                    File.Delete(archiveFilePath);
                }

                Directory.CreateDirectory(GetDownloadDataPath());

                using WebClient wc = new();
                wc.Headers.Add("Accept: application/zip");
                wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                wc.DownloadFile(new Uri(Url), archiveFilePath);
                ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
            }

            /// <summary>
            ///     Download mods archive to the specified local folder path
            /// </summary>
            /// <param name="localPath">Path to downloads mods archive at folder</param>
            public void DownloadArchiveAtPath(string localPath)
            {
                string zipFileName = StringExtensions.ReplaceInvalidChars(string.Format("{0} v{1}.zip", Name, Version));
                string zipFilePath = Path.Combine(localPath, zipFileName);

                GenerateReadMeAtPath(GetDownloadDataPath());

                using (WebClient wc = new())
                {
                    wc.Headers.Add("Accept: application/zip");
                    wc.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    wc.DownloadFile(new Uri(Url), zipFilePath);
                }

                Archives.AddFilesToZip(zipFilePath, new string[] { Path.Combine(GetDownloadDataPath(), "README.txt") });
            }

            /// <summary>
            ///     Creates and writes the mod information to a text file at the specified path
            /// </summary>
            /// <param name="directoryPath"></param>
            public void GenerateReadMeAtPath(string directoryPath)
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Create contents and write them to readme file 
                File.WriteAllLines(Path.Combine(directoryPath, "README.txt"), new string[]
                {
                    "Id: " + Id,
                    "Name: " + Name,
                    "Game Mode: " + GetGameType(),
                    "Mod Type: " + GetModType(),
                    "Version: " + Version,
                    "Created By: " + CreatedBy,
                    "Submitted By: " + SubmittedBy,
                    "Description: " + Description,
                    "Install Files: " + string.Join(", ", InstallPaths),
                    "Download URL: " + Url
                });
            }

            /// <summary>
            /// Get the directory for extracting modded files to.
            /// </summary>
            /// <returns></returns>
            public string GetDownloadDataPath() => $@"{UserFolders.AppModsData}{GameType}\{CreatedBy}\{StringExtensions.ReplaceInvalidChars(Name)} (#{Id})\";

            /// <summary>
            /// Gets the downloaded mods archive file path.
            /// </summary>
            /// <returns>Mods Archive File Path</returns>
            public string GetArchiveZipFilePath() => $@"{UserFolders.AppModsData}{GameType}\{CreatedBy}\{StringExtensions.ReplaceInvalidChars(Name)} (#{Id}).zip";
        }

        /// <summary>
        ///     
        /// </summary>
        public int TotalModsMP => (from ModItem modItem in Mods
                                   where modItem.GameType.Equals("MP")
                                   select modItem).Count();

        /// <summary>
        ///     
        /// </summary>
        public int TotalModsZM => (from ModItem modItem in Mods
                                   where modItem.GameType.Equals("ZM")
                                   select modItem).Count();

        /// <summary>
        ///     Gets all of the mods for the specified gameId, with results filtered by name, firmware and type
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mode"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<ModItem> GetModItems(string name, string mode, string type)
        {
            return (from ModItem modItem in Mods
                    where modItem.Name.ToLower().Contains(name.ToLower()) &&
                    modItem.GetGameType().ToLower().Contains(mode.ToLower()) &&
                    modItem.GetModType().ToLower().Contains(type.ToLower())
                    select modItem).Distinct().ToList();
        }

        /// <summary>
        ///     Get the <see cref="modItem"/> that matches the specified modId
        /// </summary>
        /// <param name="modId">Name of the mod</param>
        /// <returns>Mod information</returns>
        public ModItem GetModById(int modId)
        {
            foreach (ModItem modItem in from ModItem modItem in Mods
                                        where modItem.Id.Equals(modId)
                                        select modItem)
            {
                return modItem;
            }

            throw new Exception($"Unable to match a mod matching with this id : {modId}");
        }
    }
}