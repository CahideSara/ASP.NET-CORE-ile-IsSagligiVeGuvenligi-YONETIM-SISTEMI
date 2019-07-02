using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Kullanici
    {
        

        public Kullanici()
        {
            Muayene = new HashSet<Muayene>();
            Users = new HashSet<Users>();
            KullaniciFirma = new HashSet<KullaniciFirma>();
            Egitim = new HashSet<Egitimler>();

        }
       
        public int Sicilno { get; set; }
        public string Gorevtanim { get; set; }
       
        public string Tc { get; set; }
   
        public string Ad { get; set; }
       
        public string Soyad { get; set; }
        public string Durum { get; set; }
        public double? Boy { get; set; }
        public double? Kilo { get; set; }

        internal int FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public string Kangrup { get; set; }
        public string Cinsiyet { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Dogumtarih { get; set; }
        public string Dogumyer { get; set; }
        public string Statü { get; set; }
        public string Ogrenimdurum { get; set; }
        public string Isgkurulgorev { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Isebaslangictarih { get; set; }
        public string Unvan { get; set; }
        public int Grupid { get; set; }

        public Firmagruplari Grup { get; set; }

        public ICollection<Muayene> Muayene { get; set; }
        public ICollection<Users> Users { get; set; }
        public IEnumerable<Egitimler> Egitim { get; internal set; }

        public ICollection<KullaniciFirma> KullaniciFirma;
    }
}
