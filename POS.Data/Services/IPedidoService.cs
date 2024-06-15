using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Services
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetAllPedidosAsync();
        Task<Pedido> GetPedidoByIdAsync(int id);
        Task<Pedido> CreatePedidoAsync(Pedido pedido);
        Task<Pedido> UpdatePedidoAsync(Pedido pedido);
        Task<bool> DeletePedidoAsync(int id);
    }
}
