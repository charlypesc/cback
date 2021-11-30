using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IService
{
    public interface IRegistroService
    {
        Task CreateRegistro(Registro registro);
        Task<List<ParticipanteReg>> GetRegistroByRut(string rutParticipante);
        Task<List<Registro>>GetRegistro(int id);
    }
}
