using BackEndV1.Domain.IService;
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
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;
        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetCursos()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var ano = DateTime.Now.Year;
                var cursos = await _cursoService.GetCursos(rbd, ano);
                if (cursos.Count == 0)
                {
                    return Ok(new { message = "No se encuentran los cursos" });
                }
                else {
                    return Ok(cursos);
                }
            }
            catch (Exception ex)
            {

                return BadRequest (ex.InnerException);
            }
        }
    }
}
