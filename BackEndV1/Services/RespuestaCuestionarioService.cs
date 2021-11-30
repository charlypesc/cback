using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class RespuestaCuestionarioService: IRespuestaCuestionarioService
    {
        private readonly IRespuestaCuestionarioRepository _respuestaCuestionarioRepository; 
        public RespuestaCuestionarioService( IRespuestaCuestionarioRepository respuestaCuestionarioRepository)
        {
            _respuestaCuestionarioRepository = respuestaCuestionarioRepository;
        }
        public async Task SaveRespuestaCuestionario(RespuestaCuestionario respuestaCuestionario)
        {
            await _respuestaCuestionarioRepository.SaveRespuestaCuestionario(respuestaCuestionario);
        }
    }
}
