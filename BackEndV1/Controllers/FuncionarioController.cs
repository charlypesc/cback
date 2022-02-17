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
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _funcionarioService;
        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
        //C R E A
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post(Funcionario funcionario)
        {
            try
            {
                await _funcionarioService.SaveFuncionario(funcionario);
                return Ok(new { message = " Funcionario registrado correctamente." });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //G E T    I D
        [Route("funcionarioId/{id}")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetIdFuncionario(int id)
        {
            try
            {
                var funcionario = await _funcionarioService.GetFuncionarioById(id);
                if (funcionario == null)
                {
                    return Ok(new { message = "El funcionario no se encuentra" });
                }
                else {
                    return Ok(funcionario);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
        //G E T   T O D O S
        [Route("getFuncionarioTodos/")]
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetFuncionarioTodos()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var funcionarioTodos = await _funcionarioService.GetFuncionariosByRbd(rbd);
                if (funcionarioTodos == null)
                {
                    return Ok(new { message = "Este establecimiento no tiene registrado funcionarios" });
                }
                else {
                    return Ok(funcionarioTodos);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
        //G E T  R U T
        [HttpGet]
        [Route("getFuncionarioRut/{rut}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetRutFuncionarioRut(string rut)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                string rbd = JwtConfigurator.GetTokenRbd(identity);
                var funcionarioRut = await _funcionarioService.GetFuncionarioByRut(rut, rbd);
                if (funcionarioRut == null)
                {
                    return Ok(new { message = "No se encuentra el rut de funcionario" });
                }
                else
                {
                    return Ok(funcionarioRut);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
        //E L I M I N A
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> EliminarFuncionario(int id)
        {
            try
            {
                var funcionario = await _funcionarioService.GetFuncionarioById(id);
                if(funcionario == null)
                {
                    return Ok(new { message = "El funcionario no se encuntra", codigo=0 });
                }
                await _funcionarioService.EliminaFuncionario(funcionario);

                return Ok(new { message = "El funcionario fue eliminado con exito", codigo = 1 });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
        //A C T U A L I Z A
        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> ActualizaFuncionario([FromBody] Funcionario funcionario)
        {
            try
            {
                await _funcionarioService.UpdateFuncionario(funcionario);
                return Ok(new { message = "El funcionario se actualizo correctamente", codigo = 0 });

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }
    }
}
