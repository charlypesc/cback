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
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BackEndV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService _estudianteService;
        public EstudianteController(IEstudianteService estudianteService)
        {
            _estudianteService = estudianteService;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<IActionResult> Post(Estudiante estudiante)
        {
            try
            {
                await _estudianteService.SaveEstudiante(estudiante);
                return Ok(new { message = " Estudiante registrado correctamente." });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{rut}")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Get(string rut)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var rutUsuario = await _estudianteService.GetEstudianteByRut(rut, rbd);

                if (rutUsuario == null)
                {
                    return Ok(new { message = " Rut no existe", codigo=0 });
                }

                return Ok(rutUsuario);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
