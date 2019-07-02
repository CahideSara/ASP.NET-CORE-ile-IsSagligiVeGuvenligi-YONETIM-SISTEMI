using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bitproje.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitproje.Controllers
{
    public class KullanicifirmaController : Controller
    {
        private isgContext _context { get; set; }

        public KullanicifirmaController(isgContext context)
        {
            _context = context;
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int sicil, int firmaid)
        {

            var kulfirma = _context.KullaniciFirma.FirstOrDefault(m => m.Firmaid == firmaid && m.Sicilno == sicil);
            _context.KullaniciFirma.Remove(kulfirma);
            await _context.SaveChangesAsync();
            return View();
        }

        public IActionResult kulFirmaDegis()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var kulfirma = _context.KullaniciFirma.Where(s => s.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));
            foreach (var i in kulfirma)
            {
                i.Firma = _context.Firma.FirstOrDefault(m => m.Firmaid == i.Firmaid);
                i.Kullanici = _context.Kullanici.FirstOrDefault(m => m.Sicilno == i.Sicilno);

            }

            return View(kulfirma.ToList());
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Detayi(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var firma = _context.Firma.FirstOrDefault(b => b.Firmaid == id);
            HttpContext.Session.SetString("kfirmaad", firma.Funvan);
            HttpContext.Session.SetString("kfirmaid", firma.Firmaid.ToString());
            ViewBag.percount = _context.Personel.Count(b => b.Firmaid == id);
            ViewBag.birimcount = _context.Birim.Count(b => b.Firmaid == firma.Firmaid);

            var personel = _context.Personel.Where(c => c.Firmaid == firma.Firmaid);
            int top = 0;
            foreach (var i in personel) //muayene olan personel listesini buluyor o firmaya ait
            {
                top = top + _context.Muayene.Count(c => c.Sicilnop == i.Sicilnop && c.Sicilno.ToString()== HttpContext.Session.GetString("sicilno"));

            }
            ViewBag.muayenecount = top;
            return View(firma);
            }
            else
            {
                return NotFound();
            }
        }

    }
}