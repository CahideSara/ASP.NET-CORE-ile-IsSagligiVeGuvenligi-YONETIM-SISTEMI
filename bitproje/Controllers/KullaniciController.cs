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
using static System.Collections.Specialized.BitVector32;

namespace bitproje.Controllers
{
    public class KullaniciController : Controller
    {
        private isgContext _context { get; set; }

        public KullaniciController(isgContext context)
        {
            _context = context;
        }
    

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Kullanici.OrderBy(b => b.Sicilno);
            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }
     

        public IActionResult Grupkullanici()
        {
            if (HttpContext.Session.GetString("grubu")=="A")
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
            var firmalar = _context.Kullanici.Where(b => b.Grupid == bul.GrupId);

            return View("Index", firmalar);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Firmakullanici()
        {
            if (HttpContext.Session.GetString("grubu") == "B")
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaid"));
            var kullanici = _context.Kullanici.Where(b => b.Grupid == bul.GrupId);

            return View("Index", kullanici);
            }
            else
            {
                return NotFound();
            }
        }


        public IEnumerable<Kullanici> liste()
        {
             var Context =  _context.Kullanici.OrderBy(b => b.Sicilno);
            return Context;
    }

        public async Task<IActionResult> FirmaCikar(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var kulfir = await _context.KullaniciFirma
                .FirstOrDefaultAsync(m => m.Id == id);

            if (kulfir == null)
            {
                return NotFound();
            }
            kulfir.Kullanici = _context.Kullanici.FirstOrDefault(d => d.Sicilno == kulfir.Sicilno);
            kulfir.Firma = _context.Firma.FirstOrDefault(d => d.Firmaid == kulfir.Firmaid);
            return View(kulfir);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost, ActionName("FirmaCikar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FirmaCikarConfirmed(int id)
        {

            var kulfirma = _context.KullaniciFirma.FirstOrDefault(m => m.Id==id);
            _context.KullaniciFirma.Remove(kulfirma);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Kullanici", new { id = kulfirma.Sicilno });
        }



        public async Task<IActionResult> Profil()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var kullanici = await _context.Kullanici.FirstOrDefaultAsync(m => m.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));
            
            if (kullanici == null)
            {
                return NotFound();
            }

            return View(kullanici);
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

            var kullanıcı = await _context.Kullanici.FindAsync(id);
            if (kullanıcı == null)
            {
                return NotFound();
            }
            ViewBag.statu = new List<Statu>(_context.Statu);
            return View(kullanıcı);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProfilEdit(int id, [Bind("Sicilno,Gorevtanim,Tc,Ad,Soyad,Durum,Boy,Kilo,Kangrup,Cinsiyet,Dogumtarih,Dogumyer,Statü,Ogrenimdurum,Isgkurulgorev,Isebaslangictarih,Unvan,Grupid")]
        Kullanici kul)
        {
            if (id != kul.Sicilno)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kul);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KullaniciExists(kul.Sicilno))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Profil));
            }

            return View(kul);
        }







        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var kullanici=await _context.Kullanici.FirstOrDefaultAsync(m => m.Sicilno == id);
            var kfirma = _context.KullaniciFirma.Where(m => m.Sicilno == kullanici.Sicilno);
           
            foreach (var i in kfirma)
            {
                i.Firma = _context.Firma.FirstOrDefault(m => m.Firmaid == i.Firmaid);

            }

           
            if (kullanici == null)
            {
                return NotFound();
            }

            return View(Tuple.Create<Kullanici, IEnumerable<KullaniciFirma>>(kullanici,kfirma));
            }
            else
            {
                return NotFound();
            }
        }



        public IActionResult FirmaEkle(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var kfirma = new KullaniciFirma();
            kfirma.Sicilno = id;
            var grup=new Firma();
            if (HttpContext.Session.GetString("grubu") == "A")
            { grup= _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid")); }
            else if (HttpContext.Session.GetString("grubu") == "B")
            { grup = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaid")); }
            
            var firmalar = new List<Firma>(_context.Firma.Where(m => m.GrupId == grup.GrupId));            
            var kulfirma= new List<Firma>();
            foreach (var i in firmalar)
            {
                if(_context.KullaniciFirma.FirstOrDefault(m=>m.Firmaid==i.Firmaid && m.Sicilno==id)==null)
                {
                    kulfirma.Add(i);
                }
            }

            ViewBag.firma = kulfirma;

            return View(kfirma);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FirmaEkle([Bind("Sicilno,Firmaid")]
        KullaniciFirma kfir)
        {

            if (ModelState.IsValid)
            {           

                _context.Add(kfir);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Kullanici", new { id = kfir.Sicilno });
            }

            return View(kfir);

        }




        public IActionResult Create()
        {
            ViewBag.statu = new List<Statu>(_context.Statu);
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
        public async Task<IActionResult> Create([Bind("Sicilno,Gorevtanim,Tc,Ad,Soyad,Durum,Boy,Kilo,Kangrup,Cinsiyet,Dogumtarih,Dogumyer,Statü,Ogrenimdurum,Isgkurulgorev,Isebaslangictarih,Unvan,Grupid")]
        Kullanici kul)
        {
            var sicil = _context.Kullanici.FirstOrDefault(a => a.Sicilno == kul.Sicilno);
            if (sicil != null)
            {
                ViewBag.hata = "BU SİCİL DE BİR PERSONEL BULUNMAKTA";
            }
            else { 
            if (ModelState.IsValid)
            {
                baglantiSinifi bs = new baglantiSinifi();
                if (HttpContext.Session.GetString("grubu") == "A")
                {
                    var grup = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid")).GrupId;
                    kul.Grupid = grup.GetHashCode();
                    _context.Add(kul);
                    await _context.SaveChangesAsync();
                    int a = bs.baglanti("bulkul", "");
                    var user = new Users();
                    user.Kullaniciadi = kul.Sicilno.ToString();
                    user.Sifre = "sıfırIsgm";
                    user.Sicilno = kul.Sicilno;
                    if (kul.Gorevtanim == "İşyeri Hekimi")
                        user.Grubu = "C";
                    else if (kul.Gorevtanim == "İşyeri Güvenliği Uzmanı")
                        user.Grubu = "D";
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Grupkullanici));
                }
                if (HttpContext.Session.GetString("grubu") == "B")
                {
                    var grup = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaid")).GrupId;
                    kul.Grupid = grup.GetHashCode();
                    _context.Add(kul);
                    await _context.SaveChangesAsync();
                    int a = bs.baglanti("bulkul", "");
                    var user = new Users();
                    user.Kullaniciadi = kul.Sicilno.ToString();
                    user.Sifre = "sıfırIsgm";
                    user.Sicilno = kul.Sicilno;
                    if (kul.Gorevtanim == "İşyeri Hekimi")
                        user.Grubu = "C";
                    else if (kul.Gorevtanim == "İşyeri Güvenliği Uzmanı")
                        user.Grubu = "D";
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Firmakullanici));
                }

            }
            }
            return View(kul);

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var kullanıcı = await _context.Kullanici.FindAsync(id);
            if (kullanıcı == null)
            {
                return NotFound();
            }
            ViewBag.statu = new List<Statu>(_context.Statu);
            return View(kullanıcı);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Sicilno,Gorevtanim,Tc,Ad,Soyad,Durum,Boy,Kilo,Kangrup,Cinsiyet,Dogumtarih,Dogumyer,Statü,Ogrenimdurum,Isgkurulgorev,Isebaslangictarih,Unvan,Grupid")]
        Kullanici kul)
        {
            if (id != kul.Sicilno)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var okul = _context.Kullanici.FirstOrDefault(c => c.Sicilno == id);
                    if (okul.Gorevtanim != kul.Gorevtanim)
                    {
                        var user = _context.Users.FirstOrDefault(a => a.Sicilno == id);
                        if (kul.Gorevtanim == "İşyeri Hekimi")
                            user.Grubu = "C";
                        if (kul.Gorevtanim == "İşyeri Güvenliği Uzmanı")
                            user.Grubu = "D";
                        _context.Update(user);
                        await _context.SaveChangesAsync();
                    }
                    _context.Update(kul);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KullaniciExists(kul.Sicilno))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupkullanici)); }
                else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmakullanici)); }
                   
            }
            
            return View(kul);
        }




        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var kuls = _context.Kullanici
                .FirstOrDefaultAsync(m => m.Sicilno == id);
            if (kuls == null)
            {
                return NotFound();
            }

            return View(await kuls);
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
            var kul = _context.Kullanici.FirstOrDefault(m => m.Sicilno == id);
            _context.Kullanici.Remove(kul);
            await _context.SaveChangesAsync();
            if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupkullanici)); }
            else if (HttpContext.Session.GetString("grubu") == "B") { return RedirectToAction(nameof(Firmakullanici)); }
            return View();
        }


        private bool KullaniciExists(int id)
        {
            return _context.Kullanici.Any(e => e.Sicilno == id);
        }
    }
}