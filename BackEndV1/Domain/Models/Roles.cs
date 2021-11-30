using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Roles
    {
        [Required]
        [Column(TypeName = "varchar(20)")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string NombreModulo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nivel { get; set; }
    }
}
