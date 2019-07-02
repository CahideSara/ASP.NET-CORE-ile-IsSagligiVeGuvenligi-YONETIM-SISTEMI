using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitproje.Entitys
{
    public partial class Ilactanimi
    {
        public Ilactanimi()
        {
            Receteilac = new HashSet<Receteilac>();
        }

        public int Ilacid { get; set; }
        
        public string Ilacadi { get; set; }

        public ICollection<Receteilac> Receteilac { get; set; }
    }
}
