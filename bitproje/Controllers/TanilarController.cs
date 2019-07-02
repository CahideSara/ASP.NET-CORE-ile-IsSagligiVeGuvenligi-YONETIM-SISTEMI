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
    public class TanilarController : Controller
    {
        private readonly isgContext _context;

        public TanilarController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var tanilar = _context.Tanilar.Where(b => b.Mid==id);
            ViewBag.mid = id;
             foreach (var item in tanilar)
            {
                item.Tanim = _context.Tanitanimi.FirstOrDefault(a => a.Tanitid == item.Tanimid);

            }
            return View(tanilar);
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Create(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var tani = new Tanilar();
            tani.Mid = id;
            var tanilar = new List<Tanitanimi>();
            var tanıtanım = _context.Tanitanimi;
            foreach (var i in tanıtanım)
            {
                if (_context.Tanilar.FirstOrDefault(m => m.Tanimid == i.Tanitid && m.Mid == id) == null)
                {
                    tanilar.Add(i);
                }
            }

            ViewBag.tani = tanilar;
            
            return View(tani);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mid,Tanimid")]
        Tanilar tan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tan);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Tanilar", new { id = tan.Mid });
            }

            return View(tan);

        }
        public IActionResult Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var tan = _context.Tanilar.FirstOrDefault(s => s.Taniid == id);
            tan.Tanim = _context.Tanitanimi.FirstOrDefault(c => c.Tanitid == tan.Tanimid);
            if (tan == null)
            {
                return NotFound();
            }

            return View(tan);
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
            var tanii = _context.Tanilar.FirstOrDefault(m => m.Taniid == id);
            _context.Tanilar.Remove(tanii);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Tanilar", new { id = tanii.Mid });
        }
    }
}