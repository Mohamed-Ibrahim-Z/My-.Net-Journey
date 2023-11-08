using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_Assignment.Models
{
    public class Trainee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public float Grade { get; set; }


        [ForeignKey("Department")]
        public virtual int DeptId { get; set; }


        public virtual Deparment Deparment{ get; set; }
    }
}
