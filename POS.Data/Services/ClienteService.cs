using POS.Data;
using POS.Data.Maps;
using POS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldenPizza.POS.WebApi.Infrastructure;

namespace POS.Data.Services
{
    public class ClienteService : IClienteService
    {
        private readonly EldenPizzaContext _context;

        public ClienteService(EldenPizzaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _context.Clientes.Include(c => c.Direcciones).ToListAsync();
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            return await _context.Clientes.Include(c => c.Direcciones)
                                          .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Cliente> CreateClienteAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<bool> DeleteClienteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return false;
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
