namespace Modelo.Domain.Dominio.Modelo.Modelo.Cadastro.Acesso
{
    public class Perfil : DominioAbstract
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Administrador { get; set; }

    }
}
