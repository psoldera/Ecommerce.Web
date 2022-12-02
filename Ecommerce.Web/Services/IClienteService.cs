using Ecommerce.Models.DTOs;

namespace Ecommerce.Web.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDto>> GetClientes();
        Task<ClienteDto> GetCliente(int id);
    }
}
