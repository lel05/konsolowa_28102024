using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa
{
    public class Song
    {
        public string? Artist { get; set; }
        public string? Album { get; set; }
        public int SongsNumber { get; set; }
        public int Year { get; set; }
        public uint DownloadNumber { get; set; }
    }
}
