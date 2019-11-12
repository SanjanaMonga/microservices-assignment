using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace TransactionAPI.Controllers
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
        // GET withdraw/amount
        [HttpGet("{id}")]
        public ActionResult<string> Withdraw()
        {
            return configurations.Message;
        }
        // GET deposit/amount
        [HttpGet("{id}")]
        public ActionResult<string> Deposit()
        {
            return configurations.Message;
        }
        // GET transfer/amount
        [HttpGet("{id}")]
        public ActionResult<string> Transfer()
        {
            return configurations.Message;
        }
    }
}
