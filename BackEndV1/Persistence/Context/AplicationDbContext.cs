using BackEndV1.Domain.Models;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Tematicas> Tematicas { get; set; }
        public DbSet<TematicasReg> TematicasReg { get; set; }
        public DbSet<Reuniones> Reuniones { get; set; }
        public DbSet<ParticipanteManual>ParticipanteManual {get; set;}
        public DbSet<TematicasReu> TematicasReu { get; set; }
        public DbSet<ProtocoloReu> ProtocolosReu { get; set; }
        public DbSet<Denuncia> Denuncia { get; set; }
        public DbSet<ListaDoctosDenuncia> ListaDoctosDenuncia { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Programa> Programa { get; set; }
        public DbSet<Seguimiento> Seguimiento { get; set; }
        public DbSet<SeguimientoProg> SeguimientoProg { get; set; } 
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {

        }
    }
}
