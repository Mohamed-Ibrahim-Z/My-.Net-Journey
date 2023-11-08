using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public enum TaskStatus
    {
        [Display(Name = "Not Started")]
        NotStarted,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Completed
    }
    public class Task
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }
        [Display(Name = "Task Status")]
        public TaskStatus TaskStatus { get; set; }
        [Display(Name = "Task Time")]
        public DateTime TaskTime { get; set; }
        public User User { get; set; }

    }
}

