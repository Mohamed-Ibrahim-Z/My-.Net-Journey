using System.Security.Claims;
using Task_Management.Data;
using Task_Management.Models;
using Task_Management.Repositories;

namespace Task_Management.Services
{
    public class TaskRepoServices : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepoServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateTask(Models.Task task)
        {
            HttpContext httpContext = new HttpContextAccessor().HttpContext;
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            task.UserId = userId;
            task.User = _context.Users.Find(userId);
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            Models.Task task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public List<Models.Task> GetAllTasks()
        {
            HttpContext httpContext = new HttpContextAccessor().HttpContext;
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _context.Tasks.Where(x => x.UserId == userId).ToList();
        }

        public Models.Task GetTaskById(int id)
        {
            return _context.Tasks.Find(id);

        }


        public void UpdateTask(Models.Task task, int id)
        {
            Models.Task updatedTask = _context.Tasks.FirstOrDefault(x => x.Id == id);
            if (updatedTask != null)
            {
                updatedTask.TaskTime = task.TaskTime;
                updatedTask.TaskName = task.TaskName;
                updatedTask.TaskStatus = task.TaskStatus;
                updatedTask.TaskDescription = task.TaskDescription;
                _context.SaveChanges();
            }
        }

        
    }
}
