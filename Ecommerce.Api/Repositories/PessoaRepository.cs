using Ecommerce.Api.Context;
using Ecommerce.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;

        public PessoaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Pessoa> CheckLogin(string email, string password)
        {
            var usuario = await _context.Pessoas.Where(x => x.Email == email && x.Password == password).SingleOrDefaultAsync();
            return usuario;
        }

        public async Task<IEnumerable<Pessoa>> GetPessoas()
        {
            var pessoas = await _context.Pessoas.ToListAsync();

            return pessoas;
        }

    }
}
