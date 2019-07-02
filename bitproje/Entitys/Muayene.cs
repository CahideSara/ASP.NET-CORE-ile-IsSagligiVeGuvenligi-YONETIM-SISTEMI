using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Muayene
    {
        public Muayene()
        {
            Recete = new HashSet<Recete>();
            Tanilar = new HashSet<Tanilar>();
        }

        public int Mid { get; set; }
        
        public string Mneden { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Mtarihi { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Sonrakimtarih { get; set; }
        public string Annehastalikg { get; set; }
        public string Babahastalikg { get; set; }
        public string Cocukhastalikg { get; set; }
        public string Kardeshastalikg { get; set; }
        public int? Büyüktan { get; set; }
        public int? Kücüktan { get; set; }
        public int? Nabiz { get; set; }
        public double? Kilo { get; set; }
        public double? Boy { get; set; }
        public string Kangrup { get; set; }
        public int? Sicilno { get; set; }
        public int? Sicilnop { get; set; }

        public Kullanici SicilnoNavigation { get; set; }
        public Personel SicilnopNavigation { get; set; }
        public ICollection<Recete> Recete { get; set; }
        public ICollection<Tanilar> Tanilar { get; set; }
    }
}
