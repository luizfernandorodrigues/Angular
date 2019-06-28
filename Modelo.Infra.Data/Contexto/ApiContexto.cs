using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entidades.CadastrosIniciais;
using Modelo.Infra.Data.Mapeamento;

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
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cep> Cep { get; set; }
        public ApiContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //classes do mapeamento com o banco vai aqui
            modelBuilder.ApplyConfiguration(new PaisConfiguracao());
            modelBuilder.ApplyConfiguration(new EstadoConfiguracao());
            modelBuilder.ApplyConfiguration(new CidadeConfiguracao());
            modelBuilder.ApplyConfiguration(new CepConfiguracao());
            base.OnModelCreating(modelBuilder);

        }

    }
}
