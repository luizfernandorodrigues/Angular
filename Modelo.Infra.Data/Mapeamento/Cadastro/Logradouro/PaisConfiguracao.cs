﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.Cadastros.Logradouro;

namespace Modelo.Infra.Data.Mapeamento.Cadastro.Logradouro
{
  /// <summary>
  /// Classe de MApeamento da Classe de dominio Pais com a tabela Pais na base de dados
  /// </summary>
  /// <param name="builder"></param>
  /// <remarks>
  /// Autor:  Luiz Fernando
  /// Data:   28/06/2019
  /// </remarks>
  public class PaisConfiguracao : IEntityTypeConfiguration<Pais>
  {
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
      #region Mapeamentos Propriedades
      //tabela
      builder.ToTable("Pais", "Cadastro");

      //pk
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Id)
          .HasColumnType("BIGINT")
          .ValueGeneratedOnAdd();
      //nome
      builder.Property(p => p.Nome)
          .HasColumnName("Nome")
          .HasColumnType("VARCHAR(200)")
          .IsRequired(true);
      //codigo
      builder.Property(p => p.Codigo)
          .HasColumnName("Codigo")
          .HasColumnType("VARCHAR(10)")
          .HasDefaultValue("")
          .IsRequired(true);
      //observaçoes
      builder.Property(p => p.Observacao)
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
          .IsRequired(true);
      #endregion

    }
  }
}
