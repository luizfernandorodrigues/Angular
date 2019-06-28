using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapeamento
{
    /// <summary>
    /// Classe de MApeamento da Classe de dominio Cep com a tabela cep na base de dados
    /// </summary>
    /// <param name="builder"></param>
    /// <remarks>
    /// Autor:  Luiz Fernando
    /// Data:   28/06/2019
    /// </remarks>
    public class CepConfiguracao : IEntityTypeConfiguration<Cep>
    {
        public void Configure(EntityTypeBuilder<Cep> builder)
        {
            //tabela
            builder.ToTable("Cep");
            //pk
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();
            //CodigoEnderecamentoPostal
            builder.Property(c => c.CodigoEnderecamentoPostal)
                .HasColumnName("CodigoEnderecamentoPostal")
                .HasColumnType("VARCHAR(8)")
                .IsRequired();
            //timestamp
            builder.Property(c => c.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
            //FK DE cidade
            builder.HasOne(c => c.Cidade)
                .WithMany(e => e.Ceps)
                .HasForeignKey(c => c.Cidade_Id)
                .HasConstraintName("Fk_Cep_Cidade")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
