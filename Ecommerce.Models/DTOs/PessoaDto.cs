using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.DTOs
{
    public class PessoaDto
    {
        public int PessoaId { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public int Status { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
