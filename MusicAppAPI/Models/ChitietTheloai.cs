using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class ChitietTheloai
    {
        public int IdTheloai { get; set; }
        public int IdBaihat { get; set; }

        public virtual Baihat IdBaihatNavigation { get; set; }
        public virtual Theloai IdTheloaiNavigation { get; set; }
    }
}
