namespace Modelo.Infra.CrossCutting.Notificacoes
{
    public class Notificacao
    {
        #region Propriedades
        public string Mensagem { get; private set; }
        #endregion Propriedades

        #region Construtor
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }
        #endregion Construtor
    }
}
