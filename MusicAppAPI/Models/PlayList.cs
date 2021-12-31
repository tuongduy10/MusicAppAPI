using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class PlayList
    {
        public PlayList()
        {
            ChitietPlayLists = new HashSet<ChitietPlayList>();
        }

        public int IdPlayList { get; set; }
        public string TenPlayList { get; set; }
        public string Idtaikhoan { get; set; }

        public virtual Taikhoan IdtaikhoanNavigation { get; set; }
        public virtual ICollection<ChitietPlayList> ChitietPlayLists { get; set; }
    }
}
