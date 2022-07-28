using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Atomic.Constants;
using Atomic.Forms;
using Atomic.Io;
using Atomic.Models.Release_Data;
using DevExpress.XtraEditors;
using Newtonsoft.Json;

namespace Atomic.Extensions
{
    public abstract class UpdateExtensions
    {
        /// <summary>
        ///     
        /// </summary>
        public static readonly WebClient WebClient = new();

        /// <summary>
        ///     Get the current application version.
        /// </summary>
        public static Version CurrentVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        ///     Get the current application version name.
        /// </summary>
        public static string CurrentVersionName { get; } = $"Beta v{CurrentVersion.ToString().TrimStart('0', '.')}";

        /// <summary>
        ///     Get the latest release data from GitHub.
        /// </summary>
        public static GitHubData GitHubData { get; } = GetGitHubLatestReleaseData();

        /// <summary>
        ///     Get the latest release information from the GitHub API.
        /// </summary>
        /// <returns></returns>
        public static GitHubData GetGitHubLatestReleaseData()
        {
            GitHubData gitHubLatestReleaseData;

            using (var streamReader = new StreamReader(HttpExtensions.GetStream(Urls.GitHubLatestRelease)))
            {
                gitHubLatestReleaseData = JsonConvert.DeserializeObject<GitHubData>(streamReader.ReadToEnd());
            }

            return gitHubLatestReleaseData;
        }

        /// <summary>
        ///     Check the current application version against the latest version hosted on GitHub. If this version is outdated,
        ///     then download and run the latest version installer.
        /// </summary>
        public static void CheckApplicationVersion()
        {
            try
            {
                MainWindow.Window.SetStatus("Checking application for new update...");

                var latestVersion = new Version(GitHubData.TagName);

                if (CurrentVersion.CompareTo(latestVersion) < 0)
                {
                    DownloadAndRunInstaller();
                }
                else
                {
                    MainWindow.Window.SetStatus($"You're currently using the latest version of Atomic ({GitHubData.Name})");
                }
            }
            catch (Exception ex)
            {
                MainWindow.Window.SetStatus($"Unable to check for new version for the moment. Error: {ex.Message}", ex);
            }
        }

        /// <summary>
        ///     Download the latest installer from GitHub to the user's downloads folder, run the program and close this instance
        ///     of the application.
        /// </summary>
        private static void DownloadAndRunInstaller()
        {
            try
            {
                var installerFile = $@"{KnownFolders.GetPath(KnownFolder.Downloads)}\{GitHubData.Assets[0].Name}";

                MainWindow.Window.SetStatus("A new update is available. Downloading the installer...");
                XtraMessageBox.Show(MainWindow.Window, $@"A new version of Atomic ({GitHubData.Name}) is now available. Click OK to download and run the installer.", @"Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WebClient.DownloadFile(GitHubData.Assets[0].BrowserDownloadUrl, installerFile);
                Process.Start(installerFile);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MainWindow.Window.SetStatus($"Unable to download or run the installer. Error: {ex.Message})", ex);
                XtraMessageBox.Show(MainWindow.Window, @"Unable to complete the update. You must manually install the latest available update from the GitHub releases page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start($"{Urls.GitHubRepo}releases/latest");
                Application.Exit();
            }
        }
    }
}