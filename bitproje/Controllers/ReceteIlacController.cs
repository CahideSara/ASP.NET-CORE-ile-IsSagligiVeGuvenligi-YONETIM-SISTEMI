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
    public class ReceteIlacController : Controller
    {
        private readonly isgContext _context;

        public ReceteIlacController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var rilac = _context.Receteilac.Where(b => b.Rid== id);
            foreach(var item in rilac)
            {
                item.Ilac = _context.Ilactanimi.FirstOrDefault(c => c.Ilacid == item.Ilacid);
            }
            var recete = _context.Recete.FirstOrDefault(z => z.Rid == id);
            ViewBag.muayne = recete;
            return View(rilac);
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
                var rilac = new Receteilac();
            rilac.Rid = id;
            var ilaclar = new List<Ilactanimi>();
            var ilactanım = _context.Ilactanimi;
            foreach (var i in ilactanım)
            {
                if (_context.Receteilac.FirstOrDefault(m => m.Ilacid == i.Ilacid && m.Rid == id) == null)
                {
                    ilaclar.Add(i);
                }
            }


            ViewBag.ilac = ilaclar;
            
            return View(rilac);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Rid,Ilacid, Kullanimadedi,Kullanimsekli,Periyod,Ilacdozu")]
        Receteilac rilac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rilac);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "ReceteIlac", new { id = rilac.Rid });
            }

            return View(rilac);

        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var receteilaç = await _context.Receteilac.FindAsync(id);
            if (receteilaç == null)
            {
                return NotFound();
            }

            ViewBag.ilac = new List<Ilactanimi>(_context.Ilactanimi);

            return View(receteilaç);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Rilacid,Rid,Ilacid, Kullanimadedi,Kullanimsekli,Periyod,Ilacdozu")] Receteilac ri)
        {
            if (id != ri.Rilacid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ri);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "ReceteIlac", new { id = ri.Rid });
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RilacExists(ri.Rilacid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }


            }
            
            return View(ri);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                if (id == null)
            {
                return NotFound();
            }

            var rec = await _context.Receteilac
                .FirstOrDefaultAsync(m => m.Rilacid == id);
            if (rec == null)
            {
                return NotFound();
            }
            rec.Ilac = _context.Ilactanimi.FirstOrDefault(h => h.Ilacid == rec.Ilacid);
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
            var rec = _context.Receteilac.FirstOrDefault(m => m.Rilacid == id);
            _context.Receteilac.Remove(rec);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "ReceteIlac", new { id = rec.Rid });
        }

        private bool RilacExists(int id)
        {
            return _context.Receteilac.Any(e => e.Rilacid == id);
        }
    }
}