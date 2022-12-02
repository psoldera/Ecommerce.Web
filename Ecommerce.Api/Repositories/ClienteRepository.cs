using Ecommerce.Api.Context;
using Ecommerce.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Repositories
{
    public class ClienteRepository : IClienteRepo
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> GetCliente(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.PessoaId == id);

            return cliente;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            var clientes = await _context.Clientes.ToListAsync();

            return clientes;
        }
    }
}
