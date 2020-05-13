namespace Modelo.Domain.Interfaces.Acesso
{
    public interface IUsuario : IEntidade
    {
        string Nome { get; set; }
        string Email { get; set; }
        string Senha { get; set; }
        string SobreNome { get; set; }
    }
}
