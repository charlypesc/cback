using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class defaultController : ControllerBase
    {
        // GET: api/<DefaultController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "AppV-1.5 UP" };
        }

    }
}
