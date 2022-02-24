using BackEndV1.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndV1.Domain.IService
{
    public interface IUsuarioService
    {
        Task SaveUser(Usuario usuario);
        Task<bool> ValidateExistence(Usuario usuario);
        Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior);
        Task UpdatePassword(Usuario usuario);
        Task UpdateUser(Usuario usuario);
        Task DeleteUser(Usuario usuario);
        Task <List<Usuario>>GetListUsuarioRbd(string rbd, int active);
        Task<Usuario> GetUsuarioById(int id);

        //admin escuela: debe traer todos los usuario de su escuela sin la contrasena

        //superadmin: debe permitir modificar las contrasenas de cualquier establecimiento
    }
}
