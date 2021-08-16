using Microsoft.AspNetCore.Mvc;
using Timesheets.DAL.Interfaces;
using Timesheets.Models;
using Timesheets.Requests;

namespace Timesheets.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeController(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateEmployeeRequest request)
        {
            return Ok(_employeeRepository.Add(new Employee
            {
                Name = request.Name
            }));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_employeeRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_employeeRepository.GetById(id));
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] UpdateEmployeeRequest request)
        {
            return Ok(_employeeRepository.Update(new Employee
            {
                Id = request.Id,
                Name = request.Name
            }));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeeRepository.Delete(id);
            return Ok();
        }
    }
}
