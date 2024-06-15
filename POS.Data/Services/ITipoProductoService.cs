using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Services
{
    public interface ITipoProductoService
    {
        Task<IEnumerable<TipoProducto>> GetAllTipoProductosAsync();
        Task<TipoProducto> GetTipoProductoByIdAsync(int id);
        Task<TipoProducto> CreateTipoProductoAsync(TipoProducto tipoProducto);
        Task<TipoProducto> UpdateTipoProductoAsync(TipoProducto tipoProducto);
        Task<bool> DeleteTipoProductoAsync(int id);
    }
}
