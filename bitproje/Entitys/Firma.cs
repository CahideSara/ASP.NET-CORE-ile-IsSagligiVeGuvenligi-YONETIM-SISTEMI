using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Firma
    {
        public Firma()
        {
            Birim = new HashSet<Birim>();
            Personel = new HashSet<Personel>();
            Users = new HashSet<Users>();
            KullaniciFirma = new HashSet<KullaniciFirma>();

        }

        public int Firmaid { get; set; }
      
        public string Funvan { get; set; }
      
        public string Isvrnadsoyad { get; set; }
       
        public string Isvrngsm { get; set; }
       
        public string Firmatlfn { get; set; }
        
        public string Faks { get; set; }
       
        [EmailAddress]
        public string Firmamail { get; set; }
       
        public string Il { get; set; }
      
        public string Ilce { get; set; }
        
        public string Adres { get; set; }
       
        public string Faaliyetalan { get; set; }
        
        public string Sgksicil { get; set; }
       
        public string Tehlikesinif { get; set; }
       
        public string Grupsirket { get; set; }
        
        public string Durum { get; set; }
       
        public int? GrupId { get; set; }

        public Firmagruplari Grup { get; set; }
        public ICollection<Birim> Birim { get; set; }
        public ICollection<Personel> Personel { get; set; }
        public ICollection<Users> Users { get; set; }
        public ICollection<KullaniciFirma> KullaniciFirma { get; internal set; }
    }
}
