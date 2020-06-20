using Modelo.Infra.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Modelo.Infra.CrossCutting.Notificacoes
{
    public class Notificador : INotificador
    {
        private IList<Notificacao> _notificacaos;

        public Notificador()
        {
            _notificacaos = new List<Notificacao>();
        }
        public void Handle(Notificacao notificacao)
        {
            _notificacaos.Add(notificacao);
        }

        public IList<Notificacao> ObterNotificacoes()
        {
            return _notificacaos;
        }

        public bool TemNotificacao()
        {
            return _notificacaos.Any();
        }
    }
}
