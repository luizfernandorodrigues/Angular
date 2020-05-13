using Modelo.Domain.Interfaces;
using Modelo.Domain.Interfaces.Cadastros.Logradouro;
using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entidades.Cadastros.Logradouro
{
    /// <summary>
    /// Classe de modelo de persistencia do objeto Pais
    /// </summary>
    public class Pais : AEntidade, IPais
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Observacao { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }
        public long Id { get; set; }
        public DateTime TimesTamp { get; set; }




        public bool ValidarPais()
        {
            LimparListaMensagemErro();

            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagemErro("Nome do Pais é Obrigatório");

            if (string.IsNullOrEmpty(Codigo))
                AdicionarMensagemErro("Código do Pais é Obrigatório");

            return ListaMensagensErro.Count > 0;
        }
    }
}
