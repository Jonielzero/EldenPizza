using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public List<ClienteDireccion> Direcciones { get; set; }

        public Cliente()
        {
            Nombre = String.Empty;
            Telefono = String.Empty;
            Direcciones = [];
        }
    }

    

}
