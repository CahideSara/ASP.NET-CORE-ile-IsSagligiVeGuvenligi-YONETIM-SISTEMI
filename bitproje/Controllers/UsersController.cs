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
    public class UsersController : Controller
    {
        private readonly isgContext _context;
        public  Firma fir;
        public UsersController(isgContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {
           return View();
        }

      

        [Route("login")]
        [HttpPost]
        
        public IActionResult Login([Bind("Kullaniciadi,Sifre")]Users us)
        {
            var user = _context.Users.FirstOrDefault(m =>m.Kullaniciadi== us.Kullaniciadi && m.Sifre==us.Sifre);
            var firma = _context.Firma.FirstOrDefault(z => z.Firmaid == user.Firmaid);
            if (_context.Users.FirstOrDefault(m => m.Kullaniciadi == us.Kullaniciadi && m.Sifre == us.Sifre) == null)
            {
                ViewBag.error = "Kullanıcı Adı veya Şifre hatalı !!";
            }
            else {
            if ((user.Grubu.Equals("A")))
            {
                HttpContext.Session.SetString("id", user.Id.ToString());
                HttpContext.Session.SetString("kullaniciadi", user.Kullaniciadi);
                HttpContext.Session.SetString("sifre", user.Sifre);
                HttpContext.Session.SetString("grubu", user.Grubu);


                ViewBag.MyDataUser=user;

                return View("Admin",user);
            }
            else if ((user.Grubu.Equals("B")))
            {
                var firmaa = _context.Firma.FirstOrDefault(z => z.Firmaid == user.Firmaid);

                HttpContext.Session.SetString("id", user.Id.ToString());
                HttpContext.Session.SetString("kullaniciadi", user.Kullaniciadi);
                HttpContext.Session.SetString("sifre", user.Sifre);
                HttpContext.Session.SetString("firmaid", user.Firmaid.ToString());
                HttpContext.Session.SetString("grubu", user.Grubu);
                user.firma = _context.Firma.FirstOrDefault(m => m.Firmaid.ToString().Equals(HttpContext.Session.GetString("firmaid")));
                HttpContext.Session.SetString("funvan", user.firma.Funvan);
                HttpContext.Session.SetString("isveren", user.firma.Isvrnadsoyad);
                HttpContext.Session.SetString("durum", user.firma.Durum);

                    var yetki = _context.Yetki.First();
                    //firma yetkileri 
                    HttpContext.Session.SetString("firmafirmaekle",yetki.firmafirmaekle.ToString());
                    HttpContext.Session.SetString("firmafirmasil", yetki.firmafirmasil.ToString());
                    HttpContext.Session.SetString("firmafirmaguncel",yetki.firmafirmaguncel.ToString());
                    HttpContext.Session.SetString("firmabirimekle", yetki.firmabirimekle.ToString());
                    HttpContext.Session.SetString("firmabirimsil", yetki.firmabirimsil.ToString());
                    HttpContext.Session.SetString("firmabirimguncel", yetki.firmabirimguncel.ToString());
                    HttpContext.Session.SetString("firmapersonelekle",yetki.firmapersonelekle.ToString());
                    HttpContext.Session.SetString("firmapersonelsil", yetki.firmapersonelsil.ToString());
                    HttpContext.Session.SetString("firmapersonelguncel", yetki.firmapersonelguncel.ToString());
                    HttpContext.Session.SetString("firmailacekle", yetki.firmailacekle.ToString());
                    HttpContext.Session.SetString("firmailaccsil", yetki.firmailaccsil.ToString());
                    HttpContext.Session.SetString("firmataniekle", yetki.firmataniekle.ToString());
                    HttpContext.Session.SetString("firmatanisil", yetki.firmatanisil.ToString());
                    HttpContext.Session.SetString("firmastatuekle", yetki.firmastatuekle.ToString());
                    HttpContext.Session.SetString("firmastatusil", yetki.firmastatusil.ToString());


                    fir = firmaa;
                Console.WriteLine(user.firma);

               
                return View("Success");
            }
            else if ((user.Grubu.Equals("C")) || (user.Grubu.Equals("D")))
            {
                var kul = _context.Kullanici.FirstOrDefault(d => d.Sicilno == user.Sicilno);
                if(kul.Gorevtanim== "İşyeri Hekimi") {

                    HttpContext.Session.SetString("id", user.Id.ToString());
                    HttpContext.Session.SetString("kullaniciadi", user.Kullaniciadi);
                    HttpContext.Session.SetString("sifre", user.Sifre);
                    HttpContext.Session.SetString("sicilno", user.Sicilno.ToString());
                    HttpContext.Session.SetString("grubu", user.Grubu);
                    user.sicil = _context.Kullanici.FirstOrDefault(m => m.Sicilno.ToString().Equals(HttpContext.Session.GetString("sicilno")));
                    HttpContext.Session.SetString("ad", user.sicil.Ad);
                    HttpContext.Session.SetString("soyad", user.sicil.Soyad);
                    HttpContext.Session.SetString("görev", user.sicil.Gorevtanim);

                        var yetki = _context.Yetki.First();
                        //firma yetkileri 
                        HttpContext.Session.SetString("hekimfirmaekle", yetki.hekimfirmaekle.ToString());
                        HttpContext.Session.SetString("hekimfirmasil", yetki.hekimfirmasil.ToString());
                        HttpContext.Session.SetString("hekimfirmaguncel", yetki.hekimfirmaguncel.ToString());
                        HttpContext.Session.SetString("hekimbirimekle", yetki.hekimbirimekle.ToString());
                        HttpContext.Session.SetString("hekimbirimsil", yetki.hekimbirimsil.ToString());
                        HttpContext.Session.SetString("hekimbirimguncel", yetki.hekimbirimguncel.ToString());
                        HttpContext.Session.SetString("hekimpersonelekle", yetki.hekimpersonelekle.ToString());
                        HttpContext.Session.SetString("hekimpersonelsil", yetki.hekimpersonelsil.ToString());
                        HttpContext.Session.SetString("hekimpersonelguncel", yetki.hekimpersonelguncel.ToString());
                        HttpContext.Session.SetString("hekimilacekle", yetki.hekimilacekle.ToString());
                        HttpContext.Session.SetString("hekimilacsil", yetki.hekimilacsil.ToString());
                        HttpContext.Session.SetString("hekimtaniekle", yetki.hekimtaniekle.ToString());
                        HttpContext.Session.SetString("hekimtanisil", yetki.hekimtanisil.ToString());
                        HttpContext.Session.SetString("hekimstatuekle", yetki.hekimstatuekle.ToString());
                        HttpContext.Session.SetString("hekimstatusil", yetki.hekimstatusil.ToString());


                        return View("Hekim");
                }
                else if (kul.Gorevtanim == "İşyeri Güvenliği Uzmanı") {
                    HttpContext.Session.SetString("id", user.Id.ToString());
                    HttpContext.Session.SetString("kullaniciadi", user.Kullaniciadi);
                    HttpContext.Session.SetString("sifre", user.Sifre);
                    HttpContext.Session.SetString("sicilno", user.Sicilno.ToString());
                    HttpContext.Session.SetString("grubu", user.Grubu);
                    user.sicil = _context.Kullanici.FirstOrDefault(m => m.Sicilno.ToString().Equals(HttpContext.Session.GetString("sicilno")));
                    HttpContext.Session.SetString("ad", user.sicil.Ad);
                    HttpContext.Session.SetString("soyad", user.sicil.Soyad);
                    HttpContext.Session.SetString("görev", user.sicil.Gorevtanim);

                        var yetki = _context.Yetki.First();
                        //firma yetkileri 
                        HttpContext.Session.SetString("uzmanfirmaekle", yetki.uzmanfirmaekle.ToString());
                        HttpContext.Session.SetString("uzmanfirmasil", yetki.uzmanfirmasil.ToString());
                        HttpContext.Session.SetString("uzmanfirmaguncel", yetki.uzmanfirmaguncel.ToString());
                        HttpContext.Session.SetString("uzmanbirimekle", yetki.uzmanbirimekle.ToString());
                        HttpContext.Session.SetString("uzmanbirimsil", yetki.uzmanbirimsil.ToString());
                        HttpContext.Session.SetString("uzmanbirimguncel", yetki.uzmanbirimguncel.ToString());
                        HttpContext.Session.SetString("uzmanpersonelekle", yetki.uzmanpersonelekle.ToString());
                        HttpContext.Session.SetString("uzmanpersonelsil", yetki.uzmanpersonelsil.ToString());
                        HttpContext.Session.SetString("uzmanpersonelguncel", yetki.uzmanpersonelguncel.ToString());
                        HttpContext.Session.SetString("uzmanilacekle", yetki.uzmanilacekle.ToString());
                        HttpContext.Session.SetString("uzmanilacsil", yetki.uzmanilacsil.ToString());
                        HttpContext.Session.SetString("uzmantaniekle", yetki.uzmantaniekle.ToString());
                        HttpContext.Session.SetString("uzmantanisil", yetki.uzmantanisil.ToString());
                        HttpContext.Session.SetString("uzmanstatuekle", yetki.uzmanstatuekle.ToString());
                        HttpContext.Session.SetString("uzmanstatusil", yetki.uzmanstatusil.ToString());





                        return View("Guzman");
                }

              
            }
            }
        
            return View();
        }


        public JsonResult  Getir()
        {
            var  user = _context.Users.LastOrDefault(m => m.Id.ToString() == HttpContext.Session.GetString("id"));
            if (HttpContext.Session.GetString("grubu") == "B") {
                
                  user.firma = _context.Firma.LastOrDefault(z => z.Firmaid == user.Firmaid);
                ViewBag.user = user.Grubu;
                return  Json( user);
            }
            else if (HttpContext.Session.GetString("grubu") == "C" || HttpContext.Session.GetString("grubu") == "D")
            {
                user.sicil = _context.Kullanici.LastOrDefault(z => z.Sicilno == user.Sicilno);
                ViewBag.user = user.Grubu;
                return Json(user);
            }
          

            ViewBag.user = user.Grubu;
            return Json(user);
        }


        public IActionResult SifreUnut()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SifreUnut([Bind("soru,cevap,renk,Kullaniciadi")] Users us)
        {
            if (ModelState.IsValid)
            {
                
                if (_context.Users.FirstOrDefault(z => z.Kullaniciadi == us.Kullaniciadi && z.soru==us.soru && z.cevap==us.cevap && z.renk==us.renk ) == null)
                {
                    ViewBag.sonuc = "BU BİLGİLERDE KULLANICI BULUNAMAMIŞTIR.";
                }

                else 
                {
                    var user = _context.Users.FirstOrDefault(z => z.Kullaniciadi == us.Kullaniciadi && z.soru == us.soru && z.cevap == us.cevap && z.renk == us.renk);
                
                    return RedirectToAction("SifreYenile", "Register", new { id = user.Id });

                }
            }
            return View(us);
        }















        public IActionResult Menu()
        {

            return View();
        }


        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("kullaniciadi");
            HttpContext.Session.Remove("sifre");
            HttpContext.Session.Remove("kfirmaad");
            HttpContext.Session.Remove("kfirmaid");
            HttpContext.Session.Remove("firmagrubuad");
            HttpContext.Session.Remove("firmagrubuid");
            HttpContext.Session.Remove("grubu");
            return RedirectToAction("Index");
        }

       
    }
}