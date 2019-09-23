using Microsoft.AspNetCore.Mvc;

namespace restapi.Controllers 
{

    [Route("api/[controller]")]
    [ApiController]
    public class TesteController: ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get(int id)
        {
            return "1.0.0.0";
        }

    }

}