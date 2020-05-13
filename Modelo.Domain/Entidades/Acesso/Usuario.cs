using Modelo.Domain.Interfaces;
using Modelo.Domain.Interfaces.Acesso;
using System;

namespace Modelo.Domain.Entidades.Acesso
{
    public class Usuario : AEntidade, IUsuario
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public long Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime TimesTamp { get; set; }
    }
}
