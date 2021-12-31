using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class Baihat
    {
        public Baihat()
        {
            ChitietBaihats = new HashSet<ChitietBaihat>();
            ChitietPlayLists = new HashSet<ChitietPlayList>();
            ChitietTheloais = new HashSet<ChitietTheloai>();
        }

        public int IdBaihat { get; set; }
        public string Tenbaihat { get; set; }
        public string Link { get; set; }
        public int Luotxem { get; set; }
        public string Lyrics { get; set; }
        public string Anhbaihat { get; set; }

        public virtual ICollection<ChitietBaihat> ChitietBaihats { get; set; }
        public virtual ICollection<ChitietPlayList> ChitietPlayLists { get; set; }
        public virtual ICollection<ChitietTheloai> ChitietTheloais { get; set; }
    }
}
