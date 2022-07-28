using System.IO;
using System.IO.Compression;

namespace Atomic.Io
{
    public class Archives
    {
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

            using var zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Update);
            foreach (var file in files)
            {
                FileInfo fileInfo = new(file);
                zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
            }
        }
    }
}
