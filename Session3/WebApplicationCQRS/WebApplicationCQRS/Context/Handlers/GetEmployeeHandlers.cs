using MediatR;
using WebApplicationCQRS.Models;
using WebApplicationCQRS.Repository;

namespace WebApplicationCQRS.Context.Handlers
{
    public class GetEmployeeHandlers : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepositort;

        public GetEmployeeHandlers(IEmployeeRepository employeeRepositort)
        {
            _employeeRepositort = employeeRepositort;
        }
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepositort.GetEmployeeByIdAsync(request.Id);

        }
    }
}
