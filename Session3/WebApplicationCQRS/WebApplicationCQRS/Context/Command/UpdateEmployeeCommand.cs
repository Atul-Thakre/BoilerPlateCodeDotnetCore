using MediatR;

namespace WebApplicationCQRS.Context.Command
{
    public class UpdateEmployeeCommand:IRequest<int>
    {
        public UpdateEmployeeCommand(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public UpdateEmployeeCommand(int id, string name, string address, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
        }

        public UpdateEmployeeCommand(int id, string name, string email, string phone, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
