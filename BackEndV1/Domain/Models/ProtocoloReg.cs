using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//se agrego git
namespace BackEndV1.Domain.Models
{
    public class ProtocoloReg
    {
        public int Id { get; set; }
        public string NombreProtocolo { get; set; }
        public string DescripcionProtocolo { get; set; }
        public int ProtocoloId { get; set; }
        public int RegistroId { get; set; }
        public Registro Registro { get; set; }

    }
}