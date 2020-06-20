using Modelo.Infra.CrossCutting.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.CrossCutting.Interfaces
{
    public interface INotificador
    {
        IList<Notificacao> ObterNotificacoes();
        bool TemNotificacao();
        void Handle(Notificacao notificacao);
    }
}
