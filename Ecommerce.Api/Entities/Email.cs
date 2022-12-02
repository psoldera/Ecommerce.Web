namespace Ecommerce.Api.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public string? EnderecoEmail { get; set; }
        public int PessoaId { get; set; }   
    }
}
