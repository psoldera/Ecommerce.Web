using Ecommerce.Api.Entities;

namespace Ecommerce.Api.Repositories
{
    public interface IProdutoRepository
    {
        public void Add(Produto entity);
        public void Delete(int id);
        Task<bool> SaveChangesAsync();
        Task<Produto> GetItem(int id);
        Task<IEnumerable<Produto>> GetItens();
        Task<IEnumerable<Produto>> GetItensPorCategoria(int id);
        Task<IEnumerable<Categoria>> GetCategorias();
    }
}
