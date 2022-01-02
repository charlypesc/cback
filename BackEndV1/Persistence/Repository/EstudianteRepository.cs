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


    }
}
