using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;

namespace Modelo.Infra.Data.Mapeamento
{
    public class PaisConfiguracao : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            #region Mapeamentos Propriedades
            //tabela
            builder.ToTable("Pais");

            //pk
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();
            //nome
            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(200)")
                .IsRequired();
            //codigo
            builder.Property(p => p.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("VARCHAR(10)")
                .HasDefaultValue("")
                .IsRequired(false);
            //observaçoes
            builder.Property(p => p.Observacoes)
                .HasColumnName("Observacoes")
                .HasColumnType("VARCHAR(MAX)")
                .HasDefaultValue("")
                .IsRequired(false);
            //datetime
            builder.Property(p => p.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .IsRequired();
            #endregion

        }
    }
}
