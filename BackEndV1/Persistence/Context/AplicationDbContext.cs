﻿using BackEndV1.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Persistence.Context
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<Cuestionario> Cuestionario { get; set; }
        public DbSet<Respuesta> Respuesta { get; set; }
        public DbSet<RespuestaCuestionario> RespuestaCuestionario { get; set; }
        public DbSet<RespuestaCuestionarioDetalle> RespuestaCuestionarioDetalles { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Establecimiento> Establecimiento { get; set; }
        public DbSet<Registro> Registro { get; set; }
        public DbSet<ParticipanteReg> ParticipanteReg { get; set; }
        public DbSet<ProtocolosActuacion> ProtocoloActuacion { get; set; }
        public DbSet<ProtocoloReg> ProtocoloReg { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {

        }
    }
}
