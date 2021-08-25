﻿// <auto-generated />
using System;
using APIfinalPloomes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIfinalPloomes.Migrations
{
    [DbContext(typeof(ServicoContext))]
    [Migration("20210825061322_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIfinalPloomes.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade_Res")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdServico")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("APIfinalPloomes.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CNPJ")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ramo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("APIfinalPloomes.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("APIfinalPloomes.Models.Cliente", b =>
                {
                    b.HasOne("APIfinalPloomes.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("APIfinalPloomes.Models.Servico", b =>
                {
                    b.HasOne("APIfinalPloomes.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");

                    b.Navigation("Empresa");
                });
#pragma warning restore 612, 618
        }
    }
}
