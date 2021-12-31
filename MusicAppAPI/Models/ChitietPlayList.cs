using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class ChitietPlayList
    {
        public int IdPlayList { get; set; }
        public int IdBaihat { get; set; }

        public virtual Baihat IdBaihatNavigation { get; set; }
        public virtual PlayList IdPlayListNavigation { get; set; }
    }
}
