using Day_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Details(int id)
        {

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
