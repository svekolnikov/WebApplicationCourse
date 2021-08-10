using Microsoft.AspNetCore.Mvc;
using Timesheets.DAL.Interfaces;
using Timesheets.Models;
using Timesheets.Requests;

namespace Timesheets.Controllers
{
    [Route("api/contract")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IRepository<Contract> _contractRepository;

        public ContractController(IRepository<Contract> contractRepository)
        {
            _contractRepository = contractRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateContractRequest request)
        {
            return Ok(_contractRepository.Add(new Contract
            {
                Name = request.Name
            }));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_contractRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_contractRepository.GetById(id));
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] UpdateContractRequest request)
        {
            return Ok(_contractRepository.Update(new Contract
            {
                Id = request.Id,
                Name = request.Name
            }));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _contractRepository.Delete(id);
            return Ok();
        }
    }
}
