using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.Models;

namespace BackEndV1.Domain.IService
{
    public interface ISeguimientoService
    {
        Task CreateSeguimiento(Seguimiento seguimiento);//ok
        Task <Seguimiento>GetSeguimientoById(int id);//ok
        Task<List<Seguimiento>>GetListSeguimiento(string rut, string rbd);//work
        Task EliminarSeguimiento(Seguimiento seguimiento);
        Task UpdateSeguimiento(Seguimiento seguimiento);
        Task <List<Seguimiento>> GetAllRbdSeguimientos (string rbd);   
    }
}