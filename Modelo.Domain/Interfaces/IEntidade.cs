using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Interfaces
{
    public interface IEntidade
    {
        long Id { get; set; }
        DateTime TimesTamp { get; set; }
    }
}
