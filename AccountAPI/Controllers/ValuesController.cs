using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Configurations configurations;
        ILogger logger;
        public ValuesController(IOptions<Configurations> config, ILogger<ValuesController> loggerFactory)
        {
            configurations = config.Value;
            logger = loggerFactory;
        }
        // GET api/create-account
        [HttpGet("create-account")]
        public ActionResult<string> Get()
        {
        // Although it should be a POST call, kept GET to check easily with browser
            logger.LogInformation(1,"Account api get called");
            return "Hi from account API";
        }

        // GET api/view-details/5
        [HttpGet("view-details/{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException(nameof(id));
            }

            return configurations.Message;
        }

        // GET api/close-account
        [HttpGet("close-account")]
        public ActionResult<string> CloseAccount()
        {
        // Although it should be a POST call, kept GET to check easily with browser
            logger.LogInformation(1, "Account api close account called");
            return configurations.Message;
        }
    }
}
