using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_Assignment.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public float Degree { get; set; }


        [ForeignKey("Course")]
        public virtual int CrsID { get; set; }
        [ForeignKey("Trainee")]
        public virtual int TraineeID { get; set; }


        public virtual Trainee Trainee{ get; set;}
        public virtual Course Course { get; set;}
    }
}
