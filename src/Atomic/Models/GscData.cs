using System.Collections.Generic;

namespace Atomic.Database
{
    public partial class GscData
    {
        public List<FileItem> Files { get; set; }

        public class FileItem
        {
            public string Name { get; set; }

            public uint Pointer { get; set; }

            public uint Buffer { get; set; }

            public uint Size { get; set; }
        }
    }
}