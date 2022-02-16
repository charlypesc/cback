using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IRepository
{
    public interface IEstablecimientoRepository
    {
        Task SaveEstablecimiento(Establecimiento establecimiento);
        Task<List<Establecimiento>> GetEstablecimientos();
        Task<Establecimiento> GetEstablecimientoById(int id);
        Task UpdateEstablecimiento(Establecimiento establecimiento);
        Task EliminaEstablecimiento(Establecimiento establecimiento);
    }
}
