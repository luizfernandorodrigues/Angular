using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    /// <summary>
    /// Classe de modelo de persistencia do objeto Cep
    /// </summary>
    public class Cep : EntidadeAbstrata
    {
        public string CodigoEnderecamentoPostal { get; set; }
        public long Cidade_Id { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
