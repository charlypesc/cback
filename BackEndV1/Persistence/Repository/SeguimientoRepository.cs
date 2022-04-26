using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;

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

        public Task<List<Seguimiento>> GetListSeguimiento(string rut, string rbd)
        {
            throw new System.NotImplementedException();
        }

        public Task<Seguimiento> GetSeguimientoById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateSeguimiento(Seguimiento seguimiento)
        {
            throw new System.NotImplementedException();
        }
    }
}