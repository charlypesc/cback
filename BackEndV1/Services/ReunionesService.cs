using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class ReunionesService : IReunionesService
    {
        private readonly IReunionesRepository _reunionesRepository;
        public ReunionesService(IReunionesRepository reunionesRepository)
        {
            _reunionesRepository = reunionesRepository;
        }
        public async Task CreateReunion(Reuniones reuniones)
        {
            await _reunionesRepository.CreateReunion(reuniones);
        }

        public async Task<Reuniones>GetReunionById(int id)
        {
            return await _reunionesRepository.GetReunionById(id);
        }
    }
}
