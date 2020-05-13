using System.Collections.Generic;
using System.Reflection;
using Modelo.Infra.CrossCutting;
using Modelo.Infra.CrossCutting.Extensions;

namespace Modelo.Domain.Interfaces
{
    /// <summary>
    /// Classes abstrata para definir comportamentos padrões dos objetos que implementam IEntity
    /// </summary>
    public abstract class AEntidade
    {
        protected IList<string> ListaMensagensErro = new List<string>();
        private IDictionary<string, ETipoValidacao> ListaValidar = new Dictionary<string, ETipoValidacao>();

        public void AdicionarMensagemErro(string mensagem)
        {
            ListaMensagensErro.Add(mensagem);
        }

        public void LimparListaMensagemErro()
        {
            if (!ListaMensagensErro.IsNotEmpty())
                ListaMensagensErro.Clear();
        }
    }
}
