using Ecommerce.Models.DTOs;

namespace Ecommerce.Web.Services
{
    public interface IPessoaService
    {
        Task<IEnumerable<PessoaDto>> GetPessoas();
        Task<bool> CheckLogin(string email, string password);
    }
}
