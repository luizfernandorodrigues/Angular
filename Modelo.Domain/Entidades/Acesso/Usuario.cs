namespace Modelo.Domain.Entidades.Acesso
{
    public class Usuario : EntidadeAbstrata
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string PortaSmtp { get; set; }
        public string Servidorsmtp { get; set; }
        public string SenhaEmail { get; set; }
    }
}
