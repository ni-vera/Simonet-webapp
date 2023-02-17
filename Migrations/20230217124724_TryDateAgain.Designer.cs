﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapp;

#nullable disable

namespace webapp.Migrations
{
    [DbContext(typeof(WebappDbContext))]
    [Migration("20230217124724_TryDateAgain")]
    partial class TryDateAgain
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapp.Models.Entrada", b =>
                {
                    b.Property<string>("entrada")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("pagina")
                        .HasColumnType("int");

                    b.HasKey("entrada");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("webapp.Models.Propuesta", b =>
                {
                    b.Property<string>("entrada")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Colaborador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("pagina")
                        .HasColumnType("int");

                    b.HasKey("entrada");

                    b.ToTable("Propuestas");
                });
#pragma warning restore 612, 618
        }
    }
}
