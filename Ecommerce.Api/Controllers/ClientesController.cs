using Ecommerce.Api.Mapping;
using Ecommerce.Api.Repositories;
using Ecommerce.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteRepo _clienteRepo;

        public ClientesController(IClienteRepo clienteRepo)
        {
            _clienteRepo = clienteRepo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetClientes()
        {
            try
            {
                var clientes = await _clienteRepo.GetClientes();
                if (clientes is null)
                {
                    return NotFound();
                }
                else
                {
                    var clienteDtos = clientes.ConverterClientesParaDto();
                    return Ok(clienteDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetCliente(int id)
        {
            try
            {
                var cliente = await _clienteRepo.GetCliente(id);
                if (cliente is null)
                {
                    return NotFound();
                }
                else
                {
                    var clienteDto = cliente.ConverterClienteParaDto();
                    return Ok(clienteDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
    }
}
