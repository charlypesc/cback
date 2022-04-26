using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using BackEndV1.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BackEndV1.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class SeguimientoController: ControllerBase
        {
            private readonly ISeguimientoService _seguimientoService;
            public SeguimientoController(ISeguimientoService seguimientoService)
            {
                _seguimientoService = seguimientoService;
            }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post([FromBody] Seguimiento seguimiento)
        {
            try
            {
                await _seguimientoService.CreateSeguimiento(seguimiento);
                return Ok(new { message = "Seguimiento ingresado",  numSeguimiento = seguimiento.Id });
            }
            catch ( Exception ex)
            {
                
                return BadRequest (ex.InnerException);
            }
        }

        }
}
