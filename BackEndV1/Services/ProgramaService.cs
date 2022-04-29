using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;

namespace BackEndV1.Services
{
    public class ProgramaService : IProgramaService
    {
        private readonly IProgramaRepository _programaRepository;
        public ProgramaService(IProgramaRepository programaRepository)
        {
            _programaRepository = programaRepository;
        }
        public async Task CreatePrograma(Programa programa)
        {
            await _programaRepository.CreatePrograma(programa);      
        }

        public async Task EliminarPrograma(Programa programa)
        {
            await _programaRepository.EliminarPrograma(programa);
        }

        public async Task<List<Programa>> GetListProgramas(string rbd)
        {
            return await _programaRepository.GetListProgramas(rbd);
        }

        public async Task <Programa>GetPrograma(int idPrograma)
        {
            return await _programaRepository.GetPrograma(idPrograma);
        }

        public async Task UpdatePrograma(Programa programa)
        {
          await _programaRepository.UpdatePrograma(programa);
        }
    }
}