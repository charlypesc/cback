using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class TematicasServices: ITematicasService
    {
        private readonly ITematicasRepository _tematicasRepository;
        public TematicasServices(ITematicasRepository tematicasRepository)
        {
            _tematicasRepository = tematicasRepository;
        }

        public async Task CreateTematicas(Tematicas tematicas)
        {
            await _tematicasRepository.CreateTematicas(tematicas);
        }

        public async Task DeleteTematica(Tematicas tematicas)
        {
            await _tematicasRepository.DeleteTematica(tematicas);
        }

        public async Task<Tematicas> GetTematicaById(int id)
        {
            return await _tematicasRepository.GetTematicaById(id);
        }

        public async Task<List<Tematicas>> GetTematicas(string rbd)
        {
            return await _tematicasRepository.GetTematicas(rbd);
        }

        public async Task UpdateTematica(Tematicas tematicas)
        {
            await _tematicasRepository.UpdateTematica(tematicas);
        }
    }
}
