using System;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    public class Estado : EntidadeAbstrata
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Guid Pais_Ukey { get; set; }
    }
}
