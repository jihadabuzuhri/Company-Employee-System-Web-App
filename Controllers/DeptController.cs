using CompanyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CompanyWebApp.Controllers
{
    public class DeptController : Controller
    {
        private CompanyContext context { get; set; }

        public DeptController(CompanyContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var item = context.Dept.Include(m => m.loc).OrderBy(m => m.DeptID).ToList();

            
            return View("DeptView",item);
        }

        public IActionResult FindDept(int id)
        {
            var item = context.Dept.Find(id);
            return View("FindDeptView", item);
        }


        public IActionResult SearchName(string SearchNameKey)
        {

            var item = context.Dept.Where(m => m.Dname.Contains(SearchNameKey)).Include(m => m.loc).OrderBy(m => m.DeptID).ToList();

            return View("DeptView", item);
        }





        [HttpGet]
        public IActionResult AddDept()
        {
            ViewBag.Loc = context.Loc.OrderBy(m => m.LocID).ToList();
            return View("AddDeptView", new Dept());
        }

        [HttpPost]
        public IActionResult AddDept(Dept dept)
        {
            if (ModelState.IsValid)
            {

                context.Dept.Add(dept);
                context.SaveChanges();
                return RedirectToAction("Index", "Dept");
            }

            else
            {
                ViewBag.Loc = context.Loc.OrderBy(m => m.LocID).ToList();
                return View("AddDeptView", dept);
            }

        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Loc = context.Loc.OrderBy(m => m.LocID).ToList();
            var dept = context.Dept.Find(id);
            return View("EditDeptView", dept);
        }


        [HttpPost]
        public IActionResult Edit(Dept dept)
        {
            if (ModelState.IsValid)
            {
                context.Dept.Update(dept);
                context.SaveChanges();
                return RedirectToAction("Index", "Dept");
            }
            else
            {
                ViewBag.Loc = context.Loc.OrderBy(m => m.LocID).ToList();
                return View("EditDeptView", dept);
            }
        }












        [HttpGet]
        public IActionResult Delete(int id)
        {
            var dept = context.Dept.Find(id);
            context.Dept.Remove(dept);
            context.SaveChanges();
            return RedirectToAction("Index", "Dept");
        }





    }
}
