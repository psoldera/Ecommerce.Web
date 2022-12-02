namespace Ecommerce.Api.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public int Status { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Telefone>? Telefones { get; set; }
        public List<Email>? Emails { get; set; }
    }

}