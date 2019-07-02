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
    public class IlactanimiController : Controller
    {
        private readonly isgContext _context;

        public IlactanimiController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Ilactanimi.OrderBy(b => b.Ilacid);
            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }

        }
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmailacekle") == true.ToString() || HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimilacekle") == true.ToString()
           || HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanilacekle") == true.ToString())
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
        public async Task<IActionResult> Create([Bind("Ilacadi")] Ilactanimi ilac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ilac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ilac);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmailaccsil") == true.ToString() || HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimilacsil") == true.ToString()
        || HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanilacsil") == true.ToString())
            {

                if (id == null)
                {
                    return NotFound();
                }

                var ilac = await _context.Ilactanimi
                    .FirstOrDefaultAsync(m => m.Ilacid == id);
                if (ilac == null)
                {
                    return NotFound();
                }

                return View(ilac);
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
            var ilac = _context.Ilactanimi.FirstOrDefault(m => m.Ilacid == id);
            _context.Ilactanimi.Remove(ilac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public JsonResult DeleteIlac(int id)
        {
            try
            {
                var ilac = _context.Ilactanimi.FirstOrDefault(m => m.Ilacid == id);
                _context.Ilactanimi.Remove(ilac);
                 _context.SaveChangesAsync();
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }

        
    }
}