using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class ProtocolosActuacion
    {
        public int Id { get; set; }
        public string NombreProtocolo { get; set; }
        public string DescripcionProtocolo { get; set; }
        public string Rbd  { get; set; }
        public string NombreEstablecimiento { get; set; }
    }
}
