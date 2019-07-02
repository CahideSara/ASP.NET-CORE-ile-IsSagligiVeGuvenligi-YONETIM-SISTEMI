using System;
using System.Collections.Generic;

namespace bitproje.Entitys
{
    public partial class Receteilac
    {
        public int Rilacid { get; set; }
        public int? Rid { get; set; }
        public int? Ilacid { get; set; }
        public int? Kullanimadedi { get; set; }
        public string Kullanimsekli { get; set; }
        public string Periyod { get; set; }
        public string Ilacdozu { get; set; }

        public Ilactanimi Ilac { get; set; }
        public Recete R { get; set; }
    }
}
