using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string usuario { get; set; }
        public string Salt { get; set; }
        public byte[] Clave { get; set; }

        public Usuario()
        {
            Nombre = string.Empty;
            Email = string.Empty;
            usuario = string.Empty;
            Salt = string.Empty;
            Clave = new byte[0];
        }
    }
}
