using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe de MApeamento da Classe de dominio Estado com a tabela Estado na base de dados
    /// </summary>
    /// <param name="builder"></param>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   28/06/2019
    /// </remarks>
    public class EstadoConfiguracao : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            #region Mapeamento das Propriedades
            builder.ToTable("Estado");

            //pk
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();
            //nome
            builder.Property(e => e.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            //sigla
            builder.Property(e => e.Sigla)
                .HasColumnName("Sigla")
                .HasColumnType("VARCHAR(2)")
                .IsRequired();
            //timestamp
            builder.Property(e => e.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .IsRequired();
            //fk pais_id
            builder.HasOne(e => e.Pais)
                .WithMany(p => p.Estados)
                .HasForeignKey(e => e.Pais_Id)
                .HasConstraintName("Fk_Estado_Pais")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
