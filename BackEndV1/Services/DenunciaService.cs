using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class DenunciaService: IDenunciaService
    {
        private readonly IDenunciaRepository _denunciaRepository;
        public DenunciaService(IDenunciaRepository denunciaRepository)
        {
            _denunciaRepository = denunciaRepository;
        }
        public async Task CreateDenuncia(Denuncia denuncia)
        {
            await _denunciaRepository.CreateDenuncia(denuncia);
        }

        public async Task<Denuncia> GetDenunciaById(int id)
        {
            return await _denunciaRepository.GetDenunciaById(id);
        }
    }
}
