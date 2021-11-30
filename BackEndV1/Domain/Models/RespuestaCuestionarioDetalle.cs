using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class RespuestaCuestionarioDetalle //establece una relacion muchos a muchos
    {
        public int Id { get; set; }
        public int RespuestaCuestionarioId { get; set; }//clave foranea
        public RespuestaCuestionario RespuestaCuestionario { get; set; }//navegacional
        public int RespuestaId { get; set; }//2da clave foranea
        public Respuesta Respuesta { get; set; }//navegacional de la 2da clave foranea
    }
}
