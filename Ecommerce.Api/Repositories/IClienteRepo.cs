using Ecommerce.Api.Entities;

namespace Ecommerce.Api.Repositories
{
    public interface IClienteRepo
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetCliente(int id);
    }
}
