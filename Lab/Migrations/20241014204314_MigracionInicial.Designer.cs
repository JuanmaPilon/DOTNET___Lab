﻿// <auto-generated />
using System;
using Lab.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab.Migrations
{
    [DbContext(typeof(LabContext))]
    [Migration("20241014204314_MigracionInicial")]
    partial class MigracionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab.Components.Models.Oficina", b =>
                {
                    b.Property<int>("idOficina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idOficina"));

                    b.HasKey("idOficina");

                    b.ToTable("Oficina");
                });

            modelBuilder.Entity("Lab.Components.Models.Puesto", b =>
                {
                    b.Property<int>("NroPuesto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NroPuesto"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int?>("OficinaidOficina")
                        .HasColumnType("int");

                    b.Property<int>("TramiteActual")
                        .HasColumnType("int");

                    b.HasKey("NroPuesto");

                    b.HasIndex("OficinaidOficina");

                    b.ToTable("Puesto");
                });

            modelBuilder.Entity("Lab.Components.Models.Puesto", b =>
                {
                    b.HasOne("Lab.Components.Models.Oficina", null)
                        .WithMany("ListaPuestos")
                        .HasForeignKey("OficinaidOficina");
                });

            modelBuilder.Entity("Lab.Components.Models.Oficina", b =>
                {
                    b.Navigation("ListaPuestos");
                });
#pragma warning restore 612, 618
        }
    }
}
