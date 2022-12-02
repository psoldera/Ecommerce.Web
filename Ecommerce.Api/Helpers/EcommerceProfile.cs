using AutoMapper;
using Ecommerce.Api.Entities;
using Ecommerce.Models.DTOs;

namespace Ecommerce.Api.Helpers
{
    public class EcommerceProfile : Profile
    {
        public EcommerceProfile()
        {
            CreateMap<ProdutoAdicionarDto, Produto>();
        }
    }
}
