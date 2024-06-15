using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Services
{
    public interface IDetallePedidoService
    {
        Task<IEnumerable<DetallePedido>> GetAllDetallePedidosAsync();
        Task<DetallePedido> GetDetallePedidoByIdAsync(int id);
        Task<DetallePedido> CreateDetallePedidoAsync(DetallePedido detallePedido);
        Task<DetallePedido> UpdateDetallePedidoAsync(DetallePedido detallePedido);
        Task<bool> DeleteDetallePedidoAsync(int id);
    }
}
