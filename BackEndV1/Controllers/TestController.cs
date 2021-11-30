using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {

        }
        [HttpPost]
        public IEnumerable<string>Test()
        {
            try
            {
                return new string[] { "todo bien" };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
