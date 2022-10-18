using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public List<Rock> Rocks { get; set; }
        public List<Niddle> Niddles { get; set; }
        public List<Myinventory> Myinventorys { get; set; }
        Myinventory my = new Myinventory();

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _context = db;
        }

        [HttpPost]
        public async Task<IActionResult> Add(string a, string b, string c)
        {
            my.UserName = a;
            my.ProductName = b;
            if (c == "Rock")
            {
                if (ModelState.IsValid)
                {
                    _context.Myinventorys.Add(my);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("RockCatalog");
                }
            } else if (c == "Niddle")
            {
                if (ModelState.IsValid)
                {
                    _context.Myinventorys.Add(my);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("NiddleCatalog");
                }

            }
            return RedirectToAction("Shoes");
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyInv()
        {
            ViewBag.Name = "Мои зачарования";
            Rocks = _context.Rocks.AsNoTracking().ToList();
            Niddles = _context.Niddles.AsNoTracking().ToList();
            Myinventorys = _context.Myinventorys.AsNoTracking().ToList();
            var model = Tuple.Create<IEnumerable<Rock>, IEnumerable<Niddle>, IEnumerable<Myinventory>>(Rocks, Niddles, Myinventorys);
            return View(model);
        }

        public IActionResult RockCatalog()
        {
            ViewBag.CatalogName = "Зачарованные камни";
            Rocks = _context.Rocks.AsNoTracking().ToList();
            return View(Rocks);
        }

        public IActionResult NiddleCatalog()
        {
            ViewBag.CatalogName = "Зачарованные иголки";
            Niddles = _context.Niddles.AsNoTracking().ToList();
            return View(Niddles);
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
