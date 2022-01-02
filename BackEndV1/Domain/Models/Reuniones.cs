using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Reuniones
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Profesional { get; set; }//ok

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Asunto { get; set; }//ok

        [Required]
        [Column(TypeName = "varchar(50)")]
        public DateTime Fecha { get; set; }//ok
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Rbd { get; set; }//ok
        public string TipoReunion { get; set; }//ok
        public string RutAsociado { get; set; }//ok
        public string Antecedentes { get; set; }
        public string Acuerdos { get; set; }
        public int Activo { get; set; }//ok
        public string Tipo { get; set; }//ok
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<ParticipanteReg> ParticipanteReg { get; set; }
        public List<ProtocoloReg> ProtocoloReg { get; set; }
        public List<TematicasReg> TematicasReg { get; set; }
    }
}
