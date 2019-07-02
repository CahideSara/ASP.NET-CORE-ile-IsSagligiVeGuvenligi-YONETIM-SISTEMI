using System;
using System.Collections.Generic;

namespace bitproje.Entitys
{
    public partial class Firmagruplari
    {
        public Firmagruplari()
        {
            Firma = new HashSet<Firma>();
            Kullanici = new HashSet<Kullanici>();
        }

        public int GrupId { get; set; }
        public string GrupAd { get; set; }

        public ICollection<Firma> Firma { get; set; }
        public ICollection<Kullanici> Kullanici { get; set; }
    }
}
