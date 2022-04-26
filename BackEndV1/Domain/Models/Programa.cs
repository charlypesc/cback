using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Programa
    {
        public int Id { get; set; }
        public string CreadoPor {  get; set; }
        public DateTime fechaCreacionPrograma{ get; set; }
        public string NombrePrograma { get; set; }
        public string DescripcionPrograma { get; set; }
        public int Activo { get; set; }
        public string Rbd { get; set; }

    }
}