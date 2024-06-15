using POS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data.Services
{
    public interface IClienteDireccionService
    {
        Task<IEnumerable<ClienteDireccion>> GetAllClienteDireccionesAsync();
        Task<ClienteDireccion> GetClienteDireccionByIdAsync(int id);
        Task<ClienteDireccion> CreateClienteDireccionAsync(ClienteDireccion clienteDireccion);
        Task<ClienteDireccion> UpdateClienteDireccionAsync(ClienteDireccion clienteDireccion);
        Task<bool> DeleteClienteDireccionAsync(int id);
    }
}
