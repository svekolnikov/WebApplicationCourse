using Microsoft.AspNetCore.Mvc;
using Timesheets.DAL.Interfaces;
using Timesheets.Models;
using Timesheets.Requests;

namespace Timesheets.Controllers
{
    [Route("api/invoice")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IRepository<Invoice> _invoiceRepository;

        public InvoiceController(IRepository<Invoice> invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        
        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateContractRequest request)
        {
            return Ok(_invoiceRepository.Add(new Invoice
            {
                Name = request.Name
            }));
        }

        [HttpGet("{contractId}")]
        public IActionResult GetInvoice(int contractId)
        {
            return Ok();
        }
    }
}
