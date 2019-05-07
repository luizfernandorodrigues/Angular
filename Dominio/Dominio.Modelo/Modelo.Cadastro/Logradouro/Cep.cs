using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dominio.Modelo
{
   public class Cep : DominioAbstract
    {
        public string CodigoEnderecamentoPostal { get; set; }
        public Guid Cidade_Ukey { get; set; }
    }
}
