using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IRepository
{
    public interface IProtocoloActuacionRepository
    {
        Task CreateProtocolos(ProtocolosActuacion protocolosActuacion);
        Task<List<ProtocolosActuacion>> GetProtocolos(string rbd);
        Task <ProtocolosActuacion>GetProtocoloById(int id);
        Task EliminarProtocolo(ProtocolosActuacion protocolosActuacion);
    }
}
