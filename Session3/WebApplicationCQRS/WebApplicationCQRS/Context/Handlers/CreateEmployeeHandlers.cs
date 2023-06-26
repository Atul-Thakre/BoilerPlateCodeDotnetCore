using MediatR;
using WebApplicationCQRS.Context.Command;
using WebApplicationCQRS.Models;
using WebApplicationCQRS.Repository;

namespace WebApplicationCQRS.Context.Handlers
{
    public class CreateEmployeeHandlers : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employeeRepositort;
        public CreateEmployeeHandlers(IEmployeeRepository employeeRepositort)
        {
            _employeeRepositort= employeeRepositort;
        }

        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee emp = new Employee()
            {
                Name = request.Name,
                Address = request.Address,
                Email = request.Email,
                Phone = request.Phone,

            };

            return await _employeeRepositort.AddEmployeeAsync(emp);

        }
    }
}
