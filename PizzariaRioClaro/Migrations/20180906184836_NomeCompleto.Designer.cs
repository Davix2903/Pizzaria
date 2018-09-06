﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzariaRioClaro.DAO;

namespace PizzariaRioClaro.Migrations
{
    [DbContext(typeof(PizzariaContext))]
    [Migration("20180906184836_NomeCompleto")]
    partial class NomeCompleto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzariaRioClaro.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Complemento");

                    b.Property<string>("Numero");

                    b.Property<string>("Observacao");

                    b.Property<int?>("PessoaId");

                    b.Property<string>("Rua");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("NomeCompleto");

                    b.Property<string>("Senha");

                    b.Property<string>("Telefone");

                    b.Property<string>("TipoDePessoa")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.Sabores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Sabor");

                    b.Property<string>("TipoPizza")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.ToTable("Sabores");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.Endereco", b =>
                {
                    b.HasOne("PizzariaRioClaro.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });
#pragma warning restore 612, 618
        }
    }
}