using Day_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Details(int id)
        {
            Student student = StudentList.Students.FirstOrDefault(s => s.ID.Equals(id));

            return View("Details", student);
        }
        public IActionResult Index()
        {
            return View("Index", StudentList.Students);
        }
    }
}
