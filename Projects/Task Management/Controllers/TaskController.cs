using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Management.Repositories;

namespace Task_Management.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
         private readonly ITaskRepository _taskRepo;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public IActionResult Index()
        {
            return View(_taskRepo.GetAllTasks());
        }

        public IActionResult CreateTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTask(Models.Task task)
        {
            
            var errors = ModelState.ErrorCount;

            if (errors == 2)
            {
                _taskRepo.CreateTask(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }
        public IActionResult EditTask(int id)
        {
            return View(_taskRepo.GetTaskById(id));
        }
        [HttpPost]
        public IActionResult EditTask(Models.Task task, int id)
        {
            _taskRepo.UpdateTask(task, id);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTask(int id)
        {
            return View(_taskRepo.GetTaskById(id));
        }
        [HttpPost]
        public IActionResult DeleteTask(Models.Task task, int id)
        {
            _taskRepo.DeleteTask(id);
            return RedirectToAction("Index");
        }

        public IActionResult DetailsTask(int id)
        {
            return View(_taskRepo.GetTaskById(id));
        }
        
    }
}
