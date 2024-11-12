using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab.Components.Models;
using Lab.Components.Pages;

namespace Lab.Data
{
    public class LabContext : DbContext
    {
        public LabContext(DbContextOptions<LabContext> options)
            : base(options)
        {
        }

        public DbSet<Lab.Components.Models.Oficina> Oficina { get; set; } = default!;
        public DbSet<Lab.Components.Models.Tramite> Tramite { get; set; } = default!;
        public DbSet<Lab.Components.Models.Puesto> Puesto { get; set; } = default!;
        public DbSet<Lab.Components.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<Lab.Components.Models.Operario> Operario { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oficina>()
                .HasMany(o => o.ListaPuestos)
                .WithOne(p => p.Oficina)
                .HasForeignKey(p => p.idOficina);

            modelBuilder.Entity<Puesto>()
                .HasOne(p => p.Oficina)
                .WithMany(o => o.ListaPuestos)
                .HasForeignKey(p => p.idOficina);

            modelBuilder.Entity<Usuario>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Usuario>("Usuario")
                .HasValue<Operario>("Operario");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Lab.Components.Models.Administrador> Administrador { get; set; } = default!;
        public DbSet<Lab.Components.Models.Monitor> Monitor { get; set; } = default!;
        public DbSet<Lab.Components.Models.GerenteCalidad> GerenteCalidad { get; set; } = default!;
    }
}
