﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreBootcampT27APIERSQL_EX4;

namespace NetCoreBootcampT27APIERSQL_EX4.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX4.Models.Equipo", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("NumSerie");

                    b.Property<int>("FacultadId")
                        .HasColumnType("int")
                        .HasColumnName("Facultad");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("FacultadId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX4.Models.Facultad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Codigo");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Facultades");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX4.Models.Investigador", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("DNI");

                    b.Property<int>("FacultadId")
                        .HasColumnType("int")
                        .HasColumnName("Facultad");

                    b.Property<string>("NombreCompleto")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("NomApels");

                    b.HasKey("Id");

                    b.HasIndex("FacultadId");

                    b.ToTable("Investigadores");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX4.Models.Reserva", b =>
                {
                    b.Property<string>("InvestigadorId")
                        .HasColumnType("varchar(8)")
                        .HasColumnName("DNI");

                    b.Property<string>("EquipoId")
                        .HasColumnType("varchar(4)")
                        .HasColumnName("NumSerie");

                    b.Property<DateTime>("Comienzo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fin")
                        .HasColumnType("datetime(6)");

                    b.HasKey("InvestigadorId", "EquipoId");

                    b.HasIndex("EquipoId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX4.Models.Equipo", b =>
                {
                    b.HasOne("NetCoreBootcampT27APIERSQL_EX4.Models.Facultad", "Facultad")
                        .WithMany()
                        .HasForeignKey("FacultadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facultad");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX4.Models.Investigador", b =>
                {
                    b.HasOne("NetCoreBootcampT27APIERSQL_EX4.Models.Facultad", "Facultad")
                        .WithMany()
                        .HasForeignKey("FacultadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facultad");
                });

            modelBuilder.Entity("NetCoreBootcampT27APIERSQL_EX4.Models.Reserva", b =>
                {
                    b.HasOne("NetCoreBootcampT27APIERSQL_EX4.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetCoreBootcampT27APIERSQL_EX4.Models.Investigador", "Investigador")
                        .WithMany()
                        .HasForeignKey("InvestigadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Investigador");
                });
#pragma warning restore 612, 618
        }
    }
}
