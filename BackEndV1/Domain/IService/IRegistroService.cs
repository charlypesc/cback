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
        Task<List<ParticipanteReg>> GetRegistroByRut(string rutParticipante, string rbd);
        Task<List<Registro>>GetRegistro(int id);
        Task EliminarRegistro(Registro registro);
        Task<Registro> BuscarRegistro(int idRegistro);
    }
}
