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
    public class ProductoService : IProductoService
    {
        private readonly EldenPizzaContext _context;

        public ProductoService(EldenPizzaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetAllProductosAsync()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto> GetProductoByIdAsync(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<Producto> CreateProductoAsync(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task<Producto> UpdateProductoAsync(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task<bool> DeleteProductoAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return false;
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
