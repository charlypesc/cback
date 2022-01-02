using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Persistence.Repository
{
    public class TematicasRepository : ITematicasRepository
    {
        private readonly AplicationDbContext _context;
            public TematicasRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateTematicas(Tematicas tematicas)
        {
            _context.Add(tematicas);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTematica(Tematicas tematicas)
        {
            _context.Remove(tematicas);
            await _context.SaveChangesAsync();
        }

        public async Task<Tematicas> GetTematicaById(int id)
        {
            var tematica = await _context.Tematicas.Where(x => x.Id == id).FirstOrDefaultAsync();
            return tematica;
        }

        public async Task<List<Tematicas>> GetTematicas(string rbd)
        {
            var tematicas = await _context.Tematicas.Where(x => x.Rbd == rbd).ToListAsync();
            return tematicas;
        }

        public async Task UpdateTematica(Tematicas tematicas)
        {
            _context.Update(tematicas);
            await _context.SaveChangesAsync();
        }
    }
}
