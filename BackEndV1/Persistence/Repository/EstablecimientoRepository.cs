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
    public class EstablecimientoRepository : IEstablecimientoRepository 
    {
        private readonly AplicationDbContext _context;
        public EstablecimientoRepository( AplicationDbContext context)
        {
            _context = context;
        }

        public async Task EliminaEstablecimiento(Establecimiento establecimiento)
        {
            establecimiento.Activo = 0;
            _context.Entry(establecimiento).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Establecimiento> GetEstablecimientoById(int id)
        {
            var establecimiento = await _context.Establecimiento.Where(x => x.Id == id).FirstOrDefaultAsync();
            return establecimiento;
        }

        public async Task<List<Establecimiento>> GetEstablecimientos()
        {
            var establecimientos = await _context.Establecimiento.Where(x => x.Activo == 1).ToListAsync();
            return establecimientos;
        }

        public async Task SaveEstablecimiento(Establecimiento establecimiento)
        {
            _context.Add(establecimiento);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEstablecimiento(Establecimiento establecimiento)
        {
            _context.Update(establecimiento);
            await _context.SaveChangesAsync();
        }
    }
}
