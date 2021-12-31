using System;
using System.Collections.Generic;

#nullable disable

namespace MusicAppAPI.Models
{
    public partial class Theloai
    {
        public Theloai()
        {
            ChitietTheloais = new HashSet<ChitietTheloai>();
        }

        public int IdTheloai { get; set; }
        public string TenTheloai { get; set; }

        public virtual ICollection<ChitietTheloai> ChitietTheloais { get; set; }
    }
}
