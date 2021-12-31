using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class ChitietBaihat
    {
        public int IdBaihat { get; set; }
        public int IdCasi { get; set; }

        public virtual Baihat IdBaihatNavigation { get; set; }
        public virtual Casi IdCasiNavigation { get; set; }
    }
}
