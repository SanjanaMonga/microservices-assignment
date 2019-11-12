using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ChequeBookHandlingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Configurations configurations;
        public ValuesController(IOptions<Configurations> config)
        {
            configurations = config.Value;
        }
        // GET order-cheque-book/id
        [HttpGet("{id}")]
        public ActionResult<string> Order()
        {
            return configurations.Message;
        }
        // GET block-cheque-book/id
        [HttpGet("{id}")]
        public ActionResult<string> Block()
        {
            return configurations.Message;
        }
    }
}
