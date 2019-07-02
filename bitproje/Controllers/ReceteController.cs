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
    public class ReceteController : Controller
    {
        private readonly isgContext _context;

        public ReceteController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Recete.Where(b => b.Mid == id);
            return View(Context);
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
                var recete = new Recete();
            recete.Mid = id;

            return View(recete);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mid,Rtarihi,Rtipi,Ralttipi,Provizyontipi,Serino")]
        Recete rec)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rec);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Muayene", new { id = rec.Mid });
            }

            return View(rec);

        }






        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }
            var recete = await _context.Recete.FindAsync(id);
            if (recete == null)
            {
                return NotFound();
            }           
            return View(recete);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Rid,Mid,Rtarihi,Rtipi,Ralttipi,Provizyontipi,Serino")] Recete res)
        {
            if (id != res.Rid){  return NotFound();   }
            if (ModelState.IsValid)
            {
                try{ _context.Update(res);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", "Muayene", new { id = res.Mid });
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceteExists(res.Rid))  {  return NotFound();  }
                    else { throw;}
                }
            }
            return View(res);
        }



        public IActionResult Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null){ return NotFound(); }
            var rec = _context.Recete.FirstOrDefault(s => s.Rid == id);
            if (rec == null){ return NotFound(); }

            return View(rec);
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
            var rec = _context.Recete.FirstOrDefault(m => m.Rid == id);
            _context.Recete.Remove(rec);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Muayene", new { id = rec.Mid });
        }

        private bool ReceteExists(int id)
        {
            return _context.Recete.Any(e => e.Rid == id);
        }

    }
}