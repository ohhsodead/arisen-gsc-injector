using System.IO;

namespace Arisen_GSC_Injector.Extensions
{
    public class StringExtensions
    {
        public static string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }
    }
}