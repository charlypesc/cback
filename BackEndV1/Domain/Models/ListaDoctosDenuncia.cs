using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.Models
{
    public class ListaDoctosDenuncia
    {
        public int Id { get; set; }
        public string Profesional { get; set; }
        public string Asunto { get; set; }
        public DateTime Fecha { get; set; }
        public string Rbd { get; set; }
        public string TipoReunion { get; set; }
        public string TipoDoc { get; set; }
        public int IdPropioDoc { get; set; }//id de la bbdd
        public int UsuarioId { get; set; }
        public int DenunciaId { get; set; }
        public Denuncia Denuncia { get; set; }
    }
}
