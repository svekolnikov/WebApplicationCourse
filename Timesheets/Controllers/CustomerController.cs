using Microsoft.AspNetCore.Mvc;
using Timesheets.DAL.Interfaces;
using Timesheets.Models;
using Timesheets.Requests;

namespace Timesheets.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerController(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateCustomerRequest request)
        {
            return Ok(_customerRepository.Add(new Customer
            {
                Name = request.Name
            }));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_customerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_customerRepository.GetById(id));
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] UpdateCustomerRequest request)
        {
            return Ok(_customerRepository.Update(new Customer
            {
                Id = request.Id,
                Name = request.Name
            }));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _customerRepository.Delete(id);
            return Ok();
        }
    }
}
