using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class Taikhoan
    {
        public Taikhoan()
        {
            PlayLists = new HashSet<PlayList>();
        }

        public string IdTaikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Tennguoidung { get; set; }

        public virtual ICollection<PlayList> PlayLists { get; set; }
    }
}
