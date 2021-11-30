using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Funcionario
    {

        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Rut { get; set; }


        public string Telefono { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CorreoElectronico { get; set; }


        public string Direccion { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Establecimiento { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Cargo { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Rbd { get; set; }
    }
}
