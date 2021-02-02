using System;
using System.Collections.Generic;
using System.IO;

namespace AtomicX.Database
{
    public partial class SettingsData
    {
        /// <summary>
        /// Local path at where the settings file will be stored on the machine
        /// </summary>
        public static readonly string SettingsDataFile = Path.Combine(Environment.CurrentDirectory, "SettingsData.json");

        public bool AlwaysDownloadInstallFiles { get; set; } = false;

        public List<InstalledMod> InstalledMods { get; set; } = new List<InstalledMod>();

        public void UpdateInstalledMod(string gameType, long modId)
        {
            RemoveInstalledMod(gameType, modId);

            InstalledMods.Add(new InstalledMod() { ModId = modId, GameType = gameType });
        }

        public void RemoveInstalledModByType(string gameType)
        {
            _ = InstalledMods.RemoveAll(x => x.GameType.ToLower().Equals(gameType));
        }

        public void RemoveInstalledMod(string gameType, long modId)
        {
            _ = InstalledMods.RemoveAll(x => x.GameType.ToLower().Equals(gameType) && x.ModId.Equals(modId));
        }

        public InstalledMod GetInstalledGameMod(string gameType)
        {
            foreach (InstalledMod gameMod in InstalledMods)
            {
                if (gameMod.GameType.Equals(gameType))
                {
                    return gameMod;
                }
            }

            return null;
        }
    }

    public class InstalledMod
    {
        public string GameType { get; set; }

        public long ModId { get; set; }
    }
}