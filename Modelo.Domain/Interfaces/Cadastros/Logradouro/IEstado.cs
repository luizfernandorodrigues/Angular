using Modelo.Domain.Entidades.Cadastros.Logradouro;
using System.Collections.Generic;

namespace Modelo.Domain.Interfaces.Cadastros.Logradouro
{
    public interface IEstado : IEntidade
    {
        string Nome { get; set; }
        string Sigla { get; set; }
        long Pais_Id { get; set; }
        Pais Pais { get; set; }
        ICollection<Cidade> Cidades { get; set; }
    }
}
