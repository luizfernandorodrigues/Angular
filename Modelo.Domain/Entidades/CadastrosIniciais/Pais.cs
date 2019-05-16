using System.Collections.Generic;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    public class Pais : EntidadeAbstrata
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Observacoes { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }
    }
}
