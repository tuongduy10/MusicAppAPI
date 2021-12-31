using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class Casi
    {
        public Casi()
        {
            ChitietBaihats = new HashSet<ChitietBaihat>();
        }

        public int IdCasi { get; set; }
        public string Tencasi { get; set; }
        public string Nghedanh { get; set; }
        public string AnhCasi { get; set; }

        public virtual ICollection<ChitietBaihat> ChitietBaihats { get; set; }
    }
}
