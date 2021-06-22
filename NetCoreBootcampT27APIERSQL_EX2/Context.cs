using Microsoft.EntityFrameworkCore;
using NetCoreBootcampT27APIERSQL_EX2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX2
{
    public class Context:DbContext
    {
        public Context([NotNull] DbContextOptions options) : base(options) { }

        protected Context() : base() { }
        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<AsignadoA> Asignados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AsignadoA>()
                        .HasKey(nameof(AsignadoA.CientificoId), nameof(AsignadoA.ProyectoId));
        }

    }
}
