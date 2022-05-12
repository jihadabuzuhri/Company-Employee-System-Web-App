using CompanyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CompanyWebApp.Controllers
{
    public class LocController : Controller
    {
        private CompanyContext context { get; set; }

        public LocController(CompanyContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            //var item = context.Loc.Find(id);
            var item = context.Loc.OrderBy(m => m.LocID).ToList();
            return View("LocView",item);
        }


        public IActionResult FindLoc(int id)
        {
            var item = context.Loc.Find(id);
            return View("FindLocView", item);
        }



        public IActionResult SearchName(string SearchNameKey)
        {
            var item = context.Loc.Where(m => m.City.Contains(SearchNameKey)).OrderBy(m => m.LocID).ToList();
            return View("LocView", item);
        }





        [HttpGet]
        public IActionResult AddLoc()
        {
            return View("AddLocView", new Loc());
        }

        [HttpPost]
        public IActionResult AddLoc(Loc loc)
        {
            if (ModelState.IsValid)
            {

                context.Loc.Add(loc);
                context.SaveChanges();
                return RedirectToAction("Index", "Loc");
            }

            else
            {
                return View("AddLocView", loc);
            }

        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var loc = context.Loc.Find(id);
            return View("EditLocView", loc);
        }

        [HttpPost]
        public IActionResult Edit(Loc loc)
        {
            if (ModelState.IsValid)
            {

                context.Loc.Update(loc);
                context.SaveChanges();
                return RedirectToAction("Index", "Loc");
            }

            else
            {
                return View("EditLocView", loc);
            }

        }












        [HttpGet]
        public IActionResult Delete(int id)
        {
            var loc = context.Loc.Find(id);
            context.Loc.Remove(loc);
            context.SaveChanges();
            return RedirectToAction("Index", "Loc");
        }




    }
}
