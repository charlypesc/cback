using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IService
{
    public interface IReunionesService
    {
        Task CreateReunion(Reuniones reuniones);
        Task<List<Reuniones>>GetReunionById(int id);
        Task UpdateReuniones(Reuniones Reuniones);
        Task<List<Reuniones>> GetReunionesByRut(string rut, string rbd);
        Task<List<Reuniones>>GetReunionesAll(string rbd);
    }
}
