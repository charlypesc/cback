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
    public class DenunciaRepository : IDenunciaRepository
    {
        private readonly AplicationDbContext _context;
        public DenunciaRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task ActualizaDenuncia(Denuncia denuncia)
        {
            _context.Update(denuncia);
            await _context.SaveChangesAsync();
        }
        public async Task CreateDenuncia(Denuncia denuncia)
        {
            _context.Add(denuncia);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Denuncia>> GetDenuncia(int id)
        {
            var denuncia = await _context.Denuncia.Where(x => x.Id == id)
                                                         .Include(x=>x.ListaDoctosDenuncia)
                                                         .ToListAsync();
            return denuncia;
        }

        public async Task<Denuncia> GetDenunciaById(int id)
        {
            var denuncia = await _context.Denuncia.Where(x=> x.Id == id).FirstOrDefaultAsync();
            return denuncia;
        }
        
       
        
    }
}
