using Day_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    public class DeptController : Controller
    {
        Entities context = new Entities();

        public IActionResult SaveDept(Department dept)
        {
            if (dept.Name != null && dept.Name != null)
            {
                context.Department.Add(dept);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dept);
        }
        public IActionResult AddDept()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<Department> depts = context.Department.ToList();

            return View("index", depts);
        }
    }
}
