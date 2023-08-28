using EmployeePortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.DAL
{
    public class ApplicationDbContext:DbContext
    {
        //Creating parameterized constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {

        }
        //mapping employee db with Employee class of Model
        public DbSet<Employee_new>Employees { get; set; }
        public DbSet<Login> LoginDetails { get; set; }
    }
}
