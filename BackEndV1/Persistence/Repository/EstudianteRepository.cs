using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using Microsoft.EntityFrameworkCore;
using BackEndV1.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Persistence.Repository
{
    public class EstudianteRepository: IEstudianteRepository
    {
        private readonly AplicationDbContext _context;
        public EstudianteRepository(AplicationDbContext context)
        {
            _context = context;
        }


        public async Task SaveEstudiante(Estudiante estudiante)
        {
            _context.Add(estudiante);
            await _context.SaveChangesAsync();
        }
        public async Task<Estudiante> GetEstudianteByRut(string rutEstudiante, string rbd)
        {
            var rut = await _context.Estudiante.Where(x => x.Run == rutEstudiante && x.Rbd == rbd).FirstOrDefaultAsync();
            return rut;
        }

        public async Task<List<Estudiante>> GetEstudiantesByRbdByAno(string rbd, int anoCursando)
        {
            var estudiante = await _context.Estudiante.Where(x => x.Rbd == rbd && x.anoCursando == anoCursando).ToListAsync();
            return estudiante;
        }

        public async Task<List<Estudiante>> GetEstudiantesByRbdByAnoByCurso(string rbd, int anoCursando, string curso)
        {
            var estudiante = await _context.Estudiante.Where(x => x.Rbd == rbd && x.anoCursando == anoCursando && x.Curso == curso).ToListAsync();
            return estudiante;
        }

        public async Task<Estudiante> GetEstudianteById(int id)
        {
            var estudiante = await _context.Estudiante.Where(x => x.Id == id  && x.Activo == 1).FirstOrDefaultAsync();
            return estudiante;
        }

        public async Task EliminaEstudiante(Estudiante estudiante)
        {
            estudiante.Activo = 0;
            _context.Entry(estudiante).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEstudiante(Estudiante estudiante)
        {
            _context.Update(estudiante);
            await _context.SaveChangesAsync();
        }
    }
}
