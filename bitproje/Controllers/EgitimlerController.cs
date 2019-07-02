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
    public class EgitimlerController : Controller
    {
        private readonly isgContext _context;

        public EgitimlerController(isgContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var egitim = await _context.Egitimler.OrderBy(b => b.Egitimid).ToListAsync();
                foreach (var item in egitim)
                {
                    item.kullanici = (_context.Kullanici.FirstOrDefault(b => b.Sicilno == item.Sicilno));

                } return View(egitim);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Grupegitim()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var bul =  _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
            var kullanicii =  _context.Kullanici.Where(b => b.Grupid == bul.GrupId);
            var egitim = new List<Egitimler>();
            foreach (var i in kullanicii)  //
            {
                var eg= _context.Egitimler.Where(c => c.Sicilno == i.Sicilno);
                
                foreach (var j in eg)
                {
                    j.kullanici = _context.Kullanici.FirstOrDefault(b=>b.Sicilno==j.Sicilno);
                    egitim.Add(j);

                }
            }            

            return View("Index", egitim);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Firmaegitim()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaid"));
            var kullanicii = _context.Kullanici.Where(b => b.Grupid == bul.GrupId);
            var egitim = new List<Egitimler>();
            foreach (var i in kullanicii)  //
            {
                var eg = _context.Egitimler.Where(c => c.Sicilno == i.Sicilno);

                foreach (var j in eg)
                {
                    j.kullanici = _context.Kullanici.FirstOrDefault(b => b.Sicilno == j.Sicilno);
                    egitim.Add(j);

                }
            }

            return View("Index", egitim);
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult kulFirmaegitim()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var egitim = _context.Egitimler.Where(b => b.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));
            
            foreach (var i in egitim)  //
            {
                i.kullanici = _context.Kullanici.FirstOrDefault(c => c.Sicilno == i.Sicilno);

            }

            return View("Index", egitim);
        }
            else
            {
                return NotFound();
    }
     }


        public IActionResult Create()
        {
            var egitim = new Egitimler();
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
                var kullanici = new List<Kullanici>( _context.Kullanici.Where(b => b.Grupid == bul.GrupId && b.Gorevtanim == "İşyeri Güvenliği Uzmanı"));              
                ViewBag.mkullanici = kullanici;
            }
             else  if (HttpContext.Session.GetString("grubu") == "D")
            {
                var kul = _context.Kullanici.FirstOrDefault(b => b.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));
                egitim.Sicilno = kul.Sicilno;
                egitim.kullanici = kul;
            }
            else
            {
                return NotFound();
            }


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Egitimtrh,Egitimalani,Toplamsure,Aciklama,Egitimkonulari,Sicilno")]
        Egitimler eg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eg);
                await _context.SaveChangesAsync();
                if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupegitim)); }
                else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kulFirmaegitim)); }
            }

            return View(eg);

        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egitim = await _context.Egitimler.FindAsync(id);
            if (egitim == null)
            {
                return NotFound();
            }
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));               
                var kullanici = new List<Kullanici>(_context.Kullanici.Where(b => b.Grupid == bul.GrupId && b.Gorevtanim == "İşyeri Güvenliği Uzmanı"));
                
                ViewBag.mkul = kullanici;
            }
            else if (HttpContext.Session.GetString("grubu") == "D")
            {
                var bul =_context.Kullanici.FirstOrDefault(b => b.Sicilno==egitim.Sicilno);
                egitim.kullanici = bul; 
            }
            else
            {
                return NotFound();
            }

            return View(egitim);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Egitimid,Egitimtrh,Egitimalani,Toplamsure,Aciklama,Egitimkonulari,Sicilno")]
        Egitimler eg)
        {
            if (id != eg.Egitimid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EgitimExists(eg.Egitimid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupegitim)); }
                else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kulFirmaegitim)); }
            }

            return View(eg);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "D")
            {
                var egitim = _context.Egitimler
                .FirstOrDefault(m => m.Egitimid == id);
                egitim.kullanici = _context.Kullanici.FirstOrDefault(b => b.Sicilno == egitim.Sicilno);
                if (egitim == null)
                {
                    return NotFound();
                }
                return View(egitim);
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
            var eg = _context.Egitimler.FirstOrDefault(m => m.Egitimid == id);
            _context.Egitimler.Remove(eg);
            await _context.SaveChangesAsync();
            if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupegitim)); }
            else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kulFirmaegitim)); }
            return View();
        }


        private bool EgitimExists(int id)
        {
            return _context.Muayene.Any(e => e.Mid == id);
        }


    }
}