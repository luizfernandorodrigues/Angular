using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    public class Cidade : EntidadeAbstrata
    {
        public string Nome { get; set; }
        public string CodigoIbge { get; set; }
        public Guid Estado_Ukey { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Cep> Ceps { get; set; }
    }
}
