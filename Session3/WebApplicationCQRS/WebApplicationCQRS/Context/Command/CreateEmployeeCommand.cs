﻿using MediatR;
using WebApplicationCQRS.Models;

namespace WebApplicationCQRS.Context.Command
{
    public class CreateEmployeeCommand:IRequest<Employee>
    {
        public CreateEmployeeCommand(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public CreateEmployeeCommand(string name, string email, string phone, string address)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
