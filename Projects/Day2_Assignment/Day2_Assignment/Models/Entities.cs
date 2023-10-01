using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace Day2_Assignment.Models
{
    public class Entities : DbContext
    {
        public Entities() { }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Deparment> Deparments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source = MOHAMED\SQLEXPRESS; Initial Catalog=Day2; Integrated Security = True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
