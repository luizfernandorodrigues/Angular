using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entidades.CadastrosIniciais
{
    public class ParceiroNegocio : EntidadeAbstrata
    {
        public string Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public bool Cliente { get; set; }
        public bool Fonecedor { get; set; }
        public bool Tipo { get; set; }
        public long Cep_Id { get; set; }
        public virtual Cep Cep { get; set; }
        public long TipoDocumento_Id { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }

    }
}
