using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.Acesso;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe Responsável pela configuração da entidade usuario com o banco de dados, aqui eu configuro
    /// o mapeamento das propriedades do objeto com as colunas do banco de dados
    /// </summary>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   15/05/2019
    /// </remarks>
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            #region Mapeamento
            //tabela
            builder.ToTable("Usuario");

            //pk
            builder.HasKey(u => u.Ukey);

            //nome
            builder.Property(u => u.Nome)
                .HasColumnName("Nome");
            #endregion;
        }
    }
}
