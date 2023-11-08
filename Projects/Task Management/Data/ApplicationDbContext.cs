using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task_Management.Models;

namespace Task_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users","Task");
            builder.Entity<IdentityRole>().ToTable("Roles", "Tasks");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Tasks");
            builder.Entity<IdentityUserClaim<string>>().ToTable("userClaims","Tasks");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins","Tasks");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims","Tasks");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens","Tasks");

        }
    }
}