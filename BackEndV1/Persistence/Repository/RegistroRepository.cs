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
    public class RegistroRepository : IRegistroRepository 
    {
        private readonly AplicationDbContext _context;
        public RegistroRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateRegistro(Registro registro)
        {
            _context.Add(registro);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ParticipanteReg>> GetRegistroByRut(string rutParticipante)
        {
            var registro = await _context.ParticipanteReg.Where(x => x.Rut == rutParticipante && x.Activo == 1).ToListAsync();
            return registro;
        }
        public async Task<List<Registro>> GetRegistro(int id)
        {
            var registroCompleto = await _context.Registro.Where(x => x.Id == id)
                                                                 .Include(x=>x.ParticipanteReg).ToListAsync();
            return registroCompleto;
        }
    }
}
