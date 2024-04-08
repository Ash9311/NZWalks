using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllStudents() {

            string[] studentNames = new string[] { "John", "ASh", "Mark", "dolu", "bolu" };
            return Ok(studentNames);
        }
    }
}
