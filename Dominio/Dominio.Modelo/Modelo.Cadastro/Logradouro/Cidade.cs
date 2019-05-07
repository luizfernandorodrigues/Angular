using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dominio.Modelo
{
   public class Cidade : DominioAbstract
    {
        public string Nome { get; set; }
        public string CodigoIbge { get; set; }
        public Guid Estado_Ukey { get; set; }
    }
}
