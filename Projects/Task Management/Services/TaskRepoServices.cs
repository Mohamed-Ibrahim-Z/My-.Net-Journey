using System.Security.Claims;
using Task_Management.Data;
using Task_Management.Models;
using Task_Management.Repositories;

namespace Task_Management.Services
{
    public class TaskRepoServices : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string UserId;

        public TaskRepoServices(ApplicationDbContext context)
        {
            _context = context;
            HttpContext httpContext = new HttpContextAccessor().HttpContext;
            UserId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public void CreateTask(Models.Task task)
        {
            task.UserId = UserId;
            task.User = _context.Users.Find(UserId);
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            Models.Task task = _context.Tasks.Find(id);
            if (task != null && UserId == task.UserId)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public List<Models.Task> GetAllTasks()
        {
            
            return _context.Tasks.Where(x => x.UserId == UserId).ToList();
        }

        public Models.Task GetTaskById(int id)
        {
            var task = _context.Tasks.Where(x => x.UserId == UserId && x.Id == id);
            if(task != null)
                return task.FirstOrDefault();
            else
                return null;


        }


        public void UpdateTask(Models.Task task, int id)
        {
            Models.Task updatedTask = _context.Tasks.FirstOrDefault(x => x.Id == id);
            if (updatedTask != null && updatedTask.UserId == UserId)
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
