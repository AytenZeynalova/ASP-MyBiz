using ASP_MyBiz.DAL;
using ASP_MyBiz.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MyBiz.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProfessionController : Controller
    {
        private AppDbContext _context;

        public ProfessionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var profession = _context.Professions.ToList();
            return View(profession);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Profession profession)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Professions.Add(profession);
            _context.SaveChanges();

            return RedirectToAction("index");

        }

        public IActionResult Edit(int id)
        {
           var prof= _context.Professions.FirstOrDefault(x => x.ID == id);
            if (prof == null)
            {
                return RedirectToAction("error","dashboard");
            }
            return View(prof);
        }

        [HttpPost]

        public IActionResult Edit(Profession profession)
        {
            var existsProf = _context.Professions.FirstOrDefault(x => x.ID == profession.ID);
            if (existsProf == null)
            {
                return RedirectToAction("error", "dashboard");

            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existsProf.Name = profession.Name;
            _context.SaveChanges();
            return RedirectToAction("index"); 
        }

       public IActionResult Delete(int id)
        {
            var prof = _context.Professions.FirstOrDefault(x => x.ID == id);
            if (prof == null)
            {
                return RedirectToAction("error", "dashboard");

            }

            return View(prof);

        }

        [HttpPost]

        public IActionResult Delete(Profession profession)
        {
            var existprof = _context.Professions.FirstOrDefault(x => x.ID == profession.ID);
            if (existprof == null)
            {
                return RedirectToAction("error", "dashboard");

            }
            _context.Professions.Remove(existprof);

            _context.SaveChanges();

            return RedirectToAction("index");

        }

    }
}
