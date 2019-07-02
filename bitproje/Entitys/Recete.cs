using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Recete
    {
        public Recete()
        {
            Receteilac = new HashSet<Receteilac>();
        }

        public int Rid { get; set; }
        public int? Mid { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Rtarihi { get; set; }
        public string Rtipi { get; set; }
        public string Ralttipi { get; set; }
        public string Provizyontipi { get; set; }
        public string Serino { get; set; }

        public Muayene M { get; set; }
        public ICollection<Receteilac> Receteilac { get; set; }
    }
}
