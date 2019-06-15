using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    public class Estado : EntidadeAbstrata
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public long Pais_Id { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
