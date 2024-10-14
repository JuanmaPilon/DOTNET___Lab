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
        public LabContext (DbContextOptions<LabContext> options)
            : base(options)
        {
        }

        public DbSet<Lab.Components.Models.Oficina> Oficina { get; set; } = default!;
    }
}
