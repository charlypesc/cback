﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Respuesta
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Descripcion { get; set; }
        
        [Required]
        public bool esCorrecta { get; set; }

        public int PreguntaId { get; set; }

        public Pregunta Pregunta { get; set; }
        
    }
}
