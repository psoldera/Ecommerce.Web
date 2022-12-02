using System.Collections.ObjectModel;

namespace Ecommerce.Api.Entities
{
    public class Carrinho
    {
        public int Id { get; set; }
        public string PessoaId { get; set; }
        public Collection<CarrinhoItem> Itens { get; set; } = new Collection<CarrinhoItem> ();
    }
}
