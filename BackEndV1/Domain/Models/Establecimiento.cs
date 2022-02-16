using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Establecimiento
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string NombreEstablecimiento { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Rbd { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Comuna { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Telefono { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Director { get; set; }
        public int Activo { get; set; }

    }
}
