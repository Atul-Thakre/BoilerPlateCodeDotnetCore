using MediatR;
using WebApplicationCQRS.Models;

namespace WebApplicationCQRS.Context
{
    public class GetEmployeeByIdQuery:IRequest<Employee>
    {
        public int Id { get; set; } //we are writing Id property here so u can use Id here.
    }
}
