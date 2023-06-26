using WebApplicationCQRS.Models;

namespace WebApplicationCQRS.Repository
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetEmployeesListAsync();
        public Task<Employee> GetEmployeeByIdAsync(int Id);
        public Task<Employee> AddEmployeeAsync(Employee employee);
        public Task<int> UpdateEmployeeAsync(Employee employee);
        
        public Task<int> DeleteEmployeeAsync(int Id);
    }
}
