using Modelo.Domain.Interfaces.Cadastros.Logradouro;
using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entidades.Cadastros.Logradouro
{
    /// <summary>
    /// Classe de modelo de persistencia do objeto cidade
    /// </summary>
    public class Cidade : ICidade
    {
        public string Nome { get; set; }
        public string CodigoIbge { get; set; }
        public long Estado_Id { get; set; }
        public IEstado Estado { get; set; }
        public virtual ICollection<Cep> Ceps { get; set; }
        public long Id { get; set; }
        public DateTime TimesTamp { get; set; }
    }
}
