﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelos;

#nullable disable

namespace Modelos.Migrations
{
    [DbContext(typeof(ContextoConversor))]
    partial class ContextoConversorModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaNacimiento = new DateTime(1998, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Pedro",
                            Telefono = "948230430",
                            UserName = "Pedro",
                            password = "password"
                        },
                        new
                        {
                            Id = 2,
                            FechaNacimiento = new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ana",
                            Telefono = "123456789",
                            UserName = "Ana",
                            password = "password"
                        },
                        new
                        {
                            Id = 3,
                            FechaNacimiento = new DateTime(1990, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Luis",
                            Telefono = "987654321",
                            UserName = "Luis",
                            password = "password"
                        },
                        new
                        {
                            Id = 4,
                            FechaNacimiento = new DateTime(1987, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "María",
                            Telefono = "555123789",
                            UserName = "María",
                            password = "password"
                        },
                        new
                        {
                            Id = 5,
                            FechaNacimiento = new DateTime(2005, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Juan",
                            Telefono = "777888999",
                            UserName = "Juan",
                            password = "password"
                        },
                        new
                        {
                            Id = 6,
                            FechaNacimiento = new DateTime(2002, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Laura",
                            Telefono = "333444555",
                            UserName = "Laura",
                            password = "password"
                        },
                        new
                        {
                            Id = 7,
                            FechaNacimiento = new DateTime(1978, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Carlos",
                            Telefono = "999111222",
                            UserName = "Carlos",
                            password = "password"
                        },
                        new
                        {
                            Id = 8,
                            FechaNacimiento = new DateTime(1983, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Marta",
                            Telefono = "444555666",
                            UserName = "Marta",
                            password = "password"
                        },
                        new
                        {
                            Id = 9,
                            FechaNacimiento = new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Andrés",
                            Telefono = "888999000",
                            UserName = "Andrés",
                            password = "password"
                        },
                        new
                        {
                            Id = 10,
                            FechaNacimiento = new DateTime(1970, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Isabel",
                            Telefono = "222333444",
                            UserName = "Isabel",
                            password = "password"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
