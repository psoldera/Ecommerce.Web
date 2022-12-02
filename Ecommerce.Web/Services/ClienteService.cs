using Ecommerce.Models.DTOs;
using System.Net.Http.Json;

namespace Ecommerce.Web.Services
{
    public class ClienteService : IClienteService
    {
        public HttpClient _httpClient { get; set; }
        public ILogger<ProdutoService> _logger;

        public ClienteService(HttpClient httpClient, ILogger<ProdutoService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public Task<ClienteDto> GetCliente(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClienteDto>> GetClientes()
        {
            try
            {
                var clientesDto = await _httpClient.GetFromJsonAsync<IEnumerable<ClienteDto>>("api/clientes");
                return clientesDto;
            }
            catch (Exception)
            {
                _logger.LogError("Erro ao acessar clientes: api/clientes");
                throw;
            }
        }
    }
}
