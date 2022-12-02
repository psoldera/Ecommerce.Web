using Ecommerce.Models.DTOs;

namespace Ecommerce.Web.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDto>> GetItens();
        Task<ProdutoDto> GetItem(int id);
        Task<bool> Add(ProdutoAdicionarDto produtoAdicionarDto);
        public void Delete(int id);
    }
}
