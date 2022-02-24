using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IRepository
{
   public interface IUsuarioRepository
    {
        Task SaveUser(Usuario usuario);
        Task<bool> ValidateExistence(Usuario usuario);
        Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior);
        Task UpdatePassword(Usuario usuario);
        Task UpdateUser(Usuario usuario);
        Task DeleteUser(Usuario usuario);
        Task<List<Usuario>> GetListUsuarioRbd(string rbd, int active);
        Task<Usuario> GetUsuarioById(int id);
    }
}
