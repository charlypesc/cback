using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class SeguimientoProg
    {
        public int Id {get; set; }
        public string NombrePrograma { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public string Rbd { get; set; }
        public int Activo { get; set; }
        public int SeguimientoId { get; set; }
        public Seguimiento Seguimiento { get; set; }
        
    }
}