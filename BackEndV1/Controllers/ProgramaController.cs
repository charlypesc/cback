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
    public class ProgramaController: ControllerBase {
        private readonly IProgramaService _programaService;
        public ProgramaController(IProgramaService programaService)
        {
            _programaService = programaService;
        }
        //T R A E   T O D O S
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>GetProgramasAll()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);     

                var list = await _programaService.GetListProgramas(rbd);
                if(list.Count <=0 ){
                    return Ok(new {message = "El rbd no tiene programas ingresados"});
                }else{
                    return Ok(list);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);                
            }
        }
        [HttpGet]
        [Route("getId/{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult>GetProgramaId(int id)
        {
            try
            {
                var list = await _programaService.GetPrograma(id);
                if(list ==null ){
                    return Ok(new {message = "El id no tiene programa ingresado"});
                }else{
                    return Ok(list);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);                
            }
        }
        
        
        //C R E A
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> CreatePrograma(Programa programa)
        { 
            try
            {
                await _programaService.CreatePrograma(programa);
                return Ok(new {message= "Programa creado exitosamente"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);               
            }
        }
        // E L I M I N A
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> EliminarPrograma(int id)
        {
            try
            {
                var programa = await _programaService.GetPrograma(id);
                if(programa ==null){
                    return Ok(new { message="No hay programas creados" });
                }
                else{
                    await _programaService.EliminarPrograma(programa);
                    return Ok(new { message="Programa eliminado satisfactoriamente" });
                }
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.InnerException);

            }
        }
        // A C T U A L I Z A
        [HttpPut("actualiza")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> ActualizaPrograma([FromBody] Programa programa)
        {
            try
            {
                await _programaService.UpdatePrograma(programa);
                return Ok(new { message="Programa actualizado"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }
        }
    }
}