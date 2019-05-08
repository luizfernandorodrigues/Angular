using Modelo.Domain.Dominio.Modelo;
using System;

namespace Domain.Dominio.Modelo
{
    public class Cep : DominioAbstract
    {
        public string CodigoEnderecamentoPostal { get; set; }
        public Guid Cidade_Ukey { get; set; }
    }
}
