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
    public class RegistroController : ControllerBase
    {
        private readonly IRegistroService _registroService;
        public RegistroController(IRegistroService registroService)
        {
            _registroService = registroService;
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post([FromBody] Registro registro)
        {
            try
            {


                await _registroService.CreateRegistro(registro);
                //invocar metodo que trae el ultimo con folio registro



                //a ese numero de folio debo sumarle 1
                return Ok(new { message = "El numero de registro es "+registro.Id, numeroRegistro = registro.Id  });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
       //lleva todos los registros al panel de busqueda
        [HttpGet("{rutParticipante}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Get(string rutParticipante)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var listParticipante = await _registroService.GetRegistroByRut(rutParticipante, rbd);
                if (listParticipante.Count== 0)
                {
                    return Ok(new { message = "No se encuentra registro o estudiante no existe", codigo = 0 });
                }
                else { return Ok(listParticipante); }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //lleva el detalle de cada registro
        [Route("getRegistro/{idRegistro}")]
        [HttpGet]
        public async Task<IActionResult>Get(int idRegistro)
        {
            try
            {
                var registroCompleto = await _registroService.GetRegistro(idRegistro);
                if (idRegistro == 0)
                {
                    return Ok(new { messagge = "llego pero llega nulo" });
                }
                return Ok(registroCompleto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [Route("deleteReg/{idReg}")]
        [HttpDelete]
        public async Task<IActionResult>EliminarRegistro(int idReg)
        {
            try
            {
                //buscar registro por id

               var registro = await _registroService.BuscarRegistro(idReg);

                if(registro != null)
                {
                    await _registroService.EliminarRegistro(registro);
                    return Ok(new { message = "El registro ha sido eliminado" });
                }
                return Ok(new { message = "El registro no fue encontrado" });
                //eliminar el registro




            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("folioRegistro/{rbd}")]
        [HttpGet]
        
            public async Task<IActionResult>GetRegistrosAll(string rbd)
            {
                try
                {
                    var registrosAll = await _registroService.GetRegistrosAll(rbd);

                if (registrosAll.Count >= 1 )
                {
                    var ultimo = registrosAll.LastOrDefault();
                    return Ok(ultimo.Folio);
                }
                else
                {
                    var ultimo = registrosAll.LastOrDefault();
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
