using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;

namespace BackEndV1.Persistence.Repository
{
    public class ProgramaRepository : IProgramaRepository
    {
        private readonly AplicationDbContext _context;
        public ProgramaRepository(AplicationDbContext context)
        {
            _context = context;
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