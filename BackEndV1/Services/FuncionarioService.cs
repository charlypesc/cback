using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class FuncionarioService: IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;

        }

        public async Task EliminaFuncionario(Funcionario funcionario)
        {
             await _funcionarioRepository.EliminaFuncionario(funcionario);
        }

        public async Task<Funcionario> GetFuncionarioById(int id)
        {
            return await _funcionarioRepository.GetFuncionarioById(id);
        }

        public async Task<Funcionario> GetFuncionarioByRut(string rutFuncionario, string rbd)
        {
            return await _funcionarioRepository.GetFuncionarioByRut(rutFuncionario, rbd);
        }

        public async Task<List<Funcionario>> GetFuncionariosByRbd(string rbd)
        {
            return await _funcionarioRepository.GetFuncionariosByRbd(rbd);
        }

        public async Task SaveFuncionario(Funcionario funcionario)
        {
            await _funcionarioRepository.SaveFuncionario(funcionario);
        }

        public async Task UpdateFuncionario(Funcionario funcionario)
        {
            await _funcionarioRepository.UpdateFuncionario(funcionario);
        }
    }
}
