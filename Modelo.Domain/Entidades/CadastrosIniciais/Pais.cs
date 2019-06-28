using System.Collections.Generic;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    /// <summary>
    /// Classe de modelo de persistencia do objeto Pais
    /// </summary>
    public class Pais : EntidadeAbstrata
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Observacoes { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }

    }
}
