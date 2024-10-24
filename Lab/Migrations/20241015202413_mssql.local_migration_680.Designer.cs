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
    [Migration("20241015202413_mssql.local_migration_680")]
    partial class mssqllocal_migration_680
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

            modelBuilder.Entity("Lab.Components.Models.Tramite", b =>
                {
                    b.Property<int>("NroTramite")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NroTramite"));

                    b.Property<int>("CedulaCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("NroPuesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NroTramite");

                    b.ToTable("Tramite");
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
