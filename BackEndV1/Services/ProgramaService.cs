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
        public Task CreatePrograma(Programa programa)
        {
            throw new System.NotImplementedException();
        }

        public Task EliminarPrograma(Programa programa)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Programa>> GetListProgramas(string rbd)
        {
            throw new System.NotImplementedException();
        }

        public Task GetPrograma(int idPrograma)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdatePrograma(Programa programa)
        {
            throw new System.NotImplementedException();
        }
    }
}