using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
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
    public class TematicasController : ControllerBase
    {
        private readonly ITematicasService _tematicasService;
        public TematicasController(ITematicasService tematicasService)
        {
            _tematicasService = tematicasService;
        }
        //C R E A 
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>Post([FromBody] Tematicas tematicas)
        {
            try
            {

                await _tematicasService.CreateTematicas(tematicas);
                return Ok(new { message = "Tematica se agrego correctamente" });

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        //B U S C A   R B D
        [HttpGet("{rbd}")]
        public async Task<IActionResult> Get(string rbd)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var protocolos = await _tematicasService.GetTematicas(rbd);
                return Ok(protocolos);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        // B U S C A   P O R    I D 
        [Route("getTematica/{idTematica}")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Get(int idTematica)
        {
            try
            {

                var tematica = await _tematicasService.GetTematicaById(idTematica);
                if (tematica == null)
                {
                    return Ok(new { message = "Tematica no existe" });
                }
                return Ok(tematica);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //E L I M I N A
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {

                var tematica = await _tematicasService.GetTematicaById(id);
                if (tematica == null)
                {
                    return BadRequest(new { message = "No se encontro la Tematica" });
                }
                await _tematicasService.DeleteTematica(tematica);
                return Ok(new { message = "Se elimino la tematica" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        //A C T U A L I Z A

        [HttpPut("actualizaTematica")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> ActualizaTematica([FromBody] Tematicas actualizaTematica)
        {
            try
            {
                await _tematicasService.UpdateTematica(actualizaTematica);
                return Ok(new { message = "Tematica Actualizada" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
