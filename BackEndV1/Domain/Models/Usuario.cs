using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(20)")]
        public string NombreUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }


        public string Nivel { get; set; }


        public string Nombre { get; set; }


        public string Apellido { get; set; }

        public string Rut { get; set; }


        public string CorreoElectronico { get; set; }

        public string Establecimiento { get; set; }

        public string Rbd { get; set; }
        public int Activo { get; set; }
    }
}