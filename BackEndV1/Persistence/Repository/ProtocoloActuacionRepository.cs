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
        // C R E A 
        public async Task CreateProtocolos(Domain.Models.ProtocolosActuacion protocoloActuacion)
        {
             _context.Add(protocoloActuacion);
            await _context.SaveChangesAsync();
        }

        //B U S C A    R B D 
        public async Task<List<ProtocolosActuacion>> GetProtocolos(string rbd)
        {
            var protocolos = await _context.ProtocoloActuacion.Where(x => x.Rbd == rbd).ToListAsync();
            return protocolos;
        }
        //B U S C A    I D
        public async Task<ProtocolosActuacion> GetProtocoloById(int id)
        {
            var protocolo = await _context.ProtocoloActuacion.Where(x => x.Id == id).FirstOrDefaultAsync();
            return protocolo;
        }
        //E L I M I  N  A
        public async Task EliminarProtocolo(ProtocolosActuacion protocolosActuacion)
        {
            _context.Remove(protocolosActuacion);
            await _context.SaveChangesAsync();
        }
        //A C T U A L I Z A
        public async Task UpdateProtocolo(ProtocolosActuacion protocolosActuacion)
        {
            _context.Update(protocolosActuacion);
            await _context.SaveChangesAsync();
        }
    }
}
