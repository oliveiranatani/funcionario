﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cadastro.Context;

#nullable disable

namespace cadastro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240322124302_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("cadastro.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FuncionarioId"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("SetorId")
                        .HasColumnType("integer");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("cadastro.Models.Setor", b =>
                {
                    b.Property<int>("SetorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SetorId"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("SetorId");

                    b.ToTable("Setor");
                });
#pragma warning restore 612, 618
        }
    }
}
