using Modelo.Domain.Entidades.CadastrosIniciais;
using Modelo.Domain.Interfaces.Cadastros.Logradouro;
using Modelo.Infra.Data.Contexto;

namespace Modelo.Infra.Data.Repositorio.Cadastro.Logradouro
{
    /// <summary>
    /// Classe de Repositorio de Pais
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   28/06/2019
    /// </remarks>
    public class RepositorioPais : RepositorioBase<Pais>, IRepositorioPais
    {
        public RepositorioPais(ApiContexto apiContexto) : base(apiContexto)
        {
        }
    }
}
