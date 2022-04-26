using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;

namespace BackEndV1.Services
{
    public class SeguimientoService : ISeguimientoService
    {
        private readonly ISeguimientoRepository _seguimientoRepository;
        public SeguimientoService(ISeguimientoRepository seguimientoRepository)
        {
            _seguimientoRepository= seguimientoRepository;
        }
        public async Task CreateSeguimiento(Seguimiento seguimiento)
        {
            await _seguimientoRepository.CreateSeguimiento(seguimiento);
        }

        public Task EliminarSeguimiento(Seguimiento seguimiento)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Seguimiento>> GetAllRbdSeguimientos(string rbd)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Seguimiento>> GetListSeguimiento(string rut, string rbd)
        {
            throw new System.NotImplementedException();
        }

        public Task<Seguimiento> GetSeguimientoById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateSeguimiento(Seguimiento seguimiento)
        {
            throw new System.NotImplementedException();
        }
    }
}