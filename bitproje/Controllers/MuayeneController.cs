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
    public class MuayeneController : Controller
    {
        private readonly isgContext _context;

        public MuayeneController(isgContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var aa =  await _context.Muayene.OrderBy(b=>b.Mid).ToListAsync();           
           
                foreach (var item in aa)
                {
                    item.SicilnoNavigation=(_context.Kullanici.FirstOrDefault(b=>b.Sicilno==item.Sicilno));
                    item.SicilnopNavigation = (_context.Personel.FirstOrDefault(b => b.Sicilnop == item.Sicilnop));
                }      
            
            return View(aa);
            }
            else
            {
                return NotFound();
            }
        }


        public IActionResult Grupmuayene()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
            var firmaa = _context.Firma.Where(b => b.GrupId == bul.GrupId);
            var personel = new List<Personel>();
            foreach (var i in firmaa)  //FİRMALARDAKİ PERSONEL LİSTESİNİ ALIYOR
            {
                var per = _context.Personel.Where(c => c.Firmaid == i.Firmaid);
                foreach (var j in per)
                {

                    personel.Add(j);

                }
            }

            var muayene = new List<Muayene>();
            foreach (var i in personel) //muayene olan personel listesini buluyor o firma grubuna ait
            {
                var mua = _context.Muayene.Where(c => c.Sicilnop == i.Sicilnop);
                foreach (var j in mua)
                {
                    j.SicilnopNavigation = (_context.Personel.FirstOrDefault(b => b.Sicilnop == j.Sicilnop));
                    j.SicilnoNavigation = (_context.Kullanici.FirstOrDefault(b => b.Sicilno == j.Sicilno));
                    muayene.Add(j);
                   

                }
            }

            return View("Index", muayene);
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Firmamuayene()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var personel = _context.Personel.Where(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmaiid"));        

            var muayene = new List<Muayene>();
            foreach (var i in personel) //muayene olan personel listesini buluyor o firmaya ait
            {
                var mua = _context.Muayene.Where(c => c.Sicilnop == i.Sicilnop);
                foreach (var j in mua)
                {
                    j.SicilnopNavigation = (_context.Personel.FirstOrDefault(b => b.Sicilnop == j.Sicilnop));
                    j.SicilnoNavigation = (_context.Kullanici.FirstOrDefault(b => b.Sicilno == j.Sicilno));
                    muayene.Add(j);


                }
            }

            return View("Index", muayene);
        }
            else
            {
                return NotFound();
            }
              }
        public IActionResult kullaniciFirmamuayene()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var personel = _context.Personel.Where(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));

            var muayene = new List<Muayene>();
            foreach (var i in personel) //muayene olan personel listesini buluyor o firmaya ait
            {
                var mua = _context.Muayene.Where(c => c.Sicilnop == i.Sicilnop && c.Sicilno.ToString()== HttpContext.Session.GetString("sicilno"));
                foreach (var j in mua)
                {
                    j.SicilnopNavigation = (_context.Personel.FirstOrDefault(b => b.Sicilnop == j.Sicilnop));
                    j.SicilnoNavigation = (_context.Kullanici.FirstOrDefault(b => b.Sicilno == j.Sicilno));
                    muayene.Add(j);


                }
            }

            return View("Index", muayene);
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
                var muayene =await _context.Muayene.FirstOrDefaultAsync(m => m.Mid == id);
            muayene.SicilnoNavigation = _context.Kullanici.FirstOrDefault(h => h.Sicilno == muayene.Sicilno);
            muayene.SicilnopNavigation = _context.Personel.FirstOrDefault(h => h.Sicilnop == muayene.Sicilnop);
            if (muayene == null)
            {
                return NotFound();
            }
           
           var recete = _context.Recete.FirstOrDefault(m => m.Mid == id);
            ViewBag.bos = "dolu";
            if(recete==null)
            {
                ViewBag.bos = null;
            }
            return View( Tuple.Create<Muayene,Recete>(muayene,recete));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Create()
        {
            var muayene = new Muayene();
            if (HttpContext.Session.GetString("grubu") == "A") { 
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
                var firmaa = _context.Firma.Where(b => b.GrupId == bul.GrupId);
                var personel = new List<Personel>();
                var kullanici = new List<Kullanici>(_context.Kullanici.Where(b=>b.Grupid==bul.GrupId && b.Gorevtanim=="İşyeri Hekimi"));
                foreach (var i in firmaa)  //FİRMALARDAKİ PERSONEL LİSTESİNİ ALIYOR
                {
                    var per = _context.Personel.Where(c => c.Firmaid == i.Firmaid);
                    foreach (var j in per)
                    {

                        personel.Add(j);

                    }
                   
                }
                ViewBag.mpersonel = personel;
                ViewBag.mkullanici = kullanici;
            }
            else if (HttpContext.Session.GetString("grubu") == "C")
            {                
                var personel = _context.Personel.Where(a => a.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));
                var kullanici = _context.Kullanici.FirstOrDefault(b => b.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));
                muayene.Sicilno = kullanici.Sicilno;
                ViewBag.mpersonel = personel;
                ViewBag.mkullanici = kullanici;
            }
            else { return NotFound(); }



            return View(muayene);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mneden,Mtarihi,Sonrakimtarih,Annehastalikg,Babahastalikg,Kardeshastalikg,Cocukhastalikg,Büyüktan,Kücüktan,Nabiz,Kilo,Boy,Kangrup,Sicilno,Sicilnop,Grupid")]
        Muayene mu)
        {
            if (ModelState.IsValid)
            {
               
                _context.Add(mu);
                await _context.SaveChangesAsync();
                if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupmuayene)); }
                else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmamuayene)); }
               
            }

            return View(mu);

        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muayene = await _context.Muayene.FindAsync(id);
            if (muayene== null)
            {
                return NotFound();
            }
            if (HttpContext.Session.GetString("grubu") == "A")
            {
                var bul = _context.Firma.FirstOrDefault(b => b.Firmaid.ToString() == HttpContext.Session.GetString("firmagrubuid"));
                var firmaa = _context.Firma.Where(b => b.GrupId == bul.GrupId);
                var personel = new List<Personel>();
                var kullanici = new List<Kullanici>(_context.Kullanici.Where(b => b.Grupid == bul.GrupId && b.Gorevtanim == "İşyeri Hekimi"));
                foreach (var i in firmaa)  //FİRMALARDAKİ PERSONEL LİSTESİNİ ALIYOR
                {
                    var per = _context.Personel.Where(c => c.Firmaid == i.Firmaid);
                    foreach (var j in per)
                    {

                        personel.Add(j);

                    }

                }
             
                ViewBag.mper = personel;
                ViewBag.mkul = kullanici;
            }
            else  if (HttpContext.Session.GetString("grubu") == "C")
            {
                var personel = _context.Personel.Where(b => b.Firmaid.ToString() == HttpContext.Session.GetString("kfirmaid"));   
                var kullanici = _context.Kullanici.FirstOrDefault(b => b.Sicilno.ToString() == HttpContext.Session.GetString("sicilno"));
                muayene.SicilnoNavigation = kullanici;
                ViewBag.mper = personel;
                ViewBag.mkul = kullanici;
            }
            else 
            {
                return NotFound();
            }

            return View(muayene);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Mid,Mneden,Mtarihi,Sonrakimtarih,Annehastalikg,Babahastalikg,Kardeshastalikg,Cocukhastalikg,Büyüktan,Kücüktan,Nabiz,Kilo,Boy,Kangrup,Sicilno,Sicilnop")]
        Muayene mu)
        {
            if (id != mu.Mid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MuayeneExists(mu.Mid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupmuayene)); }
                else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmamuayene)); }

            }

            return View(mu);
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var muayene = await _context.Muayene
                    .FirstOrDefaultAsync(m => m.Mid == id);
                muayene.SicilnoNavigation = await _context.Kullanici.FirstOrDefaultAsync(a => a.Sicilno == muayene.Sicilno);
                muayene.SicilnopNavigation = await _context.Personel.FirstOrDefaultAsync(a => a.Sicilnop == muayene.Sicilnop);
                if (muayene == null)
                {
                    return NotFound();
                }
            return View( muayene);
            }
            else { return NotFound(); }

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mu = _context.Muayene.FirstOrDefault(m => m.Mid== id);
            _context.Muayene.Remove(mu);
            await _context.SaveChangesAsync();
            if (HttpContext.Session.GetString("grubu") == "A") { return RedirectToAction(nameof(Grupmuayene)); }
            else if (HttpContext.Session.GetString("grubu") == "C") { return RedirectToAction(nameof(kullaniciFirmamuayene)); }
            else if (HttpContext.Session.GetString("grubu") == "D") { return RedirectToAction(nameof(kullaniciFirmamuayene)); }
            return View();
        }


        private bool MuayeneExists(int id)
        {
            return _context.Muayene.Any(e => e.Mid == id);
        }
    }
}