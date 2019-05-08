namespace Modelo.Domain.Dominio.Modelo.Modelo.Cadastro.Acesso
{
    public class Usuario : DominioAbstract
    {
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string PortaSmtp { get; set; }
        public string ServidorSmtp { get; set; }
        public bool Ssl { get; set; }
    }
}
