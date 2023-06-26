using Microsoft.EntityFrameworkCore;
using WebApplicationCQRS.Models;

namespace WebApplicationCQRS.Context
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options)
        {
                
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
