using BackEndV1.Domain.IRepository;
using BackEndV1.Domain.IService;
using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        //CONSTRUCTOR
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        //METODOS
        public async Task SaveUser(Usuario usuario)
        {
            await _usuarioRepository.SaveUser(usuario);
        }
        public async Task <bool>ValidateExistence(Usuario usuario)
        {
            return await _usuarioRepository.ValidateExistence(usuario);
        }
        public async Task<Usuario>ValidatePassword(int idUsuario, string passwordAnterior)
        {
            return await _usuarioRepository.ValidatePassword(idUsuario, passwordAnterior);
        }
        public async Task UpdatePassword(Usuario usuario)
        {
            await _usuarioRepository.UpdatePassword(usuario);
        }

        public async Task UpdateUser(Usuario usuario)
        {
            await _usuarioRepository.UpdateUser(usuario);
        }

        public async Task DeleteUser(Usuario usuario)
        {
            await _usuarioRepository.DeleteUser(usuario);//eliminacion logica
        }

        public async Task<List<Usuario>> GetListUsuarioRbd(string rbd, int active)
        {
           return await _usuarioRepository.GetListUsuarioRbd(rbd, active);
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _usuarioRepository.GetUsuarioById(id);
        }
    }
}
