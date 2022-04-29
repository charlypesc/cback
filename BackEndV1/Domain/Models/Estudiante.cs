using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Curso { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Establecimiento { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Run { get; set; }


        public DateTime Nacimiento { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        //Contactos emergencias
        public string ContactoEmergencia { get; set; }
        public string TelefonoEmergencia { get; set; }
        public string GrupoSanguineo { get; set; }
        public string Prevision { get; set; }
        public string Alergias { get; set; }
        public string MedicamentosContraindicados { get; set; }
        public string EnfermedadesCronicas { get; set; }

        //Contactos apoderados

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Apoderado { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string DireccionApoderado { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string TelefonoApoderado { get; set; }
        public string CorreoApoderado { get; set; }
        public string ApoderadoSuplente { get; set; }
        public string DireccionApoderadoSuplente { get; set; }
        public string TelefonoApoderadoSuplente { get; set; }
        public string CorreoApoderadoSuplente { get; set; }
        public Boolean Pie { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Rbd { get; set; }
        public int anoCursando { get; set; }
        public int Activo { get; set; }
        public int NumeroLista { get; set; }
        public int Seguimiento { get; set; }
    }
}
