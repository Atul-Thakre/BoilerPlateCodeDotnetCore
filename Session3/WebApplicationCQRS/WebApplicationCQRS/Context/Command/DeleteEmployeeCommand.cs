using MediatR;

namespace WebApplicationCQRS.Context.Command
{
    public class DeleteEmployeeCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
