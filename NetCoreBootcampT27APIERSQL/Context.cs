using BootcampNetCoreT28ApiJwt_EX1.Models;
using Microsoft.EntityFrameworkCore;
using NetCoreBootcampT27APIERSQL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL
{
    public class Context:DbContext
    {

        public Context([NotNull] DbContextOptions options) : base(options) { }

        protected Context() : base() { }

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Pieza> Piezas { get; set; }
        public DbSet<Suministra> Suministras { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Suministra>()
                        .HasKey(nameof(Suministra.PiezaId), nameof(Suministra.ProveedorId));
        }
    }
}
