using Day_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    public class DeptController : Controller
    {
        public IActionResult Index()
        {
            Entities context = new Entities();
            List<Department> depts = context.Department.ToList();

            return View("index", depts);
        }
    }
}
