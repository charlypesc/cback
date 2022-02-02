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
    public class ReunionesController : ControllerBase
    {
        private readonly IReunionesService _reunionesService;
        public ReunionesController(IReunionesService reunionesService)
        {
            _reunionesService = reunionesService;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post(Reuniones reunion)
        {
            try
            {
                await _reunionesService.CreateReunion(reunion);
                return Ok(new { message = "Reunion ha sido registrada exitosamente!", reunionId = reunion.Id });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
        
        [Route("getReunion/{idReunion}")]
        [HttpGet]
        public async Task<IActionResult>Get(int idReunion)
        {
            try
            {
                var reunion = await _reunionesService.GetReunionById(idReunion);
                if (reunion == null)
                {
                    return Ok(new { message = "No se encuentra" });
                }
                return Ok(reunion);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        [HttpPut("ActualizaReunion")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>CambiarReunion([FromBody] Reuniones reuniones)
        {
            try
            {
                await _reunionesService.UpdateReuniones(reuniones);
                return Ok(new { message = "Reunion Actualizada", reunionId = reuniones.Id });

            }
            catch (Exception ex)
            {

               return BadRequest(ex.InnerException);
            }
        }
    }
}
