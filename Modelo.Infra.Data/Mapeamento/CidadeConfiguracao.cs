using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe responsaavel por mapear a classe Cidade com a tabela com o banco de dados
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   16/05/2019
    /// </remarks>
    public class CidadeConfiguracao : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            #region Mapeamento das propriedades
            //tabela
            builder.ToTable("Cidade");

            //pk
            builder.HasKey(c => c.Ukey);

            //propriedade da pk
            builder.Property(c => c.Ukey)
                .HasColumnName("Ukey")
                .HasColumnType("uniqueidentifier");

            //propriedade nome
            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired(true);

            //propriedade codigo ibge
            builder.Property(c => c.CodigoIbge)
                .HasColumnName("CodigoIbge")
                .HasColumnType("nvarchar")
                .HasMaxLength(7)
                .HasDefaultValue(0)
                .IsRequired(true);

            //propriedade TimesTamp
            builder.Property(c => c.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(true);

            //propriedade da fk
            builder.Property(c => c.Estado_Ukey)
                .HasColumnName("Estado_Ukey")
                .HasColumnType("uniqueidentifier");

            //fk estado
            builder.HasOne(c => c.Estado)
                .WithMany(e => e.Cidades)
                .HasPrincipalKey(e => e.Ukey)
                .HasForeignKey(c => c.Estado_Ukey)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
