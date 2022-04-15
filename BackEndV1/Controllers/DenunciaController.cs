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
    public class DenunciaController : ControllerBase
    {
        private readonly IDenunciaService _denunciaService;
        public DenunciaController(IDenunciaService denunciaService)
        {
            _denunciaService = denunciaService;
        }

        // C R E A    D E N U N C I A 
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> CreandoDenuncia([FromBody] Denuncia denuncia)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                int idUsuario = JwtConfigurator.GetTokenIdUsuario(identity);
                denuncia.FechaIngreso = DateTime.Now;
                await _denunciaService.CreateDenuncia(denuncia);
                return Ok(new { message = "Denuncia agregada correctamente", denunciaId = denuncia.Id });

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        // B U S C A   P O R   I D --- P A S O 2
        [Route("DenunciaId/{DenunciaId}")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetDenunciaById(int denunciaId)
        {
            try
            {
                var denuncia = await _denunciaService.GetDenunciaById(denunciaId);
                return Ok(denuncia);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //B U S C A    P O R   I D   P A S O 3
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetDenuncia(int id)
        {
            try
            {
                var denuncia = await _denunciaService.GetDenuncia(id);
                return Ok(denuncia);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }    


        //A C T U A L I Z A   R E G I S T R O
        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> UpdateDenuncia([FromBody] Denuncia denuncia)
        {
            try
            {
                await _denunciaService.ActualizaDenuncia(denuncia);
                return Ok(new { message = "Se actualizo la denuncia exitosamente" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        [Route("folioDenuncia/{rbd}")]
        [HttpGet]
        
            public async Task<IActionResult>GetRegistrosAll(string rbd)
            {
                try
                {
                    var denunciasAll = await _denunciaService.GetDenunciasAll(rbd);

                if (denunciasAll.Count >= 1 )
                {
                    var ultimo = denunciasAll.LastOrDefault();
                    return Ok(ultimo.FolioInterno);
                }
                else
                {
                    var ultimo = denunciasAll.LastOrDefault();
                    return Ok(1);
                }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.InnerException);
                    
                }
            }

    }
}
