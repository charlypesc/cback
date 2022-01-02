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
    public class ReunionesRepository: IReunionesRepository
    {
        private readonly AplicationDbContext _context;
        public ReunionesRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateReunion(Domain.Models.Reuniones reuniones)
        {
            _context.Add(reuniones);
            await _context.SaveChangesAsync();
        }

        public async Task<Reuniones>GetReunionById(int id)
        {
            return await _context.Reuniones.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
