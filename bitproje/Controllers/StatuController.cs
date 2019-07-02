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
    public class StatuController : Controller
    {
        private readonly isgContext _context;

        public StatuController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Statu.OrderBy(b => b.Statuid);
            return View(Context.ToList());
            }
            else
            {
                return NotFound();
            }
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmastatuekle") == true.ToString() ||
                 HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimstatuekle") == true.ToString() ||
                  HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanstatuekle") == true.ToString())
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
        public async Task<IActionResult> Create([Bind("Statuadi")] Statu statu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statu);
        }
        // GET: Universites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("grubu") == "A" || HttpContext.Session.GetString("grubu") == "B" && HttpContext.Session.GetString("firmastatusil") == true.ToString() ||
                  HttpContext.Session.GetString("grubu") == "C" && HttpContext.Session.GetString("hekimstatusil") == true.ToString() ||
                   HttpContext.Session.GetString("grubu") == "D" && HttpContext.Session.GetString("uzmanstatusil") == true.ToString())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var statu = await _context.Statu
                    .FirstOrDefaultAsync(m => m.Statuid == id);
                if (statu == null)
                {
                    return NotFound();
                }

                return View(statu);
            }
            else
            {
                return NotFound();
            }

        }

        // POST: Universites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statu = _context.Statu.FirstOrDefault(m => m.Statuid == id);
            _context.Statu.Remove(statu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





    }
}