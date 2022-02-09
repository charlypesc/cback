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
    public class UsuarioRepository: IUsuarioRepository 
    {
        private readonly AplicationDbContext _context;
        //CONSTRUCTOR
        public UsuarioRepository(AplicationDbContext context)
        {
            _context = context;
        }
        //METODOS
        public async Task SaveUser(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ValidateExistence(Usuario usuario)
        {
            var validateExistence = await _context.Usuario.AnyAsync(x => x.NombreUsuario == usuario.NombreUsuario);

            return validateExistence;
        }
        public async Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior)
        {
            var usuario = await _context.Usuario.Where(x => x.Id == idUsuario && x.Password == passwordAnterior).FirstOrDefaultAsync();
            return usuario;
        }
        public async Task UpdatePassword (Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
        }
        //E L I M I N A  - eliminacion del usuario de manera logica
        public async Task DeleteUser(Usuario usuario)
        {
            usuario.Activo = 0;
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
