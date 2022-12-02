using Ecommerce.Models.DTOs;
using System.Net.Http;
using System.Net;
using System.Net.Http.Json;
using Ecommerce.Web.Shared;
using Ecommerce.Models.Login;

namespace Ecommerce.Web.Services
{
    public class PessoaService : IPessoaService
    {
        public HttpClient _httpClient { get; set; }
        public ILogger<ProdutoService> _logger;
        public LoginContainer _loginContainer { get; set; }

        public PessoaService(HttpClient httpClient, ILogger<ProdutoService> logger, LoginContainer loginContainer)
        {
            _httpClient = httpClient;
            _logger = logger;
            _loginContainer = loginContainer;
        }

        public async Task<IEnumerable<PessoaDto>> GetPessoas()
        {
            try
            {
                var pessoasDto = await _httpClient.GetFromJsonAsync<IEnumerable<PessoaDto>>("api/pessoa");
                return pessoasDto;
            }
            catch (Exception)
            {
                _logger.LogError("Erro ao acessar Pessoas: api/pessoa");
                throw;
            }
        }

        public async Task<bool> CheckLogin(string email, string password)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/pessoa/login", new LoginDto() { Email = email, Password = password });
                if (response.IsSuccessStatusCode)
                {
                    var loginresponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
                    _loginContainer.Logado = true;
                    _loginContainer.IsAdmin = loginresponse.IsAdmin;
                    _loginContainer.IdUser = loginresponse.Id;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                _logger.LogError("Erro ao acessar Pessoas: api/pessoa");
                throw;
            }
        }
    }
}
