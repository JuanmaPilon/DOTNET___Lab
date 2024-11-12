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
    [Migration("20241112181942_gerentes")]
    partial class gerentes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab.Components.Models.Monitor", b =>
                {
                    b.Property<int>("idMonitor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMonitor"));

                    b.Property<int>("idOficina")
                        .HasColumnType("int");

                    b.HasKey("idMonitor");

                    b.ToTable("Monitor");
                });

            modelBuilder.Entity("Lab.Components.Models.Oficina", b =>
                {
                    b.Property<int>("idOficina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idOficina"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("TramiteActual")
                        .HasColumnType("int");

                    b.Property<int>("idOficina")
                        .HasColumnType("int");

                    b.HasKey("NroPuesto");

                    b.HasIndex("idOficina");

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

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MonitoridMonitor")
                        .HasColumnType("int");

                    b.Property<string>("NroPuesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idOficina")
                        .HasColumnType("int");

                    b.HasKey("NroTramite");

                    b.HasIndex("MonitoridMonitor");

                    b.ToTable("Tramite");
                });

            modelBuilder.Entity("Lab.Components.Models.Usuario", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.HasKey("Username");

                    b.ToTable("Usuario");

                    b.HasDiscriminator<string>("UserType").HasValue("Usuario");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Lab.Components.Models.Administrador", b =>
                {
                    b.HasBaseType("Lab.Components.Models.Usuario");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("Lab.Components.Models.GerenteCalidad", b =>
                {
                    b.HasBaseType("Lab.Components.Models.Usuario");

                    b.HasDiscriminator().HasValue("GerenteCalidad");
                });

            modelBuilder.Entity("Lab.Components.Models.Operario", b =>
                {
                    b.HasBaseType("Lab.Components.Models.Usuario");

                    b.Property<int>("NumeroOperario")
                        .HasColumnType("int");

                    b.Property<int>("PuestoAsignadoId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Operario");
                });

            modelBuilder.Entity("Lab.Components.Models.Puesto", b =>
                {
                    b.HasOne("Lab.Components.Models.Oficina", "Oficina")
                        .WithMany("ListaPuestos")
                        .HasForeignKey("idOficina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oficina");
                });

            modelBuilder.Entity("Lab.Components.Models.Tramite", b =>
                {
                    b.HasOne("Lab.Components.Models.Monitor", null)
                        .WithMany("TramitesActivos")
                        .HasForeignKey("MonitoridMonitor");
                });

            modelBuilder.Entity("Lab.Components.Models.Monitor", b =>
                {
                    b.Navigation("TramitesActivos");
                });

            modelBuilder.Entity("Lab.Components.Models.Oficina", b =>
                {
                    b.Navigation("ListaPuestos");
                });
#pragma warning restore 612, 618
        }
    }
}