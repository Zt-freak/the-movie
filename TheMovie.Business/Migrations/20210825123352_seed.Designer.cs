﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheMovie.Business.Context;

namespace TheMovie.Business.Migrations
{
    [DbContext(typeof(MoviesDataContext))]
    [Migration("20210825123352_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheMovie.Business.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jaws",
                            ReleaseDate = new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Luca",
                            ReleaseDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kill Bill",
                            ReleaseDate = new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bee Movie",
                            ReleaseDate = new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Name = "Test",
                            ReleaseDate = new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
