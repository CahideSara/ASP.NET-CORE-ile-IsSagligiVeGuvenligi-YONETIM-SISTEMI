using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje.Entitys
{
    public class Katilimcilar
    {

        public Katilimcilar()
        {

        }

        public int Katilimid { get; set; }
        
        public string Basariyuzdesi { get; set; }
        public int? Egitimid { get; set; }
        public int? Sicilnop { get; set; }


        public Egitimler egitim { get; set; }
        public Personel personel { get; set; }
    }
}
