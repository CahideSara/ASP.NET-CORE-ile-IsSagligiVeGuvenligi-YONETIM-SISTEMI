using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bitproje.Models;
using Microsoft.AspNetCore.Http;
using bitproje.Entitys;
using Microsoft.EntityFrameworkCore;
using bitproje.Data;

namespace bitproje.Controllers
{
    public class HomeController : Controller
    {

        public static Users us;
        private readonly isgContext _context;

        public HomeController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ISGM()
        {
            return View();
        }

        public IActionResult Giris()
        {
            return View();
        }

        public async Task<IActionResult> About(int id)
        {


            var firma = await _context.Firma.FirstOrDefaultAsync(h => h.Firmaid == id);


            return View(firma);
        }
        public async Task<IActionResult> Menu()
        {

            var firma = await _context.Firma.FirstOrDefaultAsync(h => h.Firmaid.ToString().Equals(HttpContext.Session.GetString("firmaid")));


            return View(firma);
        }
        public async Task<IActionResult> Header()
        {
            
            var use =await _context.Users.LastOrDefaultAsync(m => m.Id.ToString().Equals(HttpContext.Session.GetString("id")));
            if (HttpContext.Session.GetString("grubu") == "B")
            { 
                use.firma = _context.Firma.LastOrDefault(z => z.Firmaid == use.Firmaid);                
                
            }
            else if (HttpContext.Session.GetString("grubu") == "C" || HttpContext.Session.GetString("grubu") == "D")
            {
                use.sicil = _context.Kullanici.LastOrDefault(z => z.Sicilno == use.Sicilno);              
            }
            us = use;
            return View(use);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




    }
}
