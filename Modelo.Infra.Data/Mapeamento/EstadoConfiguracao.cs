using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe Responsável por mapear a classe Estado com a tabela no banco de dados
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   16/05/2019
    /// </remarks>
    public class EstadoConfiguracao : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            #region Mapeamento Propriedades
            //tabela
            builder.ToTable("Estado");

            //pk
            builder.HasKey(e => e.Ukey);

            //propriedade pk
            builder.Property(e => e.Ukey)
                .HasColumnName("Ukey")
                .HasColumnType("uniqueidentifier");

            //propriedade nome
            builder.Property(e => e.Nome)
                .HasColumnName("Nome")
                .HasColumnType("nvarchar(100)")
                .IsRequired(true);

            //propriedade sigla
            builder.Property(e => e.Sigla)
                .HasColumnName("Sigla")
                .HasColumnType("nvarchar(2)")
                .IsRequired(true);

            //propriedade timestamp
            builder.Property(e => e.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(true);

            //propriedade fk empresa
            builder.Property(e => e.Empresa_Ukey)
                .HasColumnName("Empresa_Ukey")
                .HasColumnType("uniqueidentifier");

            //propriedade fk pais
            builder.Property(e => e.Pais_Ukey)
                .HasColumnName("Pais_Ukey")
                .HasColumnType("uniqueidentifier");


            //fk pais
            builder.HasOne(p => p.Pais)
                .WithMany(e => e.Estados)
                .HasPrincipalKey(p => p.Ukey)
                .HasForeignKey(e => e.Pais_Ukey)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

        }
    }
}
