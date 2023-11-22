using ClassLibrary1PowerStartDDD.SimpleDomainLogics.TS.BLL.ShortURL;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1PowerStartDDD.SimpleDomainLogics.Ts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlsController : Controller
    {
        [HttpGet("GetAll")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Save")]
        public IActionResult Post(string url)
        {
            AddNewURL addNewURL = new();
            string code = addNewURL.Execute(url);
            return Ok(new
            {
                Code = code
            });
        }

        [HttpGet("Redirect")]
        public IActionResult Redirect(string code)
        {
            GetUrl getUrl = new();
            string url = getUrl.Execute(code);
            if(string.IsNullOrEmpty(url))
            {
                return BadRequest();
            }

            return Redirect(url);
        }
    }
}
