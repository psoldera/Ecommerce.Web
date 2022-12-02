using Ecommerce.Api.Entities;

namespace Ecommerce.Api.Repositories
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> GetPessoas();
        Task<Pessoa> CheckLogin(string email, string password);
    }
}
