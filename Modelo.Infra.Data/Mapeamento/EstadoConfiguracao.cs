using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entidades.CadastrosIniciais;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapeamento
{
    public class EstadoConfiguracao : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {



            builder.Property(e => e.Pais_Ukey)
                .HasColumnName("Pais_Ukey")
                .HasColumnType("uniqueidentifier")
                .IsRequired(true);

            builder.HasOne(p => p.Pais)
                .WithMany(e => e.Estados)
                .HasForeignKey(p => p.Pais_Ukey)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
