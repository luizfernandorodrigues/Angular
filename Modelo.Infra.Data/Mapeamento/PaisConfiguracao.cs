using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe responsavel por mapear a entidade pais com a tabela no banco de dados
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   15/05/2019
    /// </remarks>
    public class PaisConfiguracao : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            #region Mapeamento Propriedades
            //pk
            builder.ToTable("Pais");
            builder.HasKey(p => p.Ukey);
            builder.Property(p => p.Ukey)
                .HasColumnName("Ukey")
                .HasColumnType("uniqueidentifier");
            
            //Nome
            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired(true);

            //codigo
            builder.Property(p => p.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("nvarchar")
                .HasMaxLength(10)
                .IsRequired(false) ;

            //observações
            builder.Property(p => p.Observacoes)
                .HasColumnName("Observacoes")
                .HasColumnType("nvarchar")
                .HasMaxLength(4000)
                .IsRequired(false);

            //timestamp
            builder.Property(p => p.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("DateTime")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(true);

            //propriedade fkempresa
            builder.Property(p => p.Empresa_Ukey)
                .HasColumnName("Empresa_Ukey")
                .HasColumnType("uniqueidentifier")
                .IsRequired(false);
            #endregion
        }
    }
}
