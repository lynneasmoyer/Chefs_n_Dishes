using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using ChefsNDishes.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;

        public HomeController(HomeContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Chef> ChefsWithDishes = dbContext.Chefs.OrderByDescending(d => d.CreatedAt).Include(c => c.CreatedDishes).ToList();
            return View(ChefsWithDishes);
        }

        [HttpGet("dishes")]

        public IActionResult Dishes()
        {
            List<Dish> DishesWithChefs = dbContext.Dishes.Include(c => c.Creator).OrderBy(d => d.Tastiness).ToList();
            return View(DishesWithChefs);
        }

        [HttpGet("add/chef")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpPost("process/chef")]

        public IActionResult ProccessChef(Chef AddaChef)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Chefs.Any(c => c.FirstName == AddaChef.FirstName && c.LastName == AddaChef.LastName))
                {
                    ModelState.AddModelError("Name", "That chef's name is already added!");
                    return View("Index");
                }
                else
                {
                    dbContext.Chefs.Add(AddaChef);
                    dbContext.SaveChanges();

                    return Redirect("/");
                }
            }
            else
            {
                return View("AddChef");
            }

        }

        [HttpGet("add/dish")]

        public IActionResult AddDish()
        {
            List<Chef> Allchefs = dbContext.Chefs.OrderByDescending(c => c.FirstName).ToList();
            ViewBag.Chefs = Allchefs;
            return View();
        }

        [HttpPost("process/dish")]

        public IActionResult ProccessDish(Dish AddaDish)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Dishes.Any(d => d.Name == AddaDish.Name))
                {
                    ModelState.AddModelError("Name", "That dish has already been added!");
                    return View("AddDish");
                }
                else
                {
                    dbContext.Dishes.Add(AddaDish);
                    dbContext.SaveChanges();
                    return Redirect("/");
                }
            }
            else
            {
                return View("AddDish");
            }
        }

















////////////////////////////////////////
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
