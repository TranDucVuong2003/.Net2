using Microsoft.EntityFrameworkCore;
using MVC.NET2.Models;

namespace MVC.Net2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person {get ; set ;}
        public DbSet<Student> Student {get ; set ;}
    }
}