using Modelo.Domain.Interfaces;
using System;

namespace Modelo.Domain.Entidades.Acesso
{
    public class Usuario : IEntidade
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public long Id { get; set; }
        public DateTime TimesTamp { get; set; }
    }
}
