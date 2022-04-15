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

        public async Task ActualizaDenuncia(Denuncia denuncia)
        {
            await _denunciaRepository.ActualizaDenuncia(denuncia);
        }

        public async Task CreateDenuncia(Denuncia denuncia)
        {
            await _denunciaRepository.CreateDenuncia(denuncia);
        }

        public async Task<List<Denuncia>> GetDenuncia(int id)
        {
           return await _denunciaRepository.GetDenuncia(id);
        }

        public async Task<Denuncia> GetDenunciaById(int id)
        {
            return await _denunciaRepository.GetDenunciaById(id);
        }

        public async Task<List<Denuncia>> GetDenunciasAll(string rbd)
        {
            return await _denunciaRepository.GetDenunciasAll(rbd);
        }
    }
}
