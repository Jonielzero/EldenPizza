using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities
{
    public class Pedido
    {
            public int Id { get; set; }
            public int ClienteDireccionId { get; set; }
            public int ClienteId { get; set; }
            public int TotalProducto { get; set; }
            public decimal Total { get; set; }

            public ClienteDireccion ClienteDireccion { get; set; }

            public Cliente Cliente { get; set; }

            public List<DetallePedido> DetallePedidos { get; set; }

            public Pedido()
            {
                DetallePedidos = new List<DetallePedido>();
            }
        }
    }
