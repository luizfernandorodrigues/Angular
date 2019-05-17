using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    /// <summary>
    /// Classe que representa o Modelo de Cep
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   15/05/2019
    /// </remarks>
    public class Cep : EntidadeAbstrata
    {
        public string CodigoEnderecamentoPostal { get; set; }
        public Guid Cidade_Ukey { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual ICollection<ParceiroNegocio> ParceiroNegocios { get; set; }

    }
}
