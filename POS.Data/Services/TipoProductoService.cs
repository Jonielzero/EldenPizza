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
    public class TipoProductoService : ITipoProductoService
    {
        private readonly EldenPizzaContext _context;

        public TipoProductoService(EldenPizzaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TipoProducto>> GetAllTipoProductosAsync()
        {
            return await _context.TipoProductos.ToListAsync();
        }

        public async Task<TipoProducto> GetTipoProductoByIdAsync(int id)
        {
            return await _context.TipoProductos.FindAsync(id);
        }

        public async Task<TipoProducto> CreateTipoProductoAsync(TipoProducto tipoProducto)
        {
            _context.TipoProductos.Add(tipoProducto);
            await _context.SaveChangesAsync();
            return tipoProducto;
        }

        public async Task<TipoProducto> UpdateTipoProductoAsync(TipoProducto tipoProducto)
        {
            _context.Entry(tipoProducto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return tipoProducto;
        }

        public async Task<bool> DeleteTipoProductoAsync(int id)
        {
            var tipoProducto = await _context.TipoProductos.FindAsync(id);
            if (tipoProducto == null)
            {
                return false;
            }

            _context.TipoProductos.Remove(tipoProducto);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
