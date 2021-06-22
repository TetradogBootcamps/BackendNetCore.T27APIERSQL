using Microsoft.EntityFrameworkCore;
using NetCoreBootcampT27APIERSQL_EX3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX3
{
    public class Context:DbContext
    {
        public Context([NotNull] DbContextOptions options) : base(options) { }

        protected Context() : base() { }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cajero> Cajeros { get; set; }
        public DbSet<MaquinaRegistradora> MaquinasRegistradoras { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Venta>()
                        .HasKey(nameof(Venta.CajeroId), nameof(Venta.MaquinaRegistradoraId), nameof(Venta.ProductoId));
        }
    }
}
