using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class ProtocoloActuacionService: IProtocoloActuacionService 
    {
        private readonly IProtocoloActuacionRepository _protocoloActuacionRepository; 
        public ProtocoloActuacionService(IProtocoloActuacionRepository protocoloActuacionRepository)
        {
            _protocoloActuacionRepository = protocoloActuacionRepository;

        }
        public async Task CreateProtocolos(ProtocolosActuacion protocolosActuacion)
        {
            await _protocoloActuacionRepository.CreateProtocolos(protocolosActuacion);
        }


        public async Task<List<ProtocolosActuacion>> GetProtocolos(string rbd)
        {
            return await _protocoloActuacionRepository.GetProtocolos(rbd);
        }
        public async Task<ProtocolosActuacion> GetProtocoloById(int id)
        {
           return await _protocoloActuacionRepository.GetProtocoloById(id);
        }
        public async Task EliminarProtocolo(ProtocolosActuacion protocolosActuacion)
        {
            await _protocoloActuacionRepository.EliminarProtocolo(protocolosActuacion);
        }

        public async Task UpdateProtocolo(ProtocolosActuacion protocolosActuacion)
        {
            await _protocoloActuacionRepository.UpdateProtocolo(protocolosActuacion);
        }
    }
}
