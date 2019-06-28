using Modelo.Domain.Entidades.CadastrosIniciais;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Contexto;

namespace Modelo.Infra.Data.Repositorio
{
    /// <summary>
    /// Classe de Repositorio de Pais
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   28/06/2019
    /// </remarks>
    public class RepositorioPais : RepositorioBase<Pais>, IPaisRepositorio
    {
        public RepositorioPais(ApiContexto apiContexto) : base(apiContexto)
        {
        }
    }
}
