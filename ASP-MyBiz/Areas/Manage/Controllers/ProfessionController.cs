using ASP_MyBiz.DAL;
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
    }
}
