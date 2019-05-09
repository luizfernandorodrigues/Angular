using System;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    public class Cep : EntidadeAbstrata
    {
        public string CodigoEnderecamentoPostal { get; set; }
        public Guid Cidade_Ukey { get; set; }
    }
}
