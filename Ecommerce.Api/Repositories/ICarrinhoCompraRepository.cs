using Ecommerce.Api.Entities;
using Ecommerce.Models.DTOs;

namespace Ecommerce.Api.Repositories
{
    public interface ICarrinhoCompraRepository
    {
        Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto);
        Task<CarrinhoItem> AtualizaQuantidade(int id, CarrinhoItemAtualizaQuantidadeDto CarrinhoItemAtualizaQuantidadeDto);
        Task<CarrinhoItem> DeletaItem(int id);
        Task<CarrinhoItem> GetItem(int id);
        Task<IEnumerable<CarrinhoItem>> GetItens(string usuarioId);
    }
}
