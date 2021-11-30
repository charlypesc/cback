﻿using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class EstudianteService: IEstudianteService
    {
        private readonly IEstudianteRepository _estudianteRepository;
        public EstudianteService(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public async Task SaveEstudiante(Estudiante estudiante)
        {
            await _estudianteRepository.SaveEstudiante(estudiante);
        }
        public async Task<Estudiante> GetEstudianteByRut(string rutEstudiante)
        {
            return await _estudianteRepository.GetEstudianteByRut(rutEstudiante);
        }

    }
}