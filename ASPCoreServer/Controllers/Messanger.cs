using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Messanger : ControllerBase
    {
        
        // GET api/<Messanger>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "<h1>Ura</h1>" + id.ToString();
        }

        // POST api/<Messanger>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
