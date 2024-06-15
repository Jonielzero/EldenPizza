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
    public class ClienteDireccionService : IClienteDireccionService
    {
        private readonly EldenPizzaContext _context;

        public ClienteDireccionService(EldenPizzaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClienteDireccion>> GetAllClienteDireccionesAsync()
        {
            return await _context.ClienteDirecciones.ToListAsync();
        }

        public async Task<ClienteDireccion> GetClienteDireccionByIdAsync(int id)
        {
            return await _context.ClienteDirecciones.FindAsync(id);
        }

        public async Task<ClienteDireccion> CreateClienteDireccionAsync(ClienteDireccion clienteDireccion)
        {
            _context.ClienteDirecciones.Add(clienteDireccion);
            await _context.SaveChangesAsync();
            return clienteDireccion;
        }

        public async Task<ClienteDireccion> UpdateClienteDireccionAsync(ClienteDireccion clienteDireccion)
        {
            _context.Entry(clienteDireccion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return clienteDireccion;
        }

        public async Task<bool> DeleteClienteDireccionAsync(int id)
        {
            var clienteDireccion = await _context.ClienteDirecciones.FindAsync(id);
            if (clienteDireccion == null)
            {
                return false;
            }

            _context.ClienteDirecciones.Remove(clienteDireccion);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
