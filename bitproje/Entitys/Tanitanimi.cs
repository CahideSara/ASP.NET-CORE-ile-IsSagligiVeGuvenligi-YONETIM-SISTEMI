using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Tanitanimi
    {
        public Tanitanimi()
        {
            Tanilar = new HashSet<Tanilar>();
        }

        public int Tanitid { get; set; }
       
        public string Taniadi { get; set; }

        public ICollection<Tanilar> Tanilar { get; set; }
    }
}
