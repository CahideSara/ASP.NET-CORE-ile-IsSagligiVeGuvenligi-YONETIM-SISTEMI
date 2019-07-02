using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Personel
    {
        public Personel()
        {
            Birim = new HashSet<Birim>();
            Muayene = new HashSet<Muayene>();
            Katilim = new HashSet<Katilimcilar>();
        }

        public int Sicilnop { get; set; }
       
        public string Ad { get; set; }
    
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public string Ogrenimdurum { get; set; }
        public string Cinsiyet { get; set; }
        public double? Boy { get; set; }
        public double? Kilo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Isegiristrh { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Dogumtarih { get; set; }
        public string Dogumyer { get; set; }
        public int? Firmaid { get; set; }

        public Firma Firma { get; set; }
        public ICollection<Birim> Birim { get; set; }
        public ICollection<Muayene> Muayene { get; set; }
        public IEnumerable<Katilimcilar> Katilim { get; internal set; }
    }
}
