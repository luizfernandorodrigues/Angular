using Modelo.Domain.Dominio.Modelo;
using System;
using System.Collections.Generic;

namespace Domain.Dominio.Modelo
{
    public class Cidade : DominioAbstract
    {
        public string Nome { get; set; }
        public string CodigoIbge { get; set; }
        public Guid Estado_Ukey { get; set; }
        public ICollection<Cep> Ceps { get; set; }
    }
}
