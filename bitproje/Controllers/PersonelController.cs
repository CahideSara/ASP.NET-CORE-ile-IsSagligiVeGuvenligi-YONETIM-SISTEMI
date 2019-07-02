using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bitproje.Data;
using bitproje.Entitys;
using bitproje.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace bitproje.Controllers
{
    public class PersonelController : Controller
    {
        private readonly isgContext _context;

        public PersonelController(isgContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Personel.OrderBy(b => b.Firmaid);
            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Gruppersonel()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
            var firmaa = _context.Firma.Where(b => b.GrupId == bul.GrupId);
            var personel = new List<Personel>();
            foreach (var i in firmaa)
            {
                var per = _context.Personel.Where(c => c.Firmaid == i.Firmaid);
                foreach (var j in per)
                {

                    personel.Add(j);

                }
            }
            
                return View("Index", personel);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Firmapersonel()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var personel = _context.Personel.Where(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaiid"));           

            return View("Index", personel);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult kullaniciFirmapersonel()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var personel = _context.Personel.Where(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));

            return View("Index", personel);
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var personel =await _context.Personel.FirstOrDefaultAsync(m => m.Sicilnop == id);
            personel.Firma = _context.Firma.FirstOrDefault(h => h.Firmaid== personel.Firmaid);
            if (personel == null)
            {
                return NotFound();
            }

            
            return View(personel);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Create()
        { 

            var personel = new Personel();
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                var grup = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
                ViewBag.perfirma = new List<Firma>(_context.Firma.Where(d => d.GrupId == grup.GrupId));
            }
            else if (HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmapersonelekle") == true.ToString())
            {
                var fir = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaiid"));
                personel.Firmaid = fir.Firmaid;
            }
            else if (HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimpersonelekle") == true.ToString())
            {
                var fir = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));
                personel.Firmaid = fir.Firmaid;
            }
            else if (HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanpersonelekle") == true.ToString())
            {
                var fir = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));
                personel.Firmaid = fir.Firmaid;
            }
            else
            {
                return NotFound();
            }

            return View(personel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Sicilnop,Ad,Soyad,Unvan,Ogrenimdurum,Cinsiyet,Boy,Kilo,Isegiristrh,Dogumtarih,Dogumyer,Firmaid")]
        Personel per)
        {
            var sicil = _context.Personel.FirstOrDefault(a => a.Sicilnop == per.Sicilnop);
            if(sicil!=null)
            {
                ViewBag.hata = "BU SİCİL DE BİR PERSONEL BULUNMAKTA";
            }
            else { 
            if (ModelState.IsValid)
            {
                _context.Add(per);
                await _context.SaveChangesAsync();
                if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Gruppersonel)); }
                else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmapersonel)); }
                else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmapersonel)); }
                else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kullaniciFirmapersonel)); }
            }
            ViewData["Firmaid"] = new SelectList(_context.Firma, "Firmaid", "Firmaid");
            }
            return View(per);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _context.Personel.FindAsync(id);
            if (personel == null)
            {
                return NotFound();
            }
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                var firma = _context.Firma.FirstOrDefault(b => b.Firmaid == personel.Firmaid);
                ViewBag.firması = new List<Firma>(_context.Firma.Where(d => d.GrupId == firma.GrupId));
            }
            else if (HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmapersonelguncel") == true.ToString() ||
              HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimpersonelguncel") == true.ToString() ||
               HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanpersonelguncel") == true.ToString())
            {

            }
            else
            {
                return NotFound();
            }
            
            return View(personel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Sicilnop,Ad,Soyad,Unvan,Ogrenimdurum,Cinsiyet,Boy,Kilo,Isegiristrh,Dogumtarih,Dogumyer,Firmaid")] Personel pers)
        {
            if (id != pers.Sicilnop)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pers);
                    await _context.SaveChangesAsync();
                    if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Gruppersonel)); }
                    else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmapersonel)); }
                    else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmapersonel)); }
                    else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kullaniciFirmapersonel)); }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonelExists(pers.Sicilnop))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                
            }
            ViewData["Firmaid"] = new SelectList(_context.Firma, "Firmaid", "Firmaid", pers.Firmaid);
            return View(pers);
        }




        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmapersonelsil") == true.ToString() ||
                HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimpersonelsil") == true.ToString() ||
                 HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanpersonelsil") == true.ToString())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var pers = await _context.Personel
                    .FirstOrDefaultAsync(m => m.Sicilnop == id);
                if (pers == null)
                {
                    return NotFound();
                }
                pers.Firma = _context.Firma.FirstOrDefault(h => h.Firmaid == pers.Firmaid);

                return View(pers);
            }
            else { return NotFound(); }
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pers = _context.Personel.FirstOrDefault(m => m.Sicilnop == id);
            _context.Personel.Remove(pers);
            await _context.SaveChangesAsync();
            if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Gruppersonel)); }
            else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmapersonel)); }
            else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmapersonel)); }
            else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kullaniciFirmapersonel)); }
            return View();
        }



        private bool PersonelExists(int id)
        {
            return _context.Personel.Any(e => e.Sicilnop == id);
        }


    }
}