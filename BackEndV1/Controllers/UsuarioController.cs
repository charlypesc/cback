using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using BackEndV1.Domain.IService;
using Microsoft.AspNetCore.Mvc;
using BackEndV1.Domain.Models;
using BackEndV1.Services;
using BackEndV1.Utils;
using BackEndV1.DTO;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace BackEndV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        // R E G I S T R A R    U S U A R I O S
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            try
            {
                var validateExistence = await _usuarioService.ValidateExistence(usuario);
                if (validateExistence)
                {
                    return BadRequest(new { messagge = "el usuario " + usuario.NombreUsuario + " ya existe" });
                }
                usuario.Password = Encriptar.EncriptarPassword(usuario.Password);
                await _usuarioService.SaveUser(usuario);
                return Ok(new { message = "Usuario registrado con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // C A M B I A R    P A S S W O R D 
        [Route("CambiarPassword")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> CambiarPassword([FromBody] CambiarPasswordDTO cambiarPassword)
        {

            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                int idUsuario = JwtConfigurator.GetTokenIdUsuario(identity);
                //toma 
                string passwordEncriptado = Encriptar.EncriptarPassword(cambiarPassword.passwordAnterior);
                var usuario = await _usuarioService.ValidatePassword(idUsuario, passwordEncriptado);
                if(usuario == null)
                {
                    return BadRequest(new { message = "la password es incorrecta" });
                }
                else
                {
                    usuario.Password = Encriptar.EncriptarPassword(cambiarPassword.nuevaPassword);
                   await _usuarioService.UpdatePassword(usuario);
                }
                return Ok(new { message = " Las password se actualizo con exito" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        //A C T U A L I Z A R     U S U A R I O
        [Route("ActualizaUsuario")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> ActualizaUsuario([FromBody] Usuario usuario)
        {
            try
            {
                
                var validateExistence = await _usuarioService.ValidateExistence(usuario);
                
                if (validateExistence)
                {
                    await _usuarioService.UpdateUser(usuario);
                    return Ok(new { message = "Se actualizo el usuario" });
                }
                else
                {
                    return BadRequest(new { message = "El usuario no se pudo actualizar" });
                }



            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // B O R R A R    U S U A R I O 
        [Route("BorrraUsuario/{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete]
        public async Task<IActionResult> BorraUsuario(int id)
        {
            try
            {
                var usuario = await _usuarioService.GetUsuarioById(id);
                if(usuario == null)
                {
                    return Ok(new { message = "No se encuentra el usuario" });
                }

                var validateExistence = await _usuarioService.ValidateExistence(usuario);

                if (validateExistence)
                {
                    await _usuarioService.DeleteUser(usuario);
                    return Ok(new { message = "Se borro el usuario" });
                }
                else
                {
                    return BadRequest(new { message = "El usuario no se pudo borrar" });
                }
            }
            catch (Exception)
            {

                return BadRequest(new { message = "El usuario no se pudo borrar" });
            }
        }
        [Route("getUsuarioRbd")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> GetUsuarioListaRbd()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var activo = 1;
                var usuarios = await _usuarioService.GetListUsuarioRbd(rbd, activo);
                if(usuarios.Count == 0)
                {
                    return Ok(new { messagge = "No hay usuarios para el RBD "+rbd });
                }
                return Ok(usuarios);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

    }
}
