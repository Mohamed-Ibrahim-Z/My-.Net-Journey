using Day2_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2_Assignment.Controllers
{
    public class InstructorController : Controller
    {
        Entities entities = new Entities();
        public IActionResult Index()
        {
            return View("Index", entities.Instructors);
        }
        public IActionResult Details(int id)
        {
            return View("Details", new Entities().Instructors.Find(id));
        }
    }
}
