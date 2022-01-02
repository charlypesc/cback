using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class TematicasReg
    {
        public int Id { get; set; }
        public string Tematica { get; set; }
        public string Descripcion { get; set; }
        public string Rbd { get; set; }
        public string TipoFormulario { get; set; }
        public int NumeroId { get; set; }
        public int RegistroId { get; set; }
        public Registro Registro { get; set; } 

    }
}
