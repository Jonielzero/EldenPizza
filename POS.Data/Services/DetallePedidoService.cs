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
    public class DetallePedidoService : IDetallePedidoService
    {
        private readonly EldenPizzaContext _context;

        public DetallePedidoService(EldenPizzaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DetallePedido>> GetAllDetallePedidosAsync()
        {
            return await _context.DetallePedidos.Include(dp => dp.Pedido)
                                                .Include(dp => dp.Producto)
                                                .ToListAsync();
        }

        public async Task<DetallePedido> GetDetallePedidoByIdAsync(int id)
        {
            return await _context.DetallePedidos.Include(dp => dp.Pedido)
                                                .Include(dp => dp.Producto)
                                                .FirstOrDefaultAsync(dp => dp.Id == id);
        }

        public async Task<DetallePedido> CreateDetallePedidoAsync(DetallePedido detallePedido)
        {
            _context.DetallePedidos.Add(detallePedido);
            await _context.SaveChangesAsync();
            return detallePedido;
        }

        public async Task<DetallePedido> UpdateDetallePedidoAsync(DetallePedido detallePedido)
        {
            _context.Entry(detallePedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return detallePedido;
        }

        public async Task<bool> DeleteDetallePedidoAsync(int id)
        {
            var detallePedido = await _context.DetallePedidos.FindAsync(id);
            if (detallePedido == null)
            {
                return false;
            }

            _context.DetallePedidos.Remove(detallePedido);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
