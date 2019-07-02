using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bitproje.Data;
using bitproje.Entitys;
using bitproje.Models;
using bitproje.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace bitproje.Controllers
{
    public class FirmaController : Controller
    {
        private readonly isgContext _context;

        public FirmaController(isgContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {

                var Context =_context.Firma.OrderBy(b=>b.Firmaid);
            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Grupfirma()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
            var firmalar = _context.Firma.Where(b => b.GrupId==bul.GrupId);

            return View("Index",firmalar);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Firmafirma()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaid"));
            var firmalar = _context.Firma.Where(b => b.GrupId == bul.GrupId);
            return View("Index", firmalar);
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult KulFirma()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var kullanici =  _context.Kullanici.FirstOrDefault(m => m.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));
            var firmalar = _context.Firma.Where(b => b.GrupId == kullanici.Grupid);
            return View("Index", firmalar);
            }
            else
            {
                return NotFound();
            }
        }


        public IActionResult Degis()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var grup = _context.Firma.FirstOrDefault(s => s.Firmaid.ToString() == HttpContext.Session.GetString("firmaid"));
            var Context = _context.Firma.Where(b => b.GrupId==grup.GrupId);

            return View(Context.ToList());
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
            HttpContext.Session.SetString("firmaad", firma.Funvan);
            HttpContext.Session.SetString("firmaiid", firma.Firmaid.ToString());
            ViewBag.percount = _context.Personel.Count(b => b.Firmaid == id);
            ViewBag.birimcount = _context.Birim.Count(b => b.Firmaid == firma.Firmaid);

            var personel = _context.Personel.Where(c => c.Firmaid == firma.Firmaid);
            int top = 0;
            foreach (var i in personel) //muayene olan personel listesini buluyor o firmaya ait
            {
                top =top + _context.Muayene.Count(c => c.Sicilnop == i.Sicilnop);
              
            }
            ViewBag.muayenecount = top;
            return View(firma);
           }
            else
            {
                return NotFound();
            }
             }

        public IActionResult AIndex(int id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {

                var Context = _context.Firma.OrderBy(b => b.Firmaid).Where(s => s.GrupId == id);
                return View(Context.ToList());

            }
            else
            {
                return NotFound();
            }

        }

        public async Task<IActionResult> Profil()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {

                if (HttpContext.Session.GetString("firmaid") == null)
            {
                return NotFound();
            }

            var firma = await _context.Firma.FirstOrDefaultAsync(m => m.Firmaid.ToString() == HttpContext.Session.GetString("firmaid"));
            // String a = _context.Firmagruplari.FirstOrDefault(d => d.GrupId == firma.GrupId).GrupAd;

            firma.Grup = _context.Firmagruplari.FirstOrDefault(h => h.GrupId == firma.GrupId);
            //ViewBag.a = _context.Firmagruplari.FirstOrDefaultAsync(d => d.GrupId == firma.GrupId);
            if (firma == null)
            {
                return NotFound();
            }

            return View(firma);
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> ProfilEdit(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var firma = await _context.Firma.FindAsync(id);
            if (firma == null)
            {
                return NotFound();
            }
            
            return View(firma);
           }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ProfilEdit(int id, [Bind("Firmaid,Funvan,Isvrnadsoyad,Isvrngsm,Firmatlfn,Faks,Firmamail,Il,Ilce,Adres,Faaliyetalan,Sgksicil,Tehlikesinif,Grupsirket")] Firma firma)
        {
            if (id != firma.Firmaid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    baglantiSinifi bs = new baglantiSinifi();
                    string sorgu = "update firma set funvan='" + firma.Funvan + "',isvrnadsoyad='" + firma.Isvrnadsoyad + "',isvrngsm='" + firma.Isvrngsm + "',firmatlfn='" + firma.Firmatlfn + "',faks='" + firma.Faks + "',firmamail='" + firma.Firmamail + "',il='" + firma.Il + "',ilce='" + firma.Ilce + "',adres='" + firma.Adres + "',faaliyetalan='" + firma.Faaliyetalan + "',sgksicil='" + firma.Sgksicil + "',tehlikesinif='" + firma.Tehlikesinif + "',grupsirket='" + firma.Grupsirket + "' where firmaid=" + id;
                    bs.baglanti("güncelle", sorgu);
                    ViewBag.sonuc = "FİRMA Eklendi";
                    return RedirectToAction(nameof(Profil));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FirmaExists(firma.Firmaid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }


            }
            ViewData["GrupId"] = new SelectList(_context.Firmagruplari, "GrupId", "GrupId", firma.GrupId);
            return View(firma);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var firma = await _context.Firma.FirstOrDefaultAsync(m => m.Firmaid == id);
           // String a = _context.Firmagruplari.FirstOrDefault(d => d.GrupId == firma.GrupId).GrupAd;

            firma.Grup=_context.Firmagruplari.FirstOrDefault(h=>h.GrupId==firma.GrupId);
            //ViewBag.a = _context.Firmagruplari.FirstOrDefaultAsync(d => d.GrupId == firma.GrupId);
            Console.WriteLine("olmadııııııııııııııııııııııııııııııııııııııııııııııı"+ViewBag.Grupu);
            if (firma == null)
            {
                return NotFound();
            }

            return View(firma);
            }
            else
            {
                return NotFound();
            }
        }
         public IActionResult Create()
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmafirmaekle") == true.ToString() || HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimfirmaekle") == true.ToString()
                || HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanfirmaekle") == true.ToString())
            {
                ViewBag.Gruplar = new List<Firma>(_context.Firma.Where(a => a.Durum == "Ana Firma"));

                return View();
            }           
            else
            {
                return NotFound();
            }
            

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Funvan,Isvrnadsoyad,Isvrngsm,Firmatlfn,Faks,Firmamail,Il,Ilce,Adres,Faaliyetalan,Sgksicil,Tehlikesinif,Grupsirket,GrupId")]
        Firma fir)
        {
            if (ModelState.IsValid)
            {
                if (HttpContext.Session.GetString("grubu") == "A")
                {
                    var grupf = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));

                    baglantiSinifi bs = new baglantiSinifi();
                    string sorgu = "insert into firma(funvan,isvrnadsoyad,isvrngsm,firmatlfn,faks,firmamail,il,ilce,adres,faaliyetalan,sgksicil,tehlikesinif,grupsirket,durum,grup_id) values" +
                        "('" + fir.Funvan + "','" + fir.Isvrnadsoyad + "','" + fir.Isvrngsm + "','" + fir.Firmatlfn + "','" + fir.Faks + "','" + fir.Firmamail + "','" + fir.Il + "','" + fir.Ilce + "','" + fir.Adres + "','" + fir.Faaliyetalan + "','" + fir.Sgksicil + "','" + fir.Tehlikesinif + "','" + fir.Grupsirket + "','FİRMA','" + grupf.GrupId + "')";
                    bs.baglanti("ekleme", sorgu);
                    ViewBag.sonuc = "FİRMA Eklendi";
                    return RedirectToAction(nameof(Grupfirma));

                }
                else  if (HttpContext.Session.GetString("grubu") == "B")
                {
                    var grupf = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaid"));

                    baglantiSinifi bs = new baglantiSinifi();
                    string sorgu = "insert into firma(funvan,isvrnadsoyad,isvrngsm,firmatlfn,faks,firmamail,il,ilce,adres,faaliyetalan,sgksicil,tehlikesinif,grupsirket,durum,grup_id) values" +
                        "('" + fir.Funvan + "','" + fir.Isvrnadsoyad + "','" + fir.Isvrngsm + "','" + fir.Firmatlfn + "','" + fir.Faks + "','" + fir.Firmamail + "','" + fir.Il + "','" + fir.Ilce + "','" + fir.Adres + "','" + fir.Faaliyetalan + "','" + fir.Sgksicil + "','" + fir.Tehlikesinif + "','" + fir.Grupsirket + "','FİRMA','" + grupf.GrupId + "')";
                    bs.baglanti("ekleme", sorgu);
                    ViewBag.sonuc = "FİRMA Eklendi";
                    return RedirectToAction(nameof(Firmafirma));

                }
                else if (HttpContext.Session.GetString("grubu") == "C")
                {
                    var grupf = _context.Kullanici.FirstOrDefault(b => b.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));

                    baglantiSinifi bs = new baglantiSinifi();
                    string sorgu = "insert into firma(funvan,isvrnadsoyad,isvrngsm,firmatlfn,faks,firmamail,il,ilce,adres,faaliyetalan,sgksicil,tehlikesinif,grupsirket,durum,grup_id) values" +
                        "('" + fir.Funvan + "','" + fir.Isvrnadsoyad + "','" + fir.Isvrngsm + "','" + fir.Firmatlfn + "','" + fir.Faks + "','" + fir.Firmamail + "','" + fir.Il + "','" + fir.Ilce + "','" + fir.Adres + "','" + fir.Faaliyetalan + "','" + fir.Sgksicil + "','" + fir.Tehlikesinif + "','" + fir.Grupsirket + "','FİRMA','" + grupf.Grupid + "')";
                    bs.baglanti("ekleme", sorgu);
                    ViewBag.sonuc = "FİRMA Eklendi";
                    return RedirectToAction(nameof(KulFirma));

                }
                else if (HttpContext.Session.GetString("grubu") == "D")
                {
                    var grupf = _context.Kullanici.FirstOrDefault(b => b.Sicilno.ToString() == HttpContext.Session.GetString("firmaid"));

                    baglantiSinifi bs = new baglantiSinifi();
                    string sorgu = "insert into firma(funvan,isvrnadsoyad,isvrngsm,firmatlfn,faks,firmamail,il,ilce,adres,faaliyetalan,sgksicil,tehlikesinif,grupsirket,durum,grup_id) values" +
                        "('" + fir.Funvan + "','" + fir.Isvrnadsoyad + "','" + fir.Isvrngsm + "','" + fir.Firmatlfn + "','" + fir.Faks + "','" + fir.Firmamail + "','" + fir.Il + "','" + fir.Ilce + "','" + fir.Adres + "','" + fir.Faaliyetalan + "','" + fir.Sgksicil + "','" + fir.Tehlikesinif + "','" + fir.Grupsirket + "','FİRMA','" + grupf.Grupid + "')";
                    bs.baglanti("ekleme", sorgu);
                    ViewBag.sonuc = "FİRMA Eklendi";
                    return RedirectToAction(nameof(KulFirma));

                }

            }
           
            return View(fir);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmafirmaekle") == true.ToString() || HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimfirmaekle") == true.ToString()
                || HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanfirmaekle") == true.ToString())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var firma = await _context.Firma.FindAsync(id);
                if (firma == null)
                {
                    return NotFound();
                }
                ViewBag.Gruplar = new List<Firma>(_context.Firma.Where(a => a.Durum == "Ana Firma"));
                return View(firma);
            }
            else
            {
                return NotFound();
            }
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Firmaid,Funvan,Isvrnadsoyad,Isvrngsm,Firmatlfn,Faks,Firmamail,Il,Ilce,Adres,Faaliyetalan,Sgksicil,Tehlikesinif,Grupsirket,GrupId")] Firma firma)
        {
            if (id != firma.Firmaid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    baglantiSinifi bs = new baglantiSinifi();
                    if (HttpContext.Session.GetString("grubu") == "A")
                    {
                        string sorgu = "update firma set funvan='" + firma.Funvan + "',isvrnadsoyad='" + firma.Isvrnadsoyad + "',isvrngsm='" + firma.Isvrngsm + "',firmatlfn='" + firma.Firmatlfn + "',faks='" + firma.Faks + "',firmamail='" + firma.Firmamail + "',il='" + firma.Il + "',ilce='" + firma.Ilce + "',adres='" + firma.Adres + "',faaliyetalan='" + firma.Faaliyetalan + "',sgksicil='" + firma.Sgksicil + "',tehlikesinif='" + firma.Tehlikesinif + "',grupsirket='" + firma.Grupsirket + "',grup_id='" + firma.GrupId + "' where firmaid=" + id;
                        bs.baglanti("güncelle", sorgu);
                        ViewBag.sonuc = "FİRMA Eklendi";
                        return RedirectToAction(nameof(Grupfirma));
                    }
                    else if (HttpContext.Session.GetString("grubu") == "B")
                    {
                        string sorgu = "update firma set funvan='" + firma.Funvan + "',isvrnadsoyad='" + firma.Isvrnadsoyad + "',isvrngsm='" + firma.Isvrngsm + "',firmatlfn='" + firma.Firmatlfn + "',faks='" + firma.Faks + "',firmamail='" + firma.Firmamail + "',il='" + firma.Il + "',ilce='" + firma.Ilce + "',adres='" + firma.Adres + "',faaliyetalan='" + firma.Faaliyetalan + "',sgksicil='" + firma.Sgksicil + "',tehlikesinif='" + firma.Tehlikesinif + "',grupsirket='" + firma.Grupsirket + "',grup_id='" + firma.GrupId + "' where firmaid=" + id;
                        bs.baglanti("güncelle", sorgu);
                        ViewBag.sonuc = "FİRMA Eklendi";
                        return RedirectToAction(nameof(Firmafirma));
                    }
                    else if (HttpContext.Session.GetString("grubu") == "C")
                    {
                        string sorgu = "update firma set funvan='" + firma.Funvan + "',isvrnadsoyad='" + firma.Isvrnadsoyad + "',isvrngsm='" + firma.Isvrngsm + "',firmatlfn='" + firma.Firmatlfn + "',faks='" + firma.Faks + "',firmamail='" + firma.Firmamail + "',il='" + firma.Il + "',ilce='" + firma.Ilce + "',adres='" + firma.Adres + "',faaliyetalan='" + firma.Faaliyetalan + "',sgksicil='" + firma.Sgksicil + "',tehlikesinif='" + firma.Tehlikesinif + "',grupsirket='" + firma.Grupsirket + "',grup_id='" + firma.GrupId + "' where firmaid=" + id;
                        bs.baglanti("güncelle", sorgu);
                        ViewBag.sonuc = "FİRMA Eklendi";
                        return RedirectToAction(nameof(KulFirma));
                    }
                    else if (HttpContext.Session.GetString("grubu") == "D")
                    {
                        string sorgu = "update firma set funvan='" + firma.Funvan + "',isvrnadsoyad='" + firma.Isvrnadsoyad + "',isvrngsm='" + firma.Isvrngsm + "',firmatlfn='" + firma.Firmatlfn + "',faks='" + firma.Faks + "',firmamail='" + firma.Firmamail + "',il='" + firma.Il + "',ilce='" + firma.Ilce + "',adres='" + firma.Adres + "',faaliyetalan='" + firma.Faaliyetalan + "',sgksicil='" + firma.Sgksicil + "',tehlikesinif='" + firma.Tehlikesinif + "',grupsirket='" + firma.Grupsirket + "',grup_id='" + firma.GrupId + "' where firmaid=" + id;
                        bs.baglanti("güncelle", sorgu);
                        ViewBag.sonuc = "FİRMA Eklendi";
                        return RedirectToAction(nameof(KulFirma));
                    }


                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FirmaExists(firma.Firmaid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                

            }
            ViewData["GrupId"] = new SelectList(_context.Firmagruplari, "GrupId", "GrupId", firma.GrupId);
            return View(firma);
        }

        public IActionResult Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var firma = _context.Firma.FirstOrDefault(m => m.Firmaid == id);
            if (firma == null)
            {
                return NotFound();
            }

            return View(firma);
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
            var firma = _context.Firma.FirstOrDefault(m => m.Firmaid == id);
            _context.Firma.Remove(firma);
            await _context.SaveChangesAsync();
            if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupfirma)); }
            else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmafirma)); }
            else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(KulFirma)); }
            else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(KulFirma)); }
            return View();
        }



        private bool FirmaExists(int id)
        {
            return _context.Firma.Any(e => e.Firmaid == id);
        }

    }
}    
