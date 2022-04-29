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
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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

        //TRAER ESTUDIANTES POR RBD Y ANO ACTUAL CURSANDO
        [Route("getEstudiantes")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetEstudiantesRbdAno()
        {
            try
            {
                var ano = DateTime.Now.Year;
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var estudiantes = await _estudianteService.GetEstudiantesByRbdByAno(rbd, ano);
                if (estudiantes == null)
                {
                    return Ok(new { message = "No se encuentran estudiantes", codigo=0 });
                }
                else{
                    return Ok(estudiantes);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        //T R A E R    E S T U D I A N T E S    P O R     R B D    Y   A N O   A C T U A L     C U R S A N D O + C U R S O
        [Route("getEstudiantes/{curso}")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetEstudiantesRbdAno(string curso)
        {
            try
            {
                var ano = DateTime.Now.Year;
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var estudiantes = await _estudianteService.GetEstudiantesByRbdByAnoByCurso(rbd, ano, curso);
                if (estudiantes == null)
                {
                    return Ok(new { message = "No se encuentran estudiantes", codigo = 0 });
                }
                else
                {
                    return Ok(estudiantes);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        //  E S T U D I A N T E    P O R    I D
        [Route("getEstudianteId/{id}")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        public async Task<IActionResult> GetEstudianteId(int id) 
        {
            try
            {
                var estudianteId = await _estudianteService.GetEstudianteById(id);
                if (estudianteId == null)
                {
                    return Ok(new { message = "No existe estudiante bajo ese id" });
                }
                else {
                    return Ok(estudianteId);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        // A C T U A L I Z A 
        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> ActualizaEstudiante([FromBody] Estudiante estudiante)
        {
            try
            {
                await _estudianteService.UpdateEstudiante(estudiante);
                return Ok(new { message = "Estudiante Actualizado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        // Q U I T A   E S T U D I A N T E

        
        [HttpDelete("{idReg}")]
        public async Task<IActionResult> Elimina(int idReg)
        {
            try
            {

                var estudiante = await _estudianteService.GetEstudianteById(idReg);
                if ( estudiante == null)
                {
                    return Ok(new { message = "No se encuentra el estudiante" });
                }
                await _estudianteService.EliminaEstudiante(estudiante);
                return Ok(new { message = "Estudiante eliminado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
        [Route("getSiguiendo")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>GetSiguiendo(){
            try
            {
                var ano = DateTime.Now.Year;
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var siguiendo = await _estudianteService.GetEstudiantesSeguimiento(1, rbd, ano);
                if(siguiendo.Count <=0){
                    return Ok(new {message = "Este establecimiento no registra estudiantes en seguimiento"});
                }
                return Ok(siguiendo);
            }
            catch (Exception ex)
            {
                
                return BadRequest (ex.InnerException);
            }
        }
        
    }
}
