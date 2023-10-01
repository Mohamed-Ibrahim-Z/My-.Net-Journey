using Microsoft.EntityFrameworkCore;

namespace Day_1.Models
{
    public class Entities:DbContext
    {
        public Entities() 
        { 


        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
             .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Day1;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
