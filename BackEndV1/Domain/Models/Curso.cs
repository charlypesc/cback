using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Grado { get; set; }
        public string Rbd { get; set; }
        public int Ano { get; set; }
        public int NumeroNivel { get; set; }// uso interno solo para ordenar a propio gusto los cursos y que no lo haga el sistema de manera automatica

    }
}
