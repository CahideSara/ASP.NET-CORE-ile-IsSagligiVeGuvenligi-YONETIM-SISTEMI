using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje.Entitys
{
    public class Users
    {
        public int Id { get; set; }
        
        public string Kullaniciadi { get; set; }
        
        public string Sifre { get; set; }
        
        public  int? Firmaid { get; set; }
        public int? Sicilno { get; set; }
        public string Grubu { get; set; }
        
        public string renk { get; set; }
        
        public string soru { get; set; }
        
        public string cevap { get; set; }

        public Firma firma { get; set; }
        public Kullanici sicil { get; set; }
    }
}
