using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Birim
    {
        public int Birimid { get; set; }
        
        public string Birimad { get; set; }
        public string Adres { get; set; }
        public string Tehlikesinif { get; set; }
        public string Aciklama { get; set; }
        public int? Firmaid { get; set; }
        public int? Sicilnop { get; set; }

        public Firma Firma { get; set; }
        public Personel SicilnopNavigation { get; set; }
    }
}
