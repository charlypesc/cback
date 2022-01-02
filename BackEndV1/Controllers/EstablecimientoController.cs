using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
    public class EstablecimientoController : ControllerBase
    {
        private readonly IEstablecimientoService _establecimientoService;
        public EstablecimientoController(IEstablecimientoService establecimiento)
        {
            _establecimientoService = establecimiento;
        }
        // C R E A    E S T A B L E C I M I E N T O
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<IActionResult>Post([FromBody]Establecimiento establecimiento)
        {
            try
            {

                await _establecimientoService.SaveEstablecimiento(establecimiento);
                return Ok(new { message = "Se agrego el establecimiento" });

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
