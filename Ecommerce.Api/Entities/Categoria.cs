using System.Collections.ObjectModel;

namespace Ecommerce.Api.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string IconCSS { get; set; } = string.Empty;
        public Collection<Produto> Produtos = new Collection<Produto>();
    }
}
