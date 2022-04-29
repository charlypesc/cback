using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndV1.Persistence.Repository
{
    public class ProgramaRepository : IProgramaRepository
    {
        private readonly AplicationDbContext _context;
        public ProgramaRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreatePrograma(Programa programa)
        {
            _context.Add(programa);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarPrograma(Programa programa)
        {
           _context.Remove(programa);
           await _context.SaveChangesAsync();
        }

        public async Task<List<Programa>> GetListProgramas(string rbd)
        {
            var list = await _context.Programa.Where(x=>x.Rbd == rbd).ToListAsync();
            return list;
        }
        public async Task<Programa>GetPrograma(int idPrograma)
        {
            return await _context.Programa.Where(x=> x.Id == idPrograma).FirstOrDefaultAsync();
        }

        public async Task UpdatePrograma(Programa programa)
        {
            _context.Update(programa);
            await _context.SaveChangesAsync();
        }
    }
}