﻿// <auto-generated />
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEndV1.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20210612113256_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BackEndV1.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
