using EldenPizza.POS.WebApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly EldenPizzaContext _context;

        public UsuarioService(EldenPizzaContext context)
        {
            _context = context;
        }
        public async Task<Usuario> GetUsuarioByCredentialsAsync(string username, string password)
        {
            var usuario = await _context.Usuarios
                .SingleOrDefaultAsync(u => u.Email == username);

            if (usuario == null)
                return null;

            var hashedPassword = HashPassword(password, usuario.Salt);
            if (hashedPassword.SequenceEqual(usuario.Clave))
                return usuario;

            return null;
        }

        private byte[] HashPassword(string password, string salt)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var saltedPassword = Encoding.UTF8.GetBytes(password + salt);
                return sha256.ComputeHash(saltedPassword);
            }
        }
        public async Task<IEnumerable<Usuario>> GetAllUsuariosAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<Usuario> CreateUsuarioAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> UpdateUsuarioAsync(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<bool> DeleteUsuarioAsync(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return false;
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<Usuario> GetUsuarioByCredentialsAsync(object username, object password)
        {
            throw new NotImplementedException();
        }
    }
}
