using MediatR;
using WebApplicationCQRS.Context.Command;
using WebApplicationCQRS.Models;
using WebApplicationCQRS.Repository;

namespace WebApplicationCQRS.Context.Handlers
{

    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand,int>
    {

        private readonly IEmployeeRepository _employeeRepositort;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepositort)
        {
            _employeeRepositort = employeeRepositort;
        }

        async Task<int> IRequestHandler<UpdateEmployeeCommand, int>.Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepositort.GetEmployeeByIdAsync(request.Id);
                if(employee == null) return default;
                employee.Name = request.Name;
            employee.Address = request.Address;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
            return await _employeeRepositort.UpdateEmployeeAsync(employee);

        }
    }
}
