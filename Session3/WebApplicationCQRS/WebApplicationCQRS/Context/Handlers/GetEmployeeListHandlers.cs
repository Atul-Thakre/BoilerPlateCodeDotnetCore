using MediatR;
using WebApplicationCQRS.Models;
using WebApplicationCQRS.Repository;

namespace WebApplicationCQRS.Context.Handlers
{
    public class GetEmployeeListHandlers : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepositort;

        public GetEmployeeListHandlers(IEmployeeRepository employeeRepositort)
        {
            _employeeRepositort=employeeRepositort;
        }
        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepositort.GetEmployeesListAsync();
        }
    }
}
