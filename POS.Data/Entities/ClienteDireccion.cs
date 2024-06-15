using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities
{
    public class ClienteDireccion
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public ClienteDireccion() 
        { 
            Direccion = string.Empty;
            Cliente = new();
        }
    }
}
