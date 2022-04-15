using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class RegistroService: IRegistroService
    {
        private readonly IRegistroRepository _registroRepository;
        public RegistroService(IRegistroRepository registroRepository)
        {
            _registroRepository = registroRepository;
        }
        public async Task CreateRegistro(Registro registro)
        {
            await _registroRepository.CreateRegistro(registro);
        }


        public async Task<List<ParticipanteReg>> GetRegistroByRut(string rutParticipante, string rbd)
        {
            return await _registroRepository.GetRegistroByRut(rutParticipante, rbd);
        }
        public async Task<List<Registro>> GetRegistro(int id)
        {
            return await _registroRepository.GetRegistro(id);
        }

        public async Task EliminarRegistro(Registro registro)
        {
            await _registroRepository.EliminarRegistro(registro);
        }

        public async Task<Registro> BuscarRegistro(int idRegistro)
        {
           return await _registroRepository.BuscarRegistro(idRegistro);
        }

        public async Task<List<Registro>> GetRegistrosAll(string rbd)
        {
            return await _registroRepository.GetRegistrosAll(rbd);
        }
    }
}
