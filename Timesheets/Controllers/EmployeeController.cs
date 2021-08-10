using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    public class EmployeeController : ControllerBase
    {
        public IActionResult CreateEmployee([FromBody] CreateEmployeeRequest request)
        {

        }
    }
}
