using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab.Components.Models;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oficina>()
                .HasMany(o => o.ListaPuestos)
                .WithOne(p => p.Oficina)
                .HasForeignKey(p => p.idOficina);
        }
    }
}
