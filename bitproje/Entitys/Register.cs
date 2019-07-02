using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje.Entitys
{
    public class Register
    {
        public int Id { get; set; }
        public string Kullaniciadi { get; set; }
        public string Sifre { get; set; }
        public string SifreTekrar { get; set; }
        public string renk { get; set; }
        public string soru { get; set; }
        public string cevap { get; set; }
        public int? Firmaid { get; set; }

        public Firma firma { get; set; }

    }
}
