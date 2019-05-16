﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entidades.Acesso;
using Modelo.Domain.Entidades.CadastrosIniciais;
using Modelo.Infra.Data.Mapeamento;

namespace Modelo.Infra.Data.Contexto
{
    public class ApiContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public ApiContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //classes do mapeamento com o banco vai aqui
            modelBuilder.ApplyConfiguration(new PaisConfiguracao());
            base.OnModelCreating(modelBuilder);

        }

    }
}
