using System;

namespace Modelo.Domain.Interfaces
{
    public interface IEntidade
    {
        long Id { get; set; }
        DateTime TimesTamp { get; set; }
    }
}
