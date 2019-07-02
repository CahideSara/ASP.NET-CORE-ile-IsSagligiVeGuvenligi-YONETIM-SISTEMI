using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje.Entitys
{
    public class KullaniciFirma
    {
        public KullaniciFirma()
        {
        }
        public int Id { get; set; }
        public int? Sicilno { get; set; }
        public int? Firmaid { get; set; }

        public Firma Firma { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
