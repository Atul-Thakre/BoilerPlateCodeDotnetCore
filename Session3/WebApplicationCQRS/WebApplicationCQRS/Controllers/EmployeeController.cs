﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCQRS.Context;
using WebApplicationCQRS.Context.Command;
using WebApplicationCQRS.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }



        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<List<Employee>> EmployeeList()
        {
            var employeelist = await _mediator.Send(new GetEmployeeListQuery());
            return employeelist;        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<Employee> EmployeeById(int id)
        {
            var employee = await _mediator.Send(new GetEmployeeByIdQuery() { Id=id});
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var employeeReturn = await _mediator.Send(new CreateEmployeeCommand(
                employee.Name, employee.Address, employee.Phone));
            return employeeReturn;


        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            var employeeReturn = await _mediator.Send(new UpdateEmployeeCommand(employee.Id,
                employee.Name, employee.Address, employee.Phone));
            return employeeReturn;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await _mediator.Send(new DeleteEmployeeCommand { Id = id });
        }
    }
}
