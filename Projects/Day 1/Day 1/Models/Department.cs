using System.Diagnostics.CodeAnalysis;

namespace Day_1.Models
{
    public class Department
    {
        public int ID { get; set; }
        [DisallowNull]
        public string Name { get; set; }
        [DisallowNull]

        public string ManagerName { get; set; }
    }
}
