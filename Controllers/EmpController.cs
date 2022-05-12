using CompanyWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CompanyWebApp.Controllers
{
    public class EmpController : Controller
    {

        private CompanyContext context { get; set; }

        public EmpController(CompanyContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var item = context.Emp.Include(m => m.dept).OrderBy(m => m.EmpID).ToList();

            return View("EmpView", item);

            //var item = context.Emp.OrderBy(m => m.EmpID).ToList();
            //return View();

        }


        public IActionResult SearchName(string SearchNameKey)
        {
            var item = context.Emp.Where(m => m.Ename.Contains(SearchNameKey)).Include(m => m.dept).OrderBy(m => m.EmpID).ToList();

            return View("EmpView", item);

            //var item = context.Emp.OrderBy(m => m.EmpID).ToList();
            //return View();

        }







        [HttpGet]
        public IActionResult AddEmp()
        {
            ViewBag.Dept = context.Dept.Include(m => m.loc).OrderBy(m => m.DeptID).ToList();
            return View("AddEmpView", new Emp());
        }

        [HttpPost]
        public IActionResult AddEmp(Emp emp)
        {
            if (ModelState.IsValid)
            {
                
                context.Emp.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index", "Emp");
            }

            else
            {
                ViewBag.Dept = context.Dept.Include(m => m.loc).OrderBy(m => m.DeptID).ToList();
                return View("AddEmpView", emp);
            }

        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Dept = context.Dept.Include(m => m.loc).OrderBy(m => m.DeptID).ToList();
            var emp = context.Emp.Find(id);
            return View("EditEmpView", emp);
        }


        [HttpPost]
        public IActionResult Edit(Emp emp)
        {
            if (ModelState.IsValid)
            {
                context.Emp.Update(emp);
                context.SaveChanges();
                return RedirectToAction("Index", "Emp");
            }
            else
            {
                ViewBag.Dept = context.Dept.Include(m => m.loc).OrderBy(m => m.DeptID).ToList();
                return View("EditEmpView", emp);
            }
        }







        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = context.Emp.Find(id);
            context.Emp.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index", "Emp");
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(LoginData logdata)
        {
            Emp emp = context.Emp.Include(e => e.dept).FirstOrDefault(e => e.Ename.Equals(logdata.UserName) && e.EmpID.ToString().Equals(logdata.Password));
            if (emp != null)
            {
                HttpContext.Session.SetString("UserName", emp.Ename);
                HttpContext.Session.SetInt32("Password", emp.EmpID);

                //var item = context.Emp.Include(m => m.dept).OrderBy(m => m.EmpID).ToList();

                //return View("EmpView", item);
                return RedirectToAction("Index", "Home");


            }
            else return View("Login");

        }



        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }









    }
}
