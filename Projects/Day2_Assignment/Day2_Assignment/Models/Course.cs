using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_Assignment.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinDegree { get; set; }


        [ForeignKey("Department")]
        public virtual int? DeptId { get; set; }


        public virtual Deparment Department { get; set; }
    }
}