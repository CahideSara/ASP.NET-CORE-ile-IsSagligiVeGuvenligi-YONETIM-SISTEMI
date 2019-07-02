using System;
using System.Collections.Generic;

namespace bitproje.Entitys
{
    public partial class Tanilar
    {
        public int Taniid { get; set; }
        public int? Tanimid { get; set; }
        public int? Mid { get; set; }

        public Muayene M { get; set; }
        public Tanitanimi Tanim { get; set; }
    }
}
