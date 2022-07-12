using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using BackEndV1.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BackEndV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IConfiguration _config;
        private readonly IUsuarioService _usuario;

        public LoginController(ILoginService loginService, IConfiguration config, IUsuarioService usuario_)
        {

            _loginService = loginService;
            _config = config;
            _usuario = usuario_;
        }
        // L O G I N   V A L I D A C I O N 
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Usuario usuario)
        {
            try
            {
                usuario.Password = Encriptar.EncriptarPassword(usuario.Password);
                var user = await _loginService.ValidateUser(usuario);
                if(user== null)
                {
                    return BadRequest(new { message = "Usuario o contraseña invalidos" });
                }

                string tokenString = JwtConfigurator.GetToken(user, _config);

                return Ok(new { token = tokenString});
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //R E F R E S H    T O K E N

        [HttpGet("getIdUsuario")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Refresh()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                int usuario_id = JwtConfigurator.GetTokenIdUsuario(identity);

                var us = await _usuario.GetUsuarioById(usuario_id);
                string tokenRefresh = JwtConfigurator.GetToken(us, _config);
                return Ok(new { token= tokenRefresh});
            }
            catch (System.Exception e)
            {

                return BadRequest(e.InnerException);
            }
        }
    }
}
