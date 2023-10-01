using Day2_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2_Assignment.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", new Entities().Instructors.ToList());
        }
        public IActionResult Details(int id)
        {
            return View("Details", new Entities().Instructors.Find(id));
        }
    }
}
