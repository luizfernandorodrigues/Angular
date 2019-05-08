using System;

namespace Modelo.Domain.Dominio.Modelo
{
    public abstract class DominioAbstract
    {
        public Guid Ukey { get; set; }
        public DateTime TimesTamp { get; set; }
        public Guid Empresa_Ukey { get; set; }
        public Guid? Usuario_Ukey { get; set; }
    }
}
