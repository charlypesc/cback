using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.Models;

namespace BackEndV1.Domain.IRepository
{
    public interface ISeguimientoRepository
    {
        Task CreateSeguimiento(Seguimiento seguimiento);
        Task <Seguimiento>GetSeguimientoById(int id);
        Task<List<Seguimiento>>GetListSeguimiento(string rut, string rbd);
        Task EliminarSeguimiento(Seguimiento seguimiento);
        Task UpdateSeguimiento(Seguimiento seguimiento);
        Task <List<Seguimiento>> GetAllRbdSeguimientos (string rbd);   
    }
}