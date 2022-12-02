using Ecommerce.Api.Context;
using Ecommerce.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Ecommerce.Api.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<Produto> GetItem(int id)
        {
            var produto = await _context.Produtos
                            .Include(c => c.Categoria)
                            .SingleOrDefaultAsync(c => c.Id == id);
            return produto;
        }

        public async Task<IEnumerable<Produto>> GetItens()
        {
            var produtos = await _context.Produtos
                            .Include(p => p.Categoria)
                            .ToListAsync();
            return produtos;
        }

        public async Task<IEnumerable<Produto>> GetItensPorCategoria(int id)
        {
            var produtos = await _context.Produtos
                            .Include(p => p.Categoria)
                            .Where(p => p.CategoriaId == id).ToListAsync();
            return produtos;
        }
        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return categorias;
        }

        public void Add (Produto entity)
        {
            _context.Produtos.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Produtos.Find(id);
            _context.Produtos.Remove(entity);
            _context.SaveChanges();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
