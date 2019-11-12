using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace UserAPI.Controllers
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
        // GET register-customer
        [HttpGet]
        public ActionResult<string> Get()
        {
            return configurations.Message;
        }

        // GET update-customer/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException(nameof(id));
            }
            return configurations.Message;
        }
    }
}
