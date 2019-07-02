using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bitproje.Data;
using bitproje.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bitproje.Controllers
{
    public class RegisterController : Controller
    {
        private readonly isgContext _context;

        public RegisterController(isgContext context)
        {
            _context = context;
        }

        public IActionResult FirmaKayit(int id)
        {
            var reg = new Register();
            reg.Firmaid = id;
            return View(reg);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FirmaKayit([Bind("Firmaid,soru,cevap,renk,Sifre,SifreTekrar,Kullaniciadi")] Register res)
        {
            if (ModelState.IsValid)
            {
               
                if (res.Sifre != res.SifreTekrar)
                {
                    ViewBag.sonuc = "SİFRE VE SİFRE TEKRARI AYNI DEĞİL.";
                }

                else if (_context.Users.FirstOrDefault(z => z.Kullaniciadi == res.Kullaniciadi) == null)
                {
                    var user = new Users();
                    user.Firmaid = res.Firmaid;
                    user.soru = res.soru;
                    user.cevap = res.cevap;
                    user.renk = res.renk;
                    user.Sifre = res.Sifre;
                    user.Kullaniciadi = res.Kullaniciadi;
                    user.Grubu = "B";
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ISGM", "Home");                    
                    
                }
              
                else {
                    ViewBag.sonuc = "BÖYLE BİR KULLANICI ADI ZATEN VAR";
                }
            }
            return View(res);
        }
        

        public IActionResult SifreYenile(int id)
        {
            var us = _context.Users.FirstOrDefault(z => z.Id == id);
            var reg = new Register();
            reg.Id = us.Id;
            
            return View(reg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SifreYenile(int id,[Bind("Id,Sifre,SifreTekrar")] Register res)
        {
            if (ModelState.IsValid)
            {

                if (res.Sifre != res.SifreTekrar)
                {
                    ViewBag.sonuc = "SİFRE VE SİFRE TEKRARI AYNI DEĞİL.";
                }

                else 
                {
                    var user = _context.Users.FirstOrDefault(z => z.Id == id);
                    user.Sifre = res.Sifre;
                    _context.Update(user);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("ISGM", "Home");

                }
            }
            return View(res);
        }


        public IActionResult SifreSifirla(int id)
        {
            var us = _context.Users.FirstOrDefault(z => z.Id == id);           

            return View(us);
        }
        [HttpPost, ActionName("SifreSifirla")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SifreSifirlaConfirmed(int id)
        {
            var us = _context.Users.FirstOrDefault(m => m.Id == id);
            us.Sifre = "sıfırIsgm";
            _context.Update(us);
            await _context.SaveChangesAsync();
            return RedirectToAction("Yönetim", "Grup");
        }






        public IActionResult BilgiGüncelle()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var us = _context.Users.FirstOrDefault(z => z.Id.ToString() == HttpContext.Session.GetString("id"));
            var reg = new Register();
            reg.Id = us.Id;
            reg.Kullaniciadi = us.Kullaniciadi;
            reg.Sifre = us.Sifre;
            reg.SifreTekrar = us.Sifre;
            reg.renk = us.renk;
            reg.soru = us.soru;
            reg.cevap = us.cevap;

            return View(reg);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BilgiGüncelle(int id, [Bind("Id,Sifre,SifreTekrar,Kullaniciadi,renk,soru,cevap")] Register res)
        {
            if (ModelState.IsValid)
            {

                if (res.Sifre != res.SifreTekrar)
                {
                    ViewBag.sonuc = "SİFRE VE SİFRE TEKRARI AYNI DEĞİL.";
                }
                else if (_context.Users.FirstOrDefault(z => z.Kullaniciadi == res.Kullaniciadi && z.Id!=res.Id) == null)
                { 
                    var user = _context.Users.FirstOrDefault(z => z.Id == id);
                    user.Sifre = res.Sifre;
                    user.Kullaniciadi = res.Kullaniciadi;
                    user.renk = res.renk;
                    user.soru = res.soru;
                    user.cevap = res.cevap;
                    _context.Update(user);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Users");

                }
                else
                {
                    ViewBag.sonuc = "BÖYLE BİR KULLANICI ADI ZATEN VAR";

                }
            }
            return View(res);
        }


    }
}