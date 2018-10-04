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
    [Migration("20181004164546_removendoTipopizza")]
    partial class removendoTipopizza
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

            modelBuilder.Entity("PizzariaRioClaro.Models.ItensPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PedidoId");

                    b.Property<int>("Quantidade");

                    b.Property<int?>("RefrigeranteId");

                    b.Property<int?>("SaboresDoceId");

                    b.Property<int?>("SaboresId");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("RefrigeranteId");

                    b.HasIndex("SaboresDoceId");

                    b.HasIndex("SaboresId");

                    b.ToTable("itensPedidos");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
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

            modelBuilder.Entity("PizzariaRioClaro.Models.Refrigerante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<double>("Preco");

                    b.Property<string>("Tamanho")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Refrigerantes");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.Sabores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredientes")
                        .IsRequired();

                    b.Property<double>("Preco");

                    b.Property<string>("Sabor")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Sabores");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.SaboresDoce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredientes")
                        .IsRequired();

                    b.Property<double>("Preco");

                    b.Property<string>("Sabor")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("SaboresDoce");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.Endereco", b =>
                {
                    b.HasOne("PizzariaRioClaro.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.ItensPedido", b =>
                {
                    b.HasOne("PizzariaRioClaro.Models.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId");

                    b.HasOne("PizzariaRioClaro.Models.Refrigerante", "Refrigerante")
                        .WithMany()
                        .HasForeignKey("RefrigeranteId");

                    b.HasOne("PizzariaRioClaro.Models.SaboresDoce", "SaboresDoce")
                        .WithMany()
                        .HasForeignKey("SaboresDoceId");

                    b.HasOne("PizzariaRioClaro.Models.Sabores", "Sabores")
                        .WithMany()
                        .HasForeignKey("SaboresId");
                });

            modelBuilder.Entity("PizzariaRioClaro.Models.Pedido", b =>
                {
                    b.HasOne("PizzariaRioClaro.Models.Pessoa", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
