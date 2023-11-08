using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_Assignment.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }


        [ForeignKey("Department")]
        public virtual int DeptId { get; set; }
        [ForeignKey("Course")]
        public virtual int CrsId { get; set; } 


        public virtual Deparment Department { get; set; }
        public virtual Course Course { get; set; }
    }
}
