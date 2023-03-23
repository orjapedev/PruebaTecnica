﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaTecnica;

#nullable disable

namespace PruebaTecnica.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaTecnica.Entidades.Carga", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NumeroCarga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperacionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("ValorCarga")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OperacionId");

                    b.ToTable("Carga");
                });

            modelBuilder.Entity("PruebaTecnica.Entidades.Operacion", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContactoBodega")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionBodega")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRetiro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroContenedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PesoContenedor")
                        .HasColumnType("int");

                    b.Property<int>("VolumenCarga")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Operaciones");
                });

            modelBuilder.Entity("PruebaTecnica.Entidades.Carga", b =>
                {
                    b.HasOne("PruebaTecnica.Entidades.Operacion", null)
                        .WithMany("Carga")
                        .HasForeignKey("OperacionId");
                });

            modelBuilder.Entity("PruebaTecnica.Entidades.Operacion", b =>
                {
                    b.Navigation("Carga");
                });
#pragma warning restore 612, 618
        }
    }
}
