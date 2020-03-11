using Modelo.Domain.Entidades.Cadastros.Logradouro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Interfaces.Cadastros.Logradouro
{
    public interface ICidade : IEntidade
    {
        string Nome { get; set; }
        string CodigoIbge { get; set; }
        long Estado_Id { get; set; }
        Estado Estado { get; set; }
        ICollection<Cep> Ceps { get; set; }
    }
}
