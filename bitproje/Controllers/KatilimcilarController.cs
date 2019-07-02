using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bitproje.Data;
using bitproje.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bitproje.Controllers
{
    public class KatilimcilarController : Controller
    {
        private readonly isgContext _context;

        public KatilimcilarController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var katilim = _context.Katilimcilar.Where(b => b.Egitimid == id);
            foreach (var item in katilim)
            {
                item.egitim = _context.Egitimler.FirstOrDefault(c => c.Egitimid == item.Egitimid);
                item.personel = _context.Personel.FirstOrDefault(b => b.Sicilnop == item.Sicilnop);
            }
            ViewBag.egitimid = id;
            return View(katilim);

            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Create(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {

                var katilim = new Katilimcilar();
            katilim.Egitimid = id;

            var grup = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
            var firmalar = new List<Firma>(_context.Firma.Where(m => m.GrupId == grup.GrupId));
            var katpersonel = new List<Personel>();
            foreach (var i in firmalar)
            {
                var per = _context.Personel.Where(b => b.Firmaid == i.Firmaid);
                foreach (var j in per )
                {
                    if (_context.Katilimcilar.FirstOrDefault(m => m.Sicilnop == j.Sicilnop && m.Egitimid == id) == null)
                    {
                        katpersonel.Add(j);
                    }
                }
            }

            ViewBag.per = katpersonel;

            return View(katilim);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Egitimid,Sicilnop,Basariyuzdesi")]
        Katilimcilar kat)
        {

            if (ModelState.IsValid)
            {

                _context.Add(kat);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Katilimcilar", new { id = kat.Egitimid });
            }

            return View(kat);

        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var kat = await _context.Katilimcilar
                .FirstOrDefaultAsync(m => m.Katilimid == id);

            if (kat == null)
            {
                return NotFound();
            }
            kat.personel = _context.Personel.FirstOrDefault(d => d.Sicilnop == kat.Sicilnop);
            return View(kat);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var katilim = _context.Katilimcilar.FirstOrDefault(m => m.Katilimid == id);
            _context.Katilimcilar.Remove(katilim);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Katilimcilar", new { id = katilim.Egitimid });
        }

    }
}