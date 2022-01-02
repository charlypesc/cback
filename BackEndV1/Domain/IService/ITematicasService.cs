using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IService
{
    public interface ITematicasService
    {
        Task CreateTematicas(Tematicas tematicas);
        Task<List<Tematicas>> GetTematicas(string rbd);
        Task<Tematicas> GetTematicaById(int id);
        Task DeleteTematica(Tematicas tematicas);
        Task UpdateTematica(Tematicas tematicas);
    }
}
