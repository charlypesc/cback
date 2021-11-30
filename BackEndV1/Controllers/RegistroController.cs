using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> Post([FromBody] Registro registro)
        {
            try
            {


                await _registroService.CreateRegistro(registro);
                return Ok(new { message = "El registro ha sido correctamente ingresado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
       //lleva todos los registros
        [HttpGet("{rutParticipante}")]
        public async Task<IActionResult> Get(string rutParticipante)
        {
            try
            {
                var listParticipante = await _registroService.GetRegistroByRut(rutParticipante);
                return Ok(listParticipante);
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

        
     }
}
