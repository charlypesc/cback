using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Persistence.Repository
{
    public class FuncionarioRepository: IFuncionarioRepository
    {
        private readonly AplicationDbContext _context;
        public FuncionarioRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveFuncionario(Funcionario funcionario)
        {
            _context.Add(funcionario);
            await _context.SaveChangesAsync();

        }
    }
}
