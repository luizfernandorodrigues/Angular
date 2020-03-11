using Modelo.Domain.Interfaces;
using Modelo.Domain.Interfaces.Cadastros.Logradouro;
using System;

namespace Modelo.Domain.Entidades.Cadastros.Logradouro
{
    /// <summary>
    /// Classe de modelo de persistencia do objeto Cep
    /// </summary>
    public class Cep : ICep
    {
        public string CodigoEnderecamentoPostal { get; set; }
        public long Cidade_Id { get; set; }
        public Cidade Cidade { get; set; }
        public long Id { get; set; }
        public DateTime TimesTamp { get; set; }
    }
}
