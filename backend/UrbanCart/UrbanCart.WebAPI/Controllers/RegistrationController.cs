using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UrbanCart.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        [HttpGet]
        public string getResult()
        {
            return "hi";       
        }
    }
}
