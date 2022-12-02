using Ecommerce.Api.Entities;
using Ecommerce.Api.Mapping;
using Ecommerce.Api.Repositories;
using Ecommerce.Models.DTOs;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models.Login;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepo;
        public PessoaController(IPessoaRepository pessoaRepo)
        {
            _pessoaRepo = pessoaRepo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaDto>>> GetPessoas()
        {
            try
            {
                var pessoas = await _pessoaRepo.GetPessoas();
                if (pessoas is null)
                {
                    return NotFound();
                }
                else
                {
                    var pessoaDtos = pessoas.ConverterPessoasParaDto;
                    return Ok(pessoaDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login(LoginDto login)
        {
            var pessoas = await _pessoaRepo.CheckLogin(login.Email, login.Password);

            if (pessoas != null)
            {
                return Ok(new LoginResponse() { IsAdmin = pessoas.Status == 2?true:false});
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
