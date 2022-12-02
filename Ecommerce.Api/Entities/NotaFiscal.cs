namespace Ecommerce.Api.Entities
{
    public class NotaFiscal
    {
        public int NotaFiscalId { get; set; }
        public Cliente? Clientes { get; set; }
        public int ClienteId { get; set; }
        public Funcionario? Funcionarios { get; set; }
        public int FuncionarioId { get; set; }
        public Carrinho? Carrinhos { get; set; }
        public int CarrinhoId { get; set; }
        public List<CarrinhoItem> Itens { get; set; }
        public int ItensId { get; set; }
    }
}
