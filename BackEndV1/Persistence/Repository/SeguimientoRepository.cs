using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEndV1.Persistence.Repository
{
    public class SeguimientoRepository : ISeguimientoRepository
    {
        private readonly AplicationDbContext _context;
        public SeguimientoRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateSeguimiento(Seguimiento seguimiento)
        {
            _context.Add(seguimiento);
            await _context.SaveChangesAsync();
        }

        public Task EliminarSeguimiento(Seguimiento seguimiento)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Seguimiento>> GetAllRbdSeguimientos(string rbd)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Seguimiento>> GetListSeguimiento(string rut, string rbd)
        {
            var listado = await _context.Seguimiento.Where(x=>x.rutEstudiante==rut && x.Rbd==rbd && x.Activo==1)
                                                    .Include(x=>x.SeguimientoProg).ToListAsync();
            return listado;
        }

        public async Task<Seguimiento> GetSeguimientoById(int id)
        {
           return await _context.Seguimiento.Where(x=>x.Id == id)
                                                    .Include(x=>x.SeguimientoProg)
                                                    .FirstOrDefaultAsync();
        }

        public Task UpdateSeguimiento(Seguimiento seguimiento)
        {
            throw new System.NotImplementedException();
        }
    }
}