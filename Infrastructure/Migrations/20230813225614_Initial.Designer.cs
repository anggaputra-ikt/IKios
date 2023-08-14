﻿// <auto-generated />
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230813225614_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Kios", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<decimal>("Harga")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lantai")
                        .HasColumnType("int");

                    b.Property<string>("Luas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipe")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kios");
                });

            modelBuilder.Entity("Domain.Entities.Penyewa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Domisili")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JenisKelamin")
                        .HasColumnType("int");

                    b.Property<string>("Kota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaLengkap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempatLahir")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Penyewa");
                });
#pragma warning restore 612, 618
        }
    }
}