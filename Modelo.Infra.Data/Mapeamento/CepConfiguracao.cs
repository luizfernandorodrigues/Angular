using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe que representa o mapeamento do modelo cep com o banco de dados
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   17/05/2019
    /// </remarks>
    class CepConfiguracao : IEntityTypeConfiguration<Cep>
    {
        public void Configure(EntityTypeBuilder<Cep> builder)
        {
            //tabela
            builder.ToTable("Cep");

            //pk
            builder.HasKey(c => c.Ukey);

            //propriedade pk
            builder.Property(c => c.Ukey)
                .HasColumnName("Ukey")
                .HasColumnType("uniqueidentifier");

            //propriedade cep
            builder.Property(c => c.CodigoEnderecamentoPostal)
                .HasColumnName("CodigoEnderecamentoPostal")
                .HasColumnType("nvarchar(8)")
                .HasDefaultValue("")
                .IsRequired(true);

            //propriedade fk cidade
            builder.Property(c => c.Cidade_Ukey)
                .HasColumnName("Cidade_Ukey")
                .HasColumnType("uniqueidentifier");

            //fk cidade
            builder.HasOne(c => c.Cidade)
                .WithMany(x => x.Ceps)
                .HasPrincipalKey(c => c.Ukey)
                .HasForeignKey(x => x.Cidade_Ukey)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
