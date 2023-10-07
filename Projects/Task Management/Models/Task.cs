using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
    public class Task
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [Required]
        public string TaskName { get; set; }

        public string TaskDescription { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public DateTime TaskTime { get; set; }
        public User User { get; set; }

    }
}

