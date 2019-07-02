using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bitproje.Data;
using bitproje.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace bitproje.Controllers
{
    public class BirimController : Controller
    {
        private readonly isgContext _context;

        public BirimController(isgContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null) {
                var Context = _context.Birim.OrderBy(b => b.Birimid);
            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }


       public IActionResult Grupbirim()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
                var firmaa = _context.Firma.Where(b => b.GrupId == bul.GrupId);
                var birim = new List<Birim>();
                foreach (var i in firmaa)
                {
                    var bir = _context.Birim.Where(c => c.Firmaid == i.Firmaid);
                    foreach (var j in bir)
                    {
                        birim.Add(j);
                    }
                }
                return View("Index", birim);
            }
            else
            {
                return NotFound();
            }

        }
        //firma nin giris yaptıgı durumda firmanın birimlerini getirir
        public IActionResult Firmabirim()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var birim = _context.Birim.Where(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaiid"));

                return View("Index", birim);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult kullaniciFirmabirim()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var birim = _context.Birim.Where(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));

            return View("Index", birim);
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
                var birim = await _context.Birim.FirstOrDefaultAsync(m => m .Birimid== id);
            birim.Firma = _context.Firma.FirstOrDefault(h => h.Firmaid == birim.Firmaid);
            birim.SicilnopNavigation = _context.Personel.FirstOrDefault(h => h.Sicilnop == birim.Sicilnop);
            if (birim == null)
            {
                return NotFound();
            }
            return View(birim);
            }
            else
            {
                return NotFound();
            }
        }





        public IActionResult Create()

        {
            var birim = new Birim();
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                var grup = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
                var firmaa = _context.Firma.Where(b => b.GrupId == grup.GrupId);
                ViewBag.birfirma = new List<Firma>(_context.Firma.Where(d => d.GrupId == grup.GrupId));
                var personel = new List<Personel>();
                foreach (var i in firmaa)
                {
                    var bir = _context.Personel.Where(c => c.Firmaid == i.Firmaid);
                    foreach (var j in bir)
                    {

                        personel.Add(j);

                    }
                }

                ViewBag.birpersonel = personel;
            }
            else if(HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmabirimekle")==true.ToString())
            {
                var fir = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaiid"));                
                birim.Firmaid = fir.Firmaid;
                ViewBag.birpersonel = _context.Personel.Where(a=>a.Firmaid==fir.Firmaid);
            }
            else if (HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimbirimekle") == true.ToString())
            {
                var fir = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));
                birim.Firmaid = fir.Firmaid;
                ViewBag.birpersonel = _context.Personel.Where(a => a.Firmaid == fir.Firmaid);
            }
            else if (HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanbirimekle") == true.ToString())
            {
                var fir = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));
                birim.Firmaid = fir.Firmaid;
                ViewBag.birpersonel = _context.Personel.Where(a => a.Firmaid == fir.Firmaid);
            }
            else
            {
                return NotFound();
            }

            return View(birim);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Birimad,Adres,Tehlikesinif,Aciklama,Firmaid,Sicilnop")]
        Birim bir)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bir);
                await _context.SaveChangesAsync();
                if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupbirim)); }
                else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmabirim)); }
                else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmabirim)); }
                else  if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kullaniciFirmabirim)); }
                    
            }
           
            return View(bir);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var birim = await _context.Birim.FindAsync(id);
            if (birim == null)
            {
                return NotFound();
            }
            var firma = _context.Firma.FirstOrDefault(b => b.Firmaid == birim.Firmaid);
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                
                var firmaalar = _context.Firma.Where(b => b.GrupId == firma.GrupId);

                ViewBag.birimfirması = new List<Firma>(_context.Firma.Where(d => d.GrupId == firma.GrupId));

                var personel = new List<Personel>();
                foreach (var i in firmaalar)
                {
                    var bir = _context.Personel.Where(c => c.Firmaid == i.Firmaid);
                    foreach (var j in bir)
                    {

                        personel.Add(j);

                    }
                }

                ViewBag.birimpersonel = personel;
            }
            else if (HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmabirimguncel") == true.ToString())
            {
                ViewBag.birimpersonel = _context.Personel.Where(b => b.Firmaid == firma.Firmaid);

            }
            else if (HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimbirimguncel") == true.ToString())
            {
                ViewBag.birimpersonel = _context.Personel.Where(b => b.Firmaid == firma.Firmaid);

            }
              else if (HttpContext.Session.GetString("grubu") == "D"  && HttpContext.Session.GetString("uzmanbirimguncel") == true.ToString())
            {
                ViewBag.birimpersonel = _context.Personel.Where(b => b.Firmaid == firma.Firmaid);

            }

            else
            {
                return NotFound();
            }

            return View(birim);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Birimid,Birimad,Adres,Tehlikesinif,Aciklama,Firmaid,Sicilnop")] Birim birs)
        {
            if (id != birs.Birimid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(birs);
                    await _context.SaveChangesAsync();
                    if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupbirim)); }
                    else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmabirim)); }
                    else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmabirim)); }
                    else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kullaniciFirmabirim)); }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BirimExists(birs.Birimid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }


            }
            ViewData["Firmaid"] = new SelectList(_context.Firma, "Firmaid", "Firmaid", birs.Firmaid);
            return View(birs);
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var birs = await _context.Birim
                .FirstOrDefaultAsync(m => m.Birimid == id);
                if (birs == null)
                {
                    return NotFound();
                }
                birs.Firma = _context.Firma.FirstOrDefault(h => h.Firmaid == birs.Firmaid);
                birs.SicilnopNavigation = _context.Personel.FirstOrDefault(h => h.Sicilnop == birs.Sicilnop);
                return View(birs);
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
            var birs = _context.Birim.FirstOrDefault(m => m.Birimid == id);
            _context.Birim.Remove(birs);
            await _context.SaveChangesAsync();

            if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupbirim)); }
            else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmabirim)); }
            else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmabirim)); }
            else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kullaniciFirmabirim)); }
            return View();
        }

        private bool    BirimExists(int id)
        {
            return _context.Birim.Any(e => e.Birimid == id);
        }







    }
}