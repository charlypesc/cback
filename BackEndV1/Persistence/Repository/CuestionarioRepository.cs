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
    public class CuestionarioRepository : ICuestionarioRepository
    {
        private readonly AplicationDbContext _context;
        public CuestionarioRepository(AplicationDbContext context)//inyeccion de dependencia en el constructor
        {
            _context = context;
        }

        //se implementa el metodo que trae la interfaz
        public async Task CreateCuestionario(Cuestionario cuestionario)
        {
            _context.Add(cuestionario);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Cuestionario>> GetListCuestionarioByUser(int idUsuario)
        {
           var listCuestionario =  await _context.Cuestionario.Where(x => x.Activo == 1 && x.UsuarioId == idUsuario).ToListAsync();
           return listCuestionario;
        }
        public async Task<Cuestionario> GetCuestionario(int idCuestionario)
        {
            var cuestionario = await _context.Cuestionario.Where(x => x.Id == idCuestionario 
                                                                && x.Activo == 1)
                                                                .Include(x=>x.listPreguntas)
                                                                .ThenInclude(x=> x.listRespuesta)
                                                                .FirstOrDefaultAsync();
            return cuestionario;
        }
        public async Task<Cuestionario> BuscarCuestionario(int idCuestionario, int idUsuario)
        {
            var cuestionario = await _context.Cuestionario.Where(x => x.Id == idCuestionario && x.Activo == 1 && x.UsuarioId == idUsuario).FirstOrDefaultAsync();
            return cuestionario;
        }
        //no se elimina sino que se elimina logicamente cambiando su estado.
        public async Task EliminarCuestionario(Cuestionario cuestionario)
        {
            cuestionario.Activo = 0;
            _context.Entry(cuestionario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<List<Cuestionario>> GetListCuestionarios()
        {
           
            //se setea el objeto para que no envio todos los datos como la contrasena. V103
            var listCuestionarios = await _context.Cuestionario.Where(x => x.Activo == 1)
                                                                     .Select(o => new Cuestionario 
                                                                     {
                                                                         Id = o.Id,
                                                                         Nombre = o.Nombre,
                                                                         Descripcion = o.Descripcion,
                                                                         FechaCreacion = o.FechaCreacion,
                                                                         Usuario = new Usuario 
                                                                         { 
                                                                             NombreUsuario = o.Usuario.NombreUsuario
                                                                          }
                                                                     })
                                                                     
                                                                     .ToListAsync();
            return listCuestionarios;
        }

    }
}
