using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class ProtocoloReu
    {
        public int Id { get; set; }
        public string NombreProtocolo { get; set; }
        public string DescripcionProtocolo { get; set; }
        public int ProtocoloId { get; set; }
        public int ReunionesId { get; set; }
        public Reuniones Reuniones { get; set; }
    }
}
