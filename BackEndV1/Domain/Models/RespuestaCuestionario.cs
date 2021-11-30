using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class RespuestaCuestionario
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string NombrePartipantes { get; set; }

        public DateTime Fecha { get; set; }
        public int Activo { get; set; }
        public int CuestionarioId { get; set; }//clave foranea
        public Cuestionario Cuestionario { get; set; }//propiedad navegacional
        public List<RespuestaCuestionarioDetalle> ListCuestionarioDetalle { get; set; }//esta clase tendra una lista que viene de cuestionarioDetalle
    }
}

