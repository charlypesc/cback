
using System.Collections.Generic;
using System.Threading.Tasks;
using BackEndV1.Domain.Models;

namespace BackEndV1.Domain.IRepository
{

    public interface IProgramaRepository
    {
        Task CreatePrograma(Programa programa); 
        Task GetPrograma (int idPrograma);
        Task <List<Programa>> GetListProgramas(string rbd);
        Task EliminarPrograma (Programa programa);
        Task UpdatePrograma (Programa programa);

    }

}
