using Task_Management.Models;
// q: how to make the compiler uses the task model insted of the task entity by default
// a: 
namespace Task_Management.Repositories
{
    public interface ITaskRepository
    {
        public void CreateTask(Models.Task task);
        public List<Models.Task> GetAllTasks();
        public Models.Task GetTaskById(int id);
        public void UpdateTask(Models.Task task, int id);
        public void DeleteTask(int id);

    }
}
