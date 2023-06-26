using Microsoft.EntityFrameworkCore;
using WebApplicationCQRS.Context;
using WebApplicationCQRS.Models;

namespace WebApplicationCQRS.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext=employeeDbContext;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result = _employeeDbContext.Employees.Add(employee);
                await _employeeDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int Id)
        {
            var findData = _employeeDbContext.Employees.Where(f => f.Id == Id).FirstOrDefault();
            _employeeDbContext.Employees.Remove(findData);
           return  await _employeeDbContext.SaveChangesAsync();



        }

        public async Task<Employee> GetEmployeeByIdAsync(int Id)
        {

            var findData = _employeeDbContext.Employees.Where(f => f.Id == Id).FirstOrDefault();
            return findData;
        }

        public async Task<List<Employee>> GetEmployeesListAsync()
        {
            var findData = await _employeeDbContext.Employees.ToListAsync();
            return findData;
        }

        public async Task<int> UpdateEmployeeAsync(Employee employee)
        {
            _employeeDbContext.Update(employee);
            return await _employeeDbContext.SaveChangesAsync();
        }
    }
}
