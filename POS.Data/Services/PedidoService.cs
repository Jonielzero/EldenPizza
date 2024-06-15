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
    public class PedidoService : IPedidoService
    {
        private readonly EldenPizzaContext _context;

        public PedidoService(EldenPizzaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pedido>> GetAllPedidosAsync()
        {
            return await _context.Pedidos.Include(p => p.Cliente)
                                         .Include(p => p.ClienteDireccion)
                                         .Include(p => p.DetallePedidos)
                                         .ToListAsync();
        }

        public async Task<Pedido> GetPedidoByIdAsync(int id)
        {
            return await _context.Pedidos.Include(p => p.Cliente)
                                         .Include(p => p.ClienteDireccion)
                                         .Include(p => p.DetallePedidos)
                                         .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Pedido> CreatePedidoAsync(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }

        public async Task<Pedido> UpdatePedidoAsync(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return pedido;
        }

        public async Task<bool> DeletePedidoAsync(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return false;
            }

            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
