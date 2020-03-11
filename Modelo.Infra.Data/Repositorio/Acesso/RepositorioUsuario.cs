using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entidades.Acesso;
using Modelo.Domain.Interfaces.Repositorios.Acesso;
using Modelo.Infra.Data.Contexto;
using System.Linq;

namespace Modelo.Infra.Data.Repositorio.Acesso
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        public RepositorioUsuario(ApiContexto apiContexto) : base(apiContexto)
        {
        }

        public Usuario Login(string senha, string email)
        {
            return ApiContexto.Usuario.FromSql($"SELECT TOP 1 * FROM Acesso.Usuario WHERE Email = {email} AND Senha = {senha}").FirstOrDefault();
        }

        public bool VerificaUsuario(string email)
        {
            return ApiContexto.Usuario.FromSql($"SELECT TOP 1 * FROM Acesso.Usuario WHERE Email = {email}").Count() > 0;
        }
    }
}
