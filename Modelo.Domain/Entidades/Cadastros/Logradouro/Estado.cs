using Modelo.Domain.Interfaces;
using Modelo.Domain.Interfaces.Cadastros.Logradouro;
using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entidades.Cadastros.Logradouro
{
    /// <summary>
    /// Classe de modelo de persistencia do objeto Estado
    /// </summary>
    public class Estado : IEstado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public long Pais_Id { get; set; }
        public IPais Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
        public long Id { get; set; }
        public DateTime TimesTamp { get; set; }
    }
}
