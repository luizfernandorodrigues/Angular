using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entidades.Acesso;
using System;

namespace WebApi.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.Email == "luizfernando_rodrigues12@hotmail.com" && usuario.Senha == "1234")
                    return Ok(usuario);

                return BadRequest("Usuário ou Senha Inválidos");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
