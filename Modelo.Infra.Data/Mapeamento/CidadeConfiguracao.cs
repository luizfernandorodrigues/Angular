using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe de MApeamento da Classe de dominio Cidade com a tabela Cidade na base de dados
    /// </summary>
    /// <param name="builder"></param>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   28/06/2019
    /// </remarks>
    public class CidadeConfiguracao : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            //tabela
            builder.ToTable("Cidade");
            //pk
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();
            //NOME
            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(200)")
                .IsRequired();
            //CODIGOIBGE
            builder.Property(c => c.CodigoIbge)
                .HasColumnName("CodigoIbge")
                .HasColumnType("VARCHAR(7)")
                .IsRequired();
            //timestamp
            builder.Property(c => c.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
            //FK DE ESTADO
            builder.HasOne(c => c.Estado)
                .WithMany(e => e.Cidades)
                .HasForeignKey(c => c.Estado_Id)
                .HasConstraintName("Fk_Cidade_Estado")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
