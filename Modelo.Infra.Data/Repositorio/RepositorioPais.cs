using Modelo.Domain.Entidades.CadastrosIniciais;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Contexto;

namespace Modelo.Infra.Data.Repositorio
{
    public class RepositorioPais : RepositorioBase<Pais>, IPaisRepositorio
    {
        public RepositorioPais(ApiContexto apiContexto) : base(apiContexto)
        {
        }
    }
}
