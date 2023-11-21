using Microsoft.EntityFrameworkCore;
using MVC.Net2.Models;
using MVC.NET2.Models;

namespace MVC.Net2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person {get ; set ;}
        public DbSet<Student> Student {get ; set ;}
        public DbSet<Food> Food {get ; set ;}
    }
}