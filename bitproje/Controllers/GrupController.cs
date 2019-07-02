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
    public class GrupController : Controller
    {
        private readonly isgContext _context;

        public GrupController(isgContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Firma.Where(b => b.Durum.Equals("ANA FİRMA"));

            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Yönetim()
        {
            if (HttpContext.Session.GetString("grubu") =="A")
            {
                var Context = _context.Users.OrderBy(b=>b.Id);

            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }


        public IActionResult Detayi(int? id)
        {
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                var firma = _context.Firma.FirstOrDefault(b => b.Firmaid == id);
                HttpContext.Session.SetString("firmagrubuad", firma.Funvan);
                HttpContext.Session.SetString("firmagrubuid", firma.Firmaid.ToString());



                ViewBag.firmacount = _context.Firma.Count(b => b.GrupId == firma.GrupId);
                ViewBag.kullanicicount = _context.Kullanici.Count(b => b.Grupid == firma.GrupId);
                var firmaa = _context.Firma.Where(b => b.GrupId == firma.GrupId);
                //FİRMA GRUBUNA GÖRE FİRMANIN PERSONEL SAYISINI HESAPLAR
                int top = 0;
                foreach (var i in firmaa)
                {
                    top = top + _context.Personel.Count(b => b.Firmaid == i.Firmaid);

                }
                ViewBag.personelcount = top;

                //FİRMA GRUBUNA GÖRE FİRMANIN BİRİMLERİNİN SAYISINI HESAPLAR
                int topbirim = 0;
                foreach (var i in firmaa)
                {
                    topbirim = topbirim + _context.Birim.Count(b => b.Firmaid == i.Firmaid);

                }
                ViewBag.birimcount = topbirim;

                //FİRMA GRUBUNA GÖRE FİRMANIN muayene  SAYISINI HESAPLAR
                int topmuayene = 0;
                foreach (var i in firmaa)
                {
                    var personell = _context.Personel.Where(b => b.Firmaid == i.Firmaid);
                    foreach (var j in personell)
                    {
                        topmuayene = topmuayene + _context.Muayene.Count(b => b.Sicilnop == j.Sicilnop);


                    }

                }
                ViewBag.muayenecount = topmuayene;
                int topegitim = 0;
                var kul = _context.Kullanici.Where(b => b.Grupid == firma.GrupId);
                foreach (var i in kul)
                {
                    topegitim = topegitim + _context.Egitimler.Count(b => b.Sicilno == i.Sicilno);

                }
                ViewBag.egitimcount = topegitim;

                return View(firma);
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

                var Context = _context.Firma.Where(b => b.Durum.Equals("ANA FİRMA"));

            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {

                return View();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Funvan,Isvrnadsoyad,Isvrngsm,Firmatlfn,Faks,Firmamail,Il,Ilce,Adres,Faaliyetalan,Sgksicil,Tehlikesinif,Grupsirket")]
        Firma fir)
        {
            if (ModelState.IsValid)
            {

                baglantiSinifi bs = new baglantiSinifi();
                string sorgu="insert into firmagruplari(grup_ad) values('"+fir.Funvan+"')";
                bs.baglanti("ekleme", sorgu);
                int a=bs.baglanti("bulgrubu", "");
                string sorgu1 = "insert into firma(funvan,isvrnadsoyad,isvrngsm,firmatlfn,faks,firmamail,il,ilce,adres,faaliyetalan,sgksicil,tehlikesinif,grupsirket,durum,grup_id) values" +
                    "('" + fir.Funvan + "','" + fir.Isvrnadsoyad + "','" + fir.Isvrngsm + "','" + fir.Firmatlfn + "','" + fir.Faks + "','" + fir.Firmamail + "','" + fir.Il + "','" + fir.Ilce + "','" + fir.Adres + "','" + fir.Faaliyetalan + "','" + fir.Sgksicil + "','" + fir.Tehlikesinif + "','" + fir.Grupsirket + "','ANA FİRMA','" + a + "')";
                bs.baglanti("ekleme", sorgu1);

                 a = bs.baglanti("bulfirma", "");
                var user = new Users
                {
                    Kullaniciadi = fir.Firmamail,
                    Sifre = "sıfırIsgm",
                    Firmaid = a,
                    Grubu = "B"
                };
                _context.Add(user);
                await _context.SaveChangesAsync();
                ViewBag.sonuc = "FİRMA Eklendi";
                return RedirectToAction(nameof(Index));
            }
           
            return View(fir);
        }





        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var fir = _context.Firma
                .FirstOrDefaultAsync(m => m.Firmaid == id);
            if (fir == null)
            {
                return NotFound();
            }

            return View(await fir);
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
            var fir = _context.Firma.FirstOrDefault(m => m.Firmaid == id);
            var grup = _context.Firmagruplari.FirstOrDefault(a => a.GrupId == fir.GrupId);
            _context.Firmagruplari.Remove(grup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





        public IActionResult Kayit()
        {
            return View();
        }
        public IActionResult Record()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Kayit([Bind("Funvan,Isvrnadsoyad,Isvrngsm,Firmatlfn,Faks,Firmamail,Il,Ilce,Adres,Faaliyetalan,Sgksicil,Tehlikesinif,Grupsirket")]
        Firma fir)
        {
            if (ModelState.IsValid)
            {

                baglantiSinifi bs = new baglantiSinifi();
                string sorgu = "insert into firmagruplari(grup_ad) values('" + fir.Funvan + "')";
                bs.baglanti("ekleme", sorgu);
                int a = bs.baglanti("bulgrubu", "");
                string sorgu1 = "insert into firma(funvan,isvrnadsoyad,isvrngsm,firmatlfn,faks,firmamail,il,ilce,adres,faaliyetalan,sgksicil,tehlikesinif,grupsirket,durum,grup_id) values" +
                    "('" + fir.Funvan + "','" + fir.Isvrnadsoyad + "','" + fir.Isvrngsm + "','" + fir.Firmatlfn + "','" + fir.Faks + "','" + fir.Firmamail + "','" + fir.Il + "','" + fir.Ilce + "','" + fir.Adres + "','" + fir.Faaliyetalan + "','" + fir.Sgksicil + "','" + fir.Tehlikesinif + "','" + fir.Grupsirket + "','ANA FİRMA','" + a + "')";
                bs.baglanti("ekleme", sorgu1);
                ViewBag.sonuc = "FİRMA Eklendi";
                a = bs.baglanti("bulfirma", "");
                return RedirectToAction("FirmaKayit", "Register", new { id = a });
            }
            
            return View(fir);
        }





   


    }
}
