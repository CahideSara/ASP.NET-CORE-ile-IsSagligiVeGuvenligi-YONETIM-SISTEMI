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
    public class YetkiController : Controller
    {
        private readonly isgContext _context;

        public YetkiController(isgContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("grubu") != null)
            {
                var Context = _context.Yetki.First();
            return View(Context);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(int id, [Bind("Id,firmafirmaekle,firmafirmasil,firmafirmaguncel,firmabirimekle,firmabirimsil,firmabirimguncel," +
            "firmapersonelekle,firmapersonelsil,firmapersonelguncel,firmailacekle,firmailaccsil,firmataniekle,firmatanisil,firmastatuekle,firmastatusil," +
            "hekimfirmaekle,hekimfirmasil,hekimfirmaguncel,hekimbirimekle,hekimbirimsil,hekimbirimguncel,hekimpersonelekle,hekimpersonelsil,hekimpersonelguncel," +
            "hekimilacekle,hekimilacsil,hekimtaniekle,hekimtanisil,hekimstatuekle,hekimstatusil," +
            "uzmanfirmaekle,uzmanfirmasil,uzmanfirmaguncel,uzmanbirimekle,uzmanbirimsil,uzmanbirimguncel,uzmanpersonelekle,uzmanpersonelsil,uzmanpersonelguncel," +
            "uzmanilacekle,uzmanilacsil,uzmantaniekle,uzmantanisil,uzmanstatuekle,uzmanstatusil")] YetkiKontrol yetki)
        {
            if (id != yetki.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yetki);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!yetkiExists(yetki.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }


            }
            return View(yetki);
        }


        private bool yetkiExists(int id)
        {
            return _context.Yetki.Any(e => e.Id == id);
        }

    }
}