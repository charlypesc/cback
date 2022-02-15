using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class CursoService: ICursoService 
    {
        private readonly ICursoRepository _cursoRepository;
        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task<List<Curso>> GetCursos(string rbd, int anoCursando)
        {
            return await _cursoRepository.GetCursos(rbd, anoCursando);
        }
    }
}
