 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje.Entitys
{
    public class Egitimler
    {
        public Egitimler()
        {
            Katilim = new HashSet<Katilimcilar>();
        }
        public int Egitimid { get; set; }
      
        [DataType(DataType.Date)]
        public DateTime? Egitimtrh { get; set; }
        public string Egitimalani { get; set; }
        public int Toplamsure { get; set; }
        public string Aciklama { get; set; }
       
        public string Egitimkonulari { get; set; }
        public int? Sicilno { get; set; }


        public Kullanici kullanici { get; set; }
        public IEnumerable<Katilimcilar> Katilim { get; internal set; }
    }
}
