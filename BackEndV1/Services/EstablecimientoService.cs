using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class EstablecimientoService: IEstablecimientoService
    {
        private readonly IEstablecimientoRepository _establecimientoRepository;
        public EstablecimientoService(IEstablecimientoRepository establecimientoRepository)
        {
            _establecimientoRepository = establecimientoRepository;
        }

        public async Task EliminaEstablecimiento(Establecimiento establecimiento)
        {
            await _establecimientoRepository.EliminaEstablecimiento(establecimiento);
        }

        public async Task<Establecimiento> GetEstablecimientoById(int id)
        {
            return await _establecimientoRepository.GetEstablecimientoById(id);
        }

        public async Task<List<Establecimiento>> GetEstablecimientos()
        {
            return await _establecimientoRepository.GetEstablecimientos();
        }

        public async Task SaveEstablecimiento(Establecimiento establecimiento)
        {
            await _establecimientoRepository.SaveEstablecimiento(establecimiento);
        }

        public Task UpdateEstablecimiento(Establecimiento establecimiento)
        {
            throw new NotImplementedException();
        }
    }
}
