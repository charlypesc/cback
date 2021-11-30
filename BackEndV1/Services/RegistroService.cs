﻿using BackEndV1.Domain.IRepository;
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


        public async Task<List<ParticipanteReg>> GetRegistroByRut(string rutParticipante)
        {
            return await _registroRepository.GetRegistroByRut(rutParticipante);
        }
        public async Task<List<Registro>> GetRegistro(int id)
        {
            return await _registroRepository.GetRegistro(id);
        }

    }
}