﻿// <auto-generated />
using System;
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEndV1.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20211129160151_v179484171129210101")]
    partial class v179484171129210101
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BackEndV1.Domain.Models.Cuestionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Activo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cuestionario");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Establecimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comuna")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NombreEstablecimiento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rbd")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Establecimiento");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alergias")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Apoderado")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ApoderadoSuplente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Comuna")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ContactoEmergencia")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CorreoApoderado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CorreoApoderadoSuplente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Curso")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Direccion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DireccionApoderado")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DireccionApoderadoSuplente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EnfermedadesCronicas")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Establecimiento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GrupoSanguineo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MedicamentosContraindicados")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Pie")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Prevision")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rbd")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Run")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TelefonoApoderado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TelefonoApoderadoSuplente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TelefonoEmergencia")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Establecimiento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Rbd")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.ParticipanteReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Activo")
                        .HasColumnType("int");

                    b.Property<string>("Asunto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NombreParticipante")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<string>("Rut")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistroId");

                    b.ToTable("ParticipanteReg");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Pregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CuestionarioId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CuestionarioId");

                    b.ToTable("Pregunta");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.ProtocoloReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descripcionProtocolo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nombreProtocolo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("protocoloId")
                        .HasColumnType("int");

                    b.Property<int>("registroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("registroId");

                    b.ToTable("ProtocoloReg");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.ProtocolosActuacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionProtocolo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NombreEstablecimiento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NombreProtocolo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rbd")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ProtocoloActuacion");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Registro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Acuerdos")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Antecedentes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Profesional")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Registro");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Respuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PreguntaId")
                        .HasColumnType("int");

                    b.Property<bool>("esCorrecta")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("PreguntaId");

                    b.ToTable("Respuesta");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.RespuestaCuestionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Activo")
                        .HasColumnType("int");

                    b.Property<int>("CuestionarioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NombrePartipantes")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CuestionarioId");

                    b.ToTable("RespuestaCuestionario");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.RespuestaCuestionarioDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RespuestaCuestionarioId")
                        .HasColumnType("int");

                    b.Property<int>("RespuestaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RespuestaCuestionarioId");

                    b.HasIndex("RespuestaId");

                    b.ToTable("RespuestaCuestionarioDetalles");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Establecimiento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nivel")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Rbd")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rut")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Cuestionario", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.ParticipanteReg", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.Registro", "Registro")
                        .WithMany("ParticipanteReg")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Pregunta", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.Cuestionario", "Cuestionario")
                        .WithMany("listPreguntas")
                        .HasForeignKey("CuestionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.ProtocoloReg", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.Registro", "Registro")
                        .WithMany()
                        .HasForeignKey("registroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Registro", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.Respuesta", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.Pregunta", "Pregunta")
                        .WithMany("listRespuesta")
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.RespuestaCuestionario", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.Cuestionario", "Cuestionario")
                        .WithMany()
                        .HasForeignKey("CuestionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEndV1.Domain.Models.RespuestaCuestionarioDetalle", b =>
                {
                    b.HasOne("BackEndV1.Domain.Models.RespuestaCuestionario", "RespuestaCuestionario")
                        .WithMany("ListCuestionarioDetalle")
                        .HasForeignKey("RespuestaCuestionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEndV1.Domain.Models.Respuesta", "Respuesta")
                        .WithMany()
                        .HasForeignKey("RespuestaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
