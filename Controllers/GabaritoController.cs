using System;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDeProgramacaoAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GabaritoController : ControllerBase
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioGabarito _reporitorioGabarito;
        public GabaritoController(IRepositorio repositorio, IRepositorioGabarito repositorioGabarito)
        {
            this._repositorio = repositorio;
            this._reporitorioGabarito = repositorioGabarito;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var gabarito = await _reporitorioGabarito.ObterTodos();
                return Ok(gabarito);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao consultar o Gabarito, ocorreu o erro {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(Gabarito gabarito)
        {
            try
            {
                _repositorio.Adicionar(gabarito);
                if (await _repositorio.EfetuouAlteracoesAssincronas())
                {
                    return Ok(gabarito);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao consultar o Gabarito pelo Id, ocorreu o erro {ex.Message}");
            }
            return BadRequest();
        }
        [HttpDelete("id={grabaritoId}")]
        public async Task<IActionResult> Delete(int gabaritoId)
        {
            try
            {
                var gabaritoCadastrado = await _reporitorioGabarito.ObterPeloId(gabaritoId);
                if (gabaritoCadastrado == null)
                {
                    return NotFound();
                }
                _repositorio.Deletar(gabaritoCadastrado);
                if (await _repositorio.EfetuouAlteracoesAssincronas())
                {
                    return Ok(
                        new
                        {
                            message = "Removido!"
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao tentar remover o Gabarito, ocorreu o erro: {ex.Message}");
            }
            return BadRequest();
        }
    }
}