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
    public class ProtocoloActuacionController : ControllerBase
    {
        private readonly IProtocoloActuacionService _protocoloActuacionService;
        public ProtocoloActuacionController(IProtocoloActuacionService protocoloActuacionService)

        {
            _protocoloActuacionService = protocoloActuacionService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProtocolosActuacion protocolosActuacion)
        {
            try
            {
                await _protocoloActuacionService.CreateProtocolos(protocolosActuacion);
                return Ok(new { message = "Protocolo Se agrego correctamente" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }
        [HttpGet("{rbd}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Get(string rbd)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var protocolos = await _protocoloActuacionService.GetProtocolos(rbd);
                return Ok(protocolos);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id)
    {
        try
        {
                
                var protocoloActuacion = await _protocoloActuacionService.GetProtocoloById(id);
                if(protocoloActuacion == null)
                {
                    return BadRequest(new { message = "No se encontro el Protocolo" });
                }
                await _protocoloActuacionService.EliminarProtocolo(protocoloActuacion);
                return Ok(new { message = "Se elimino el protocolo" });
            }
        catch (Exception ex)
        {

                return BadRequest(ex.Message);
        }
    }
        [Route("getProtocolo/{idProtocolo}")]
        [HttpGet]
        public async Task<IActionResult>Get(int idProtocolo)
        {
            try
            {

                var protocoloAct = await _protocoloActuacionService.GetProtocoloById(idProtocolo);
                    if(protocoloAct == null)
                {
                    return Ok(new { message = "Protocolo no existe" });
                }
                return Ok(protocoloAct);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("CambiarProtocolo")]
        public async Task<IActionResult>CambiarProtocolo([FromBody] ProtocolosActuacion cambiarProtocolo)
        {
            try
            {
                await _protocoloActuacionService.UpdateProtocolo(cambiarProtocolo);
                return Ok(new { message = "Protocolo Actualizado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

       
    }
}
