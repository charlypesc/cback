using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IRepository
{
   public interface IFuncionarioRepository

    {
        Task SaveFuncionario(Funcionario funcionario);
        Task<Funcionario> GetFuncionarioByRut(string rutFuncionario, string rbd);
        Task<List<Funcionario>> GetFuncionariosByRbd(string rbd);
        Task<Funcionario> GetFuncionarioById(int id);
        Task EliminaFuncionario(Funcionario funcionario);
        Task UpdateFuncionario(Funcionario funcionario);
    }
}
