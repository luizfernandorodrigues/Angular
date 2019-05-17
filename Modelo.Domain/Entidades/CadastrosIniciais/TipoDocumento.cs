using System.Collections.Generic;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    public class TipoDocumento : EntidadeAbstrata
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ParceiroNegocio> ParceiroNegocios { get; set; }
    }
}
