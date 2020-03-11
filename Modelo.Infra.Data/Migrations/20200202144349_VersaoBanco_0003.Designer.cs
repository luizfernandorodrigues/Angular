﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo.Infra.Data.Contexto;

namespace Modelo.Infra.Data.Migrations
{
    [DbContext(typeof(ApiContexto))]
    [Migration("20200202144349_VersaoBanco_0003")]
    partial class VersaoBanco_0003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Domain.Entidades.Acesso.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("Senha")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<DateTime>("TimesTamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TimesTamp")
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.ToTable("Usuario","Acesso");
                });

            modelBuilder.Entity("Modelo.Domain.Entidades.Cadastros.Logradouro.Cep", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Cidade_Id");

                    b.Property<string>("CodigoEnderecamentoPostal")
                        .IsRequired()
                        .HasColumnName("CodigoEnderecamentoPostal")
                        .HasColumnType("VARCHAR(8)");

                    b.Property<DateTime>("TimesTamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TimesTamp")
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("Cidade_Id");

                    b.ToTable("Cep","Cadastro");
                });

            modelBuilder.Entity("Modelo.Domain.Entidades.Cadastros.Logradouro.Cidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoIbge")
                        .IsRequired()
                        .HasColumnName("CodigoIbge")
                        .HasColumnType("VARCHAR(7)");

                    b.Property<long>("Estado_Id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<DateTime>("TimesTamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TimesTamp")
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("Estado_Id");

                    b.ToTable("Cidade","Cadastro");
                });

            modelBuilder.Entity("Modelo.Domain.Entidades.Cadastros.Logradouro.Estado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<long>("Pais_Id");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnName("Sigla")
                        .HasColumnType("VARCHAR(2)");

                    b.Property<DateTime>("TimesTamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("TimesTamp")
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("Pais_Id");

                    b.ToTable("Estado","Cadastro");
                });

            modelBuilder.Entity("Modelo.Domain.Entidades.Cadastros.Logradouro.Pais", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Codigo")
                        .HasColumnType("VARCHAR(10)")
                        .HasDefaultValue("");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Observacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Observacoes")
                        .HasColumnType("VARCHAR(MAX)")
                        .HasDefaultValue("");

                    b.Property<DateTime>("TimesTamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("TimesTamp")
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.ToTable("Pais","Cadastro");
                });

            modelBuilder.Entity("Modelo.Domain.Entidades.Cadastros.Logradouro.Cep", b =>
                {
                    b.HasOne("Modelo.Domain.Entidades.Cadastros.Logradouro.Cidade", "Cidade")
                        .WithMany("Ceps")
                        .HasForeignKey("Cidade_Id")
                        .HasConstraintName("Fk_Cep_Cidade")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Modelo.Domain.Entidades.Cadastros.Logradouro.Cidade", b =>
                {
                    b.HasOne("Modelo.Domain.Entidades.Cadastros.Logradouro.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("Estado_Id")
                        .HasConstraintName("Fk_Cidade_Estado")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Modelo.Domain.Entidades.Cadastros.Logradouro.Estado", b =>
                {
                    b.HasOne("Modelo.Domain.Entidades.Cadastros.Logradouro.Pais", "Pais")
                        .WithMany("Estados")
                        .HasForeignKey("Pais_Id")
                        .HasConstraintName("Fk_Estado_Pais")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}