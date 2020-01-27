using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entidades.Acesso;
using Modelo.Domain.Entidades.CadastrosIniciais;
using Modelo.Infra.Data.Mapeamento.Acesso;
using Modelo.Infra.Data.Mapeamento.Cadastro.Logradouro;

namespace Modelo.Infra.Data.Contexto
{
    /// <summary>
    /// Classe de MApeamento dos objetos com as tabelas da base de dados
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   28/06/2019
    /// </remarks>
    public class ApiContexto : DbContext
    {

        #region Db's Set

        #region Acesso
        public DbSet<Usuario> Usuario { get; set; }
        #endregion

        #region Cadastro

        #region Logradouro
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cep> Cep { get; set; }
        #endregion

        #endregion

        #endregion
        public ApiContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Cadastro

            #region Acesso
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            #endregion

            #region Logradouro
            modelBuilder.ApplyConfiguration(new PaisConfiguracao());
            modelBuilder.ApplyConfiguration(new EstadoConfiguracao());
            modelBuilder.ApplyConfiguration(new CidadeConfiguracao());
            modelBuilder.ApplyConfiguration(new CepConfiguracao());
            #endregion

            #endregion



            base.OnModelCreating(modelBuilder);

        }

    }
}
