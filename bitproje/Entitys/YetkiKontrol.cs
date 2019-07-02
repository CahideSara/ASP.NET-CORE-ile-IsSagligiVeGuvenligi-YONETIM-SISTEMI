using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje.Entitys
{
    public class YetkiKontrol
    {
        public int Id { get; set; }
        //firma yetki kontrolunun yapıldıgı bölüm baslangıc
        public Boolean firmafirmaekle { get; set; }
        public Boolean firmafirmasil { get; set; }
        public Boolean firmafirmaguncel { get; set; }

        public Boolean firmabirimekle { get; set; }
        public Boolean firmabirimsil { get; set; }
        public Boolean firmabirimguncel { get; set; }

        public Boolean firmapersonelekle { get; set; }
        public Boolean firmapersonelsil { get; set; }
        public Boolean firmapersonelguncel { get; set; }
        

        public Boolean firmailacekle { get; set; }
        public Boolean firmailaccsil { get; set; }

        public Boolean firmataniekle { get; set; }
        public Boolean firmatanisil { get; set; }

        public Boolean firmastatuekle { get; set; }
        public Boolean firmastatusil { get; set; }

        //firma yetki kontrolunun yapıldıgı bölüm bitiş

        //hekim yetki kontrolunun yapıldıgı bölüm baslangıc
        public Boolean hekimfirmaekle { get; set; }
        public Boolean hekimfirmasil { get; set; }
        public Boolean hekimfirmaguncel { get; set; }


        public Boolean hekimbirimekle { get; set; }
        public Boolean hekimbirimsil { get; set; }
        public Boolean hekimbirimguncel { get; set; }


        public Boolean hekimpersonelekle { get; set; }
        public Boolean hekimpersonelsil { get; set; }
        public Boolean hekimpersonelguncel { get; set; }

        public Boolean hekimilacekle { get; set; }
        public Boolean hekimilacsil { get; set; }


        public Boolean hekimtaniekle { get; set; }
        public Boolean hekimtanisil { get; set; }

        public Boolean hekimstatuekle { get; set; }
        public Boolean hekimstatusil { get; set; }

        //hekim yetki kontrolunun yapıldıgı bölüm bitiş

        //uzman yetki kontrolunun yapıldıgı bölüm baslangıc
        public Boolean uzmanfirmaekle { get; set; }
        public Boolean uzmanfirmasil { get; set; }
        public Boolean uzmanfirmaguncel { get; set; }


        public Boolean uzmanbirimekle { get; set; }
        public Boolean uzmanbirimsil { get; set; }
        public Boolean uzmanbirimguncel { get; set; }


        public Boolean uzmanpersonelekle { get; set; }
        public Boolean uzmanpersonelsil { get; set; }
        public Boolean uzmanpersonelguncel { get; set; }


        public Boolean uzmanilacekle { get; set; }
        public Boolean uzmanilacsil { get; set; }

        public Boolean uzmantaniekle { get; set; }
        public Boolean uzmantanisil { get; set; }

        public Boolean uzmanstatuekle { get; set; }
        public Boolean uzmanstatusil { get; set; }

        //firma yetki kontrolunun yapıldıgı bölüm bitiş
    }
}
