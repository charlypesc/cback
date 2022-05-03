using System;
using System.Collections.Generic;

namespace BackEndV1.Domain.Models
{
    public class Seguimiento
    {  
    public int Id { get; set; }
    public string rutEstudiante{ get; set; }
    public string Nota { get; set; }
    public DateTime FechaInicioSeguimiento { get; set; }
    public DateTime FechaFinSeguimiento { get; set; }
    public int UsuarioId { get; set; }
    public int Activo { get; set; }
    public string Rbd { get; set; }
    public List<SeguimientoProg> SeguimientoProg { get; set; }    

    }
}