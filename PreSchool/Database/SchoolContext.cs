using PreSchool.Models;
using Microsoft.EntityFrameworkCore;

namespace PreSchool.Database
{
    public class SchoolContext : DbContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MEPreSchool;Trusted_Connection=True;");
        }
    }
}