using MediatR;
using WebApplicationCQRS.Models;

namespace WebApplicationCQRS.Context
{
    public class GetEmployeeListQuery:IRequest<List<Employee>>
    {
    }
}
