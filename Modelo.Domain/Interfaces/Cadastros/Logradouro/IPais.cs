using Modelo.Domain.Entidades.Cadastros.Logradouro;
using System.Collections.Generic;

namespace Modelo.Domain.Interfaces.Cadastros.Logradouro
{
    public interface IPais : IEntidade
    {
        string Nome { get; set; }
        short Codigo { get; set; }
        string Observacao { get; set; }
        ICollection<Estado> Estados { get; set; }
    }
}
