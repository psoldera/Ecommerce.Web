using AutoMapper;
using Ecommerce.Api.Entities;
using Ecommerce.Api.Mapping;
using Ecommerce.Api.Repositories;
using Ecommerce.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItems()
        {
            try
            {
                var produtos = await _produtoRepository.GetItens();
                if (produtos is null)
                {
                    return NotFound();
                }
                else
                {
                    var produtoDtos = produtos.ConverterProdutosParaDto();
                    return Ok(produtoDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro ao acessar base de dados!");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetItem(int id)
        {
            try
            {
                var produtos = await _produtoRepository.GetItem(id);
                if (produtos is null)
                {
                    return NotFound("Produto não encontrado");
                }
                else
                {
                    var produtoDto = produtos.ConverterProdutoParaDto();
                    return Ok(produtoDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar base de dados!");
            }
        }
        [HttpGet]
        [Route("GetItensPorCategoria/{categoriaId}")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItensPorCategoria(int categoriaId)
        {
            try
            {
                var produtos = await _produtoRepository.GetItensPorCategoria(categoriaId);
                var produtosDto = produtos.ConverterProdutosParaDto();
                return Ok(produtosDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar base de dados!");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(ProdutoAdicionarDto produto)
        {
            if (produto == null) return BadRequest("Dados Inválidos");

            var produtoAdicionar = _mapper.Map<Produto>(produto);

            _produtoRepository.Add(produtoAdicionar);

            return produtoAdicionar.Id != null
                ? Ok("Produto adicionado!")
                : BadRequest("Erro ao salvar Produto");
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Dados Inválidos");

            _produtoRepository.Delete(id);

            return Ok("Produto Removido!");
        }
    }
}
