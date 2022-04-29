using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IRepository
{
    public interface IEstudianteRepository
    {
        Task SaveEstudiante(Estudiante estudiante);
        Task<Estudiante> GetEstudianteByRut(string rutEstudiante, string rbd);
        Task<List<Estudiante>> GetEstudiantesByRbdByAno(string rbd, int anoCursando);
        Task<List<Estudiante>> GetEstudiantesByRbdByAnoByCurso(string rbd, int anoCursando, string curso);
        Task<Estudiante> GetEstudianteById(int id);
        Task EliminaEstudiante(Estudiante estudiante);
        Task UpdateEstudiante(Estudiante estudiante);
        Task <List<Estudiante>> GetEstudiantesSeguimiento (int seguimiento, string rbd, int anoCursando);
    }
}