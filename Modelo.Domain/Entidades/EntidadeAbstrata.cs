using System;

namespace Modelo.Domain.Entidades
{
    public abstract class EntidadeAbstrata
    {
        public long Id { get; set; }
        public DateTime TimesTamp { get; set; }
    }
}
