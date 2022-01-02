using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IService
{
   public interface IVisitaDomiciliariaService
    {
        Task CreateVisita(VisitaDomiciliaria visita);
        Task<List<VisitaDomiciliaria>> GetVisitaDomiciliaria(int id);
        Task EliminarVisita(VisitaDomiciliaria visita);
        Task<VisitaDomiciliaria> BuscarVisita(int idVisita);
    }
}
