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
        //V A L I D A      U S U A R IO
        public async Task<bool> ValidateExistence(Usuario usuario)
        {
            var validateExistence = await _context.Usuario.AnyAsync(x => x.NombreUsuario == usuario.NombreUsuario);

            return validateExistence;
        }
        //V A L I D A     P A S S W O R D
        public async Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior)
        {
            var usuario = await _context.Usuario.Where(x => x.Id == idUsuario && x.Password == passwordAnterior).FirstOrDefaultAsync();
            return usuario;
        }
        //A C T U A L I Z  A    P A S S W O R D
        public async Task UpdatePassword (Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
        }
        //A C T U A L I Z  A    U S U A R I O
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
        //B U S C A    T O D O S    U S U A R I O S   R B D 
        public async Task<List<Usuario>> GetListUsuarioRbd(string rbd, int active)
        {
            var usuarios = await _context.Usuario.Where(x => x.Rbd == rbd && x.Activo == active).Select(y => new Usuario 
                                                                                                       { Id = y.Id, 
                                                                                                         Nivel = y.Nivel,
                                                                                                         Nombre= y.Nombre,
                                                                                                         Apellido = y.Apellido,
                                                                                                         Rut = y.Rut,
                                                                                                         NombreUsuario = y.NombreUsuario,
                                                                                                         CorreoElectronico = y.CorreoElectronico,
                                                                                                         Establecimiento = y.Establecimiento,
                                                                                                         Activo = y.Activo}).ToListAsync();
            return usuarios;
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            var usuario = await _context.Usuario.Where(x => x.Id == id).FirstOrDefaultAsync();
            return usuario;
        }
    }
}
