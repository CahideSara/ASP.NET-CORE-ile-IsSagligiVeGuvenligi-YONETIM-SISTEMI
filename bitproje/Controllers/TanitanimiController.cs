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
    public class TanitanimiController : Controller
    {
        private readonly isgContext _context;

        public TanitanimiController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Tanitanimi.OrderBy(b => b.Tanitid);
            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmataniekle") == true.ToString() ||
                 HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimtaniekle") == true.ToString() ||
                  HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmantaniekle") == true.ToString())
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
        public async Task<IActionResult> Create([Bind("Taniadi")] Tanitanimi tanim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tanim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tanim);
        }
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmatanisil") == true.ToString() ||
                  HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimtanisil") == true.ToString() ||
                   HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmantanisil") == true.ToString())
            {
                if (id == null)
            {
                return NotFound();
            }

            var tani = await _context.Tanitanimi
                .FirstOrDefaultAsync(m => m.Tanitid == id);
            if (tani == null)
            {
                return NotFound();
            }

            return View(tani);
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
            var tani = _context.Tanitanimi.FirstOrDefault(m => m.Tanitid == id);
            _context.Tanitanimi.Remove(tani);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}