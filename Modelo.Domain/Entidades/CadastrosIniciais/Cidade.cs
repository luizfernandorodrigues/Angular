using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    /// <summary>
    /// Classe de modelo de persistencia do objeto cidade
    /// </summary>
    public class Cidade : EntidadeAbstrata
    {
        public string Nome { get; set; }
        public string CodigoIbge { get; set; }
        public long Estado_Id { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Cep> Ceps { get; set; }
    }
}
