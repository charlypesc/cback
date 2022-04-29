using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.Models;

namespace BackEndV1.Domain.IService
{
    public interface IProgramaService
    {
        Task CreatePrograma(Programa programa); 
        Task <Programa>GetPrograma (int idPrograma);
        Task <List<Programa>> GetListProgramas(string rbd);
        Task EliminarPrograma (Programa programa);
        Task UpdatePrograma (Programa programa);
    }
}