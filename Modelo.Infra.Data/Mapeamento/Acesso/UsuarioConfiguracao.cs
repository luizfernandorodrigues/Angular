using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.Acesso;

namespace Modelo.Infra.Data.Mapeamento.Acesso
{
    /// <summary>
    /// Classe de mapeamento do objeto Usuario com a tabela Usuario no banco de dados
    /// </summary>
    /// <remarks>
    /// Autor   :Luiz Fernando
    /// Data    :26/01/2020
    /// </remarks>
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            #region Propriedades

            builder.ToTable("Usuario", "Acesso");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();
            
            //email
            builder.Property(c => c.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR(200)")
                .IsRequired();
            
            //senha
            builder.Property(c => c.Senha)
                .HasColumnName("Senha")
                .HasColumnType("VARCHAR(MAX)")
                .IsRequired();
            
            //timestamp
            builder.Property(c => c.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(200)")
                .IsRequired(true);

            builder.Property(c => c.SobreNome)
                .HasColumnName("SobreNome")
                .HasColumnType("VARCHAR(200)")
                .IsRequired(true);
            
            #endregion
        }
    }
}
