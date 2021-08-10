using Microsoft.AspNetCore.Mvc;
using Timesheets.DAL.Interfaces;
using Timesheets.Models;
using Timesheets.Requests;

namespace Timesheets.Controllers
{
    [Route("api/job")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IRepository<Job> _jobRepository;

        public JobController(IRepository<Job> jobRepository)
        {
            _jobRepository = jobRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateJobRequest request)
        {
            return Ok(_jobRepository.Add(new Job
            {
                Name = request.Name
            }));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_jobRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_jobRepository.GetById(id));
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] UpdateJobRequest request)
        {
            return Ok(_jobRepository.Update(new Job
            {
                Id = request.Id,
                Name = request.Name
            }));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _jobRepository.Delete(id);
            return Ok();
        }
    }
}
