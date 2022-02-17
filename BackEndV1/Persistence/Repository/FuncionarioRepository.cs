using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.Models;
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;
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

        public async Task EliminaFuncionario(Funcionario funcionario)
        {
            funcionario.Activo = 0;
            _context.Entry(funcionario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Funcionario> GetFuncionarioById(int id)
        {
            var funcionario = await _context.Funcionario.Where(x => x.Id == id).FirstOrDefaultAsync();
            return funcionario;
        }

        public async Task<Funcionario> GetFuncionarioByRut(string rutFuncionario, string rbd)
        {
            var funcionario = await _context.Funcionario.Where(x => x.Rut == rutFuncionario && x.Rbd == rbd).FirstOrDefaultAsync();
            return funcionario;
        }

        public async  Task<List<Funcionario>> GetFuncionariosByRbd(string rbd)
        {
            var funcionario = await _context.Funcionario.Where(x => x.Rbd == rbd && x.Activo ==1).ToListAsync();
            return funcionario;
        }

        public async Task SaveFuncionario(Funcionario funcionario)
        {
            _context.Add(funcionario);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateFuncionario(Funcionario funcionario)
        {
             _context.Update(funcionario);
            await _context.SaveChangesAsync();
        }
    }
}
