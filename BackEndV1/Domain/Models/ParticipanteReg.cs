using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class ParticipanteReg
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string NombreParticipante { get; set; }
        public string Rbd { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Asunto { get; set; }
        public int Activo { get; set; }
        public int UsuarioId { get; set; }
        public int RegistroId { get; set; }
        public Registro Registro { get; set; }
    }
}
