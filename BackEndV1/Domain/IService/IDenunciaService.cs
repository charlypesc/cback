using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IService
{
    public interface IDenunciaService
    {
        Task CreateDenuncia(Denuncia denuncia);
        Task <Denuncia> GetDenunciaById(int id);
        Task ActualizaDenuncia(Denuncia denuncia);
        Task<List<Denuncia>> GetDenuncia(int id);
        Task<List<Denuncia>>GetDenunciasAll(string rbd);
        Task <List<Denuncia>>GetDenunciaRut(string rut);
    }
}
