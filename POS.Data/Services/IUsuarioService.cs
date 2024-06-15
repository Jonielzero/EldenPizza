using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Services
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarioByCredentialsAsync(string username, string password);
        Task<IEnumerable<Usuario>> GetAllUsuariosAsync();
        Task<Usuario> GetUsuarioByIdAsync(int id);
        Task<Usuario> CreateUsuarioAsync(Usuario usuario);
        Task<Usuario> UpdateUsuarioAsync(Usuario usuario);
        Task<bool> DeleteUsuarioAsync(int id);
        Task<Usuario> GetUsuarioByCredentialsAsync(object username, object password);
    }
}
