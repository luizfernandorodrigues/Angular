﻿using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entidades.CadastrosIniciais;
using Modelo.Domain.Interfaces.Cadastros.Logradouro;
using System;

namespace WebApi.Controllers
{
    /// <summary>
    /// Classe que representa o Controller de pais
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   28/06/2019
    /// </remarks>
    [Route("api/[Controller]")]
    public class PaisController : Controller
    {
        #region Propriedades
        private readonly IRepositorioPais _paisRepositorio;
        #endregion

        #region Construtor
        public PaisController(IRepositorioPais paisRepositorio)
        {
            _paisRepositorio = paisRepositorio;
        }
        #endregion

        #region Actions
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_paisRepositorio.ObterTudo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pais pais)
        {
            try
            {
                _paisRepositorio.Atualizar(pais);
                return Created("/api/pais", pais);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
