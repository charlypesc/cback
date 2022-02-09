using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class Denuncia
    {
        public int Id { get; set; }
        public string Profesional { get; set; }
        public string Organismo { get; set; }
        public string RutAsociado { get; set; }
        public string FolioRit { get; set; }
        public int FolioInterno { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaAsignada { get; set; }
        //lista con registros asociados registros o visitas
        public List<ListaDoctosDenuncia> ListaDoctosDenuncia { get; set; }
        //lista con registros de terceros
    }
}
