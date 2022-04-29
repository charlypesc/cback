using BackEndV1.Domain.IRepository;
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
        public async Task<Estudiante> GetEstudianteByRut(string rutEstudiante, string rbd)
        {
            return await _estudianteRepository.GetEstudianteByRut(rutEstudiante, rbd);
        }
        public async Task<List<Estudiante>> GetEstudiantesByRbdByAno(string rbd, int anoCursando)
        {
            return await _estudianteRepository.GetEstudiantesByRbdByAno(rbd, anoCursando);
        }
        public async Task<List<Estudiante>> GetEstudiantesByRbdByAnoByCurso(string rbd, int anoCursando, string curso)
        {
            return await _estudianteRepository.GetEstudiantesByRbdByAnoByCurso(rbd, anoCursando, curso);
        }
        public async Task<Estudiante> GetEstudianteById(int id)
        {
            return await _estudianteRepository.GetEstudianteById(id); 
        }
        public async Task EliminaEstudiante(Estudiante estudiante)
        {
            await _estudianteRepository.EliminaEstudiante(estudiante);
        }
        public async Task UpdateEstudiante(Estudiante estudiante)
        {
            await _estudianteRepository.UpdateEstudiante(estudiante);
        }
        public async Task<List<Estudiante>> GetEstudiantesSeguimiento(int seguimiento, string rbd, int anoCursando)
        {
            return await _estudianteRepository.GetEstudiantesSeguimiento(seguimiento, rbd, anoCursando );
        }
    }
}
