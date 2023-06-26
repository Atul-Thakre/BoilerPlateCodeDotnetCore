using BoilerPlateMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateMvc.Context
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
