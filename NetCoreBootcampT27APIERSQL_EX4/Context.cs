using Microsoft.EntityFrameworkCore;
using NetCoreBootcampT27APIERSQL_EX4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBootcampT27APIERSQL_EX4
{
    public class Context:DbContext
    {
        public Context([NotNull] DbContextOptions options) : base(options) { }

        protected Context() : base() { }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Investigador> Investigadores { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reserva>()
                        .HasKey(nameof(Reserva.InvestigadorId), nameof(Reserva.EquipoId));
        }
    }
}
