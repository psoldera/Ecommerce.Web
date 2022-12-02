using Ecommerce.Api.Entities;
using Ecommerce.Models.DTOs;
using System.Security.Cryptography.X509Certificates;

namespace Ecommerce.Api.Mapping

{
    public static class MappingDtos
    {
        public static IEnumerable<CategoriaDto> ConverterCategoriasParaDto(
            this IEnumerable<Categoria> categorias)
        {
            return (from categoria in categorias
                    select new CategoriaDto
                    {
                        Id = categoria.Id,
                        Nome = categoria.Nome,
                        IconCSS = categoria.IconCSS
                    }).ToList();
        }
        public static IEnumerable<ProdutoDto> ConverterProdutosParaDto(
            this IEnumerable<Produto> produtos)
        {
            return (from produto in produtos
                    select new ProdutoDto
                    {
                        Id = produto.Id,
                        Nome = produto.Nome,
                        Descricao = produto.Descricao,
                        ImagemUrl = produto.ImagemUrl,
                        Preco = produto.Preco,
                        Quantidade = produto.Quantidade,
                        CategoriaId = produto.CategoriaId,
                        CategoriaNome = produto.Categoria.Nome,
                    }).ToList();
        }
        public static ProdutoDto ConverterProdutoParaDto(this Produto produto)
        {
            return new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                ImagemUrl = produto.ImagemUrl,
                Preco = produto.Preco,
                Quantidade = produto.Quantidade,
                CategoriaId = produto.CategoriaId,
                CategoriaNome = produto.Categoria.Nome
            };
        }
        public static IEnumerable<CarrinhoItemDto> ConverterCarrinhoItensParaDto(
            this IEnumerable<CarrinhoItem> carrinhoItens, IEnumerable<Produto> produtos)
        {
            return (from carrinhoItem in carrinhoItens
                    join produto in produtos
                    on carrinhoItem.ProdutoId equals produto.Id
                    select new CarrinhoItemDto
                    {
                        Id = carrinhoItem.Id,
                        ProdutoId = carrinhoItem.ProdutoId,
                        ProdutoNome = produto.Nome,
                        ProdutoDescricao = produto.Descricao,
                        ProdutoImagemURL = produto.ImagemUrl,
                        Preco = produto.Preco,
                        CarrinhoID = carrinhoItem.CarrinhoId,
                        Quantidade = carrinhoItem.Quantidade,
                        PrecoTotal = produto.Preco * carrinhoItem.Quantidade
                    }).ToList();
        }
        public static CarrinhoItemDto ConverterCarrinhoItemParaDto(this CarrinhoItem carrinhoItem,
            Produto produto)
        {
            return new CarrinhoItemDto
            {
                Id = carrinhoItem.Id,
                ProdutoId = carrinhoItem.ProdutoId,
                ProdutoNome = produto.Nome,
                ProdutoDescricao = produto.Descricao,
                ProdutoImagemURL = produto.ImagemUrl,
                Preco = produto.Preco,
                CarrinhoID = carrinhoItem.CarrinhoId,
                Quantidade = carrinhoItem.Quantidade,
                PrecoTotal = produto.Preco * carrinhoItem.Quantidade
            };
        }
        public static IEnumerable<ClienteDto> ConverterClientesParaDto(
                this IEnumerable<Cliente> clientes)
        {
            return (from cliente in clientes
                    select new ClienteDto
                    {
                        PessoaId = cliente.PessoaId,
                        Nome = cliente.Nome,
                        CPF = cliente.CPF,
                        Status = cliente.Status,
                        Credito = cliente.Credito,
                        Password = cliente.Password,
                        Email = cliente.Email
                    }).ToList();
        }
        public static ClienteDto ConverterClienteParaDto(this Cliente cliente)
        {
            return new ClienteDto
            {
                PessoaId = cliente.PessoaId,
                Nome = cliente.Nome,
                CPF = cliente.CPF,
                Status = cliente.Status,
                Credito = cliente.Credito,
                Password = cliente.Password,
                Email = cliente.Email
            };
        }
        public static IEnumerable<PessoaDto> ConverterPessoasParaDto(
                this IEnumerable<Pessoa> pessoas)
        {
            return (from pessoa in pessoas
                    select new PessoaDto
                    {
                        PessoaId = pessoa.PessoaId,
                        Nome = pessoa.Nome,
                        CPF = pessoa.CPF,
                        Status = pessoa.Status,
                        Password = pessoa.Password,
                        Email = pessoa.Email
                    }).ToList();
        }
    }
}
