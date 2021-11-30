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
    public class ProtocoloActuacionRepository : IProtocoloActuacionRepository
    {
        private readonly AplicationDbContext _context;

        public ProtocoloActuacionRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateProtocolos(Domain.Models.ProtocolosActuacion protocoloActuacion)
        {
             _context.Add(protocoloActuacion);
            await _context.SaveChangesAsync();
        }


        public async Task<List<ProtocolosActuacion>> GetProtocolos(string rbd)
        {
            var protocolos = await _context.ProtocoloActuacion.Where(x => x.Rbd == rbd).ToListAsync();
            return protocolos;
        }

        public async Task<ProtocolosActuacion> GetProtocoloById(int id)
        {
            var protocolo = await _context.ProtocoloActuacion.Where(x => x.Id == id).FirstOrDefaultAsync();
            return protocolo;
        }
        public async Task EliminarProtocolo(ProtocolosActuacion protocolosActuacion)
        {
            _context.Remove(protocolosActuacion);
            await _context.SaveChangesAsync();
        }
    }
}
