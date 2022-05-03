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

            [HttpGet("{id}")]
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            public async Task<IActionResult> Get(int id)
            {
                try
                {
                    var seguimiento = await _seguimientoService.GetSeguimientoById(id);
                    if (seguimiento==null){
                        return Ok(new {message = "No hay seguimientos ingresados"} );
                    }else{
                        return Ok(seguimiento );
                    }

                }
                catch ( Exception ex)
                {
                    
                    return BadRequest (ex.InnerException);
                }
            }
            [HttpGet("getListSeguimiento/{rut}")]
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            public async Task<IActionResult> GetRutSeguimiento(string rut)
            {
                try
                {
                    var identity = HttpContext.User.Identity as ClaimsIdentity;
                    string rbd = JwtConfigurator.GetTokenRbd(identity);
                    var seguimiento = await _seguimientoService.GetListSeguimiento(rut, rbd);
                    if (seguimiento==null){
                        return Ok(new {message = "No hay seguimientos ingresados"} );
                    }else{
                        return Ok(seguimiento );
                    }

                }
                catch ( Exception ex)
                {
                    
                    return BadRequest (ex.InnerException);
                }
            }

        }
}
