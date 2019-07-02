using bitproje.Data;
using bitproje.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje
{
    public class PartialDemoModel : PageModel
    {
        public Firma firma = new Firma();
        private readonly isgContext _context;
        
        public PartialDemoModel(isgContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
           
            if (HttpContext.Session.GetString("grubu") == "B")
            {
                var fir = _context.Firma.FirstOrDefault(m => m.Firmaid.ToString() == HttpContext.Session.GetString("firmaid"));
                firma = fir;
            }
            else if (HttpContext.Session.GetString("grubu") == "C" || HttpContext.Session.GetString("grubu") == "D")
            {
               
            }


        }

    }
}
