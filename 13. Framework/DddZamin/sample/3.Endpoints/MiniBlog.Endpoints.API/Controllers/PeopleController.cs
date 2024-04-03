using DddZamin.EndPoints.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.Domain.People.ValueObjects;
using MiniBlog.Core.RequestResponse.People.Commands.Create;

namespace MiniBlog.Endpoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : BaseController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public PeopleController()
        {
            
        }

        [HttpGet(Name = "GetValueObjectEQ")]
        public IActionResult Get()
        {
            FirstName firstName01 = "Alireza1";
            FirstName firstName02 = "Alireza";

            return Ok(firstName01 == firstName02);

        }

        [HttpGet("/GetLenException")]
        public IActionResult GetLenException()
        {
            try
            {
                FirstName firstName = new FirstName("a");
                return Ok("Ok");
            }
            catch (Exception ex)
            {
                return Ok(ex.ToString());
            }

          
        }

        [HttpPost("/CreatePerson")]
        public async Task<IActionResult> CreatePerson([FromBody] CreatePerson createPerson)
        {

            return await Create<CreatePerson, int>(createPerson);

        }
    }
}
