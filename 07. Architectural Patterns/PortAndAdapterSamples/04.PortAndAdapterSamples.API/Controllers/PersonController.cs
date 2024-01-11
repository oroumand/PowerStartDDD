using _01.PortAndAdapterSamples.Domain.People;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _04.PortAndAdapterSamples.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetPerson()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult SavePerson(Person person)
        {
            return Ok(person);
        }
    }
}
