using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entidades.Cadastros.Logradouro;
using Modelo.Domain.Interfaces.Repositorios.Cadastros.Logradouro;
using System;
using System.IO;
using System.Linq;

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
        private IHttpContextAccessor _httpContextAccessor;
        private IHostingEnvironment _hostingEnvironment;
        #endregion

        #region Construtor
        public PaisController(IRepositorioPais paisRepositorio, IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment)
        {
            _paisRepositorio = paisRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
        }
        #endregion

        #region Actions
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(_paisRepositorio.ObterTudo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("cadastrar")]
        public IActionResult Post([FromBody] Pais pais)
        {
            try
            {
                if (!pais.ValidarPais())
                    _paisRepositorio.Adicionar(pais);

                return Created("/api/pais", pais);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("EnviarArquivo")]
        public IActionResult EnviarArquivo()
        {
            try
            {
                var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["arquivoSelecionado"];// pegar o arquivo que vem na requisição "arquivoSelecionado" é definido no Angular no momento de fazer a requisição
                var nomeArquivo = formFile.FileName; // pega o nome do arquivo
                var extensao = nomeArquivo.Split(".").Last(); // pega a ultima ocorrencia depois do ponto, no caso a extensão do arquivo
                string novoNomeArquivo = GerarNomeArquivo(nomeArquivo, extensao);
                var pastaArquivos = _hostingEnvironment.WebRootPath + "\\arquivos\\"; // pego o caminho completo da pasta onde vai ficar os arquivos
                var nomeCompleto = pastaArquivos + novoNomeArquivo; // monto o local do arquivo completo´caminho da pasta mais o nome junto com a extensao

                using (var streamArquivo = new FileStream(nomeCompleto, FileMode.Create))
                {
                    formFile.CopyTo(streamArquivo); // efetua a gravação
                }

                return Ok("Arquivo Gravado com Sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        private static string GerarNomeArquivo(string nomeArquivo, string extensao)
        {
            var arrayNomeCompacto = Path.GetFileNameWithoutExtension(nomeArquivo).Take(10).ToArray(); // pego somente os 10 primeiro caracter do arquivo e transformo em um array
            var novoNomeArquivo = new string(arrayNomeCompacto).Replace(" ", "-"); //criar um novo nome pro arquivo concatenando com a extensao
            novoNomeArquivo = $"{novoNomeArquivo}_{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.{extensao}";
            return novoNomeArquivo;
        }
        #endregion
    }
}