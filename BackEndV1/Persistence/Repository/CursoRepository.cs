using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Persistence.Repository
{
    public class CursoRepository: ICursoRepository
    {
        private readonly AplicationDbContext _context;
        public CursoRepository( AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Curso>> GetCursos(string rbd, int anoCursando)
        {
            var cursos = await _context.Curso.Where(x => x.Rbd == rbd && x.Ano == anoCursando).ToListAsync();
            return cursos;
        }
    }
}
