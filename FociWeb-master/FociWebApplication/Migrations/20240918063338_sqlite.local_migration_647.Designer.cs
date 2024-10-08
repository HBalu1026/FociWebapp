﻿// <auto-generated />
using FociWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FociWebApplication.Migrations
{
    [DbContext(typeof(FociDbContext))]
    [Migration("20240918063338_sqlite.local_migration_647")]
    partial class sqlitelocal_migration_647
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("FociWebApplication.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fordulo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HazaGolok")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HazaiCsapat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HazaiElsoFelidoGolok")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VegEredmeny1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VendegCsapat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VendegElsoFelidoGolok")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VendegGolok")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Meccsek");
                });
#pragma warning restore 612, 618
        }
    }
}
