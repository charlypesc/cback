using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Persistence.Repository
{
    public class EstablecimientoRepository : IEstablecimientoRepository 
    {
        private readonly AplicationDbContext _context;
        public EstablecimientoRepository( AplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveEstablecimiento(Establecimiento establecimiento)
        {
            _context.Add(establecimiento);
            await _context.SaveChangesAsync();
        }
    }
}
