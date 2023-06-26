using MediatR;
using WebApplicationCQRS.Context.Command;
using WebApplicationCQRS.Repository;

namespace WebApplicationCQRS.Context.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepositort;

        public DeleteEmployeeHandler(IEmployeeRepository employeeRepositort)
        {
            _employeeRepositort = employeeRepositort;
        }

        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepositort.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;
            return await _employeeRepositort.DeleteEmployeeAsync(request.Id);

        }
    }
}
