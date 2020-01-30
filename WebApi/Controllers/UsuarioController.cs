using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entidades.Acesso;
using Modelo.Domain.Interfaces.Repositorios.Acesso;
using Modelo.Infra.CrossCutting.Extensions;
using System;

namespace WebApi.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {

        #region Atributos
        private readonly IRepositorioUsuario repositorioUsuario;
        #endregion

        #region Construtor
        public UsuarioController(IRepositorioUsuario repositorio)
        {
            repositorioUsuario = repositorio;
        }
        #endregion


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
                var usuarioRetorno = repositorioUsuario.Login(usuario.Senha, usuario.Email);

                if (usuarioRetorno.IsNotNull())
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
