using System;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDeProgramacaoAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RespostaAlunoController : ControllerBase
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioRespostaAluno _reporitorioRespostaAluno;
        public RespostaAlunoController(IRepositorio repositorio, IRepositorioRespostaAluno repositorioRespostaAluno)
        {
            this._repositorio = repositorio;
            this._reporitorioRespostaAluno = repositorioRespostaAluno;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var prova = await _reporitorioRespostaAluno.ObterTodos();
                return Ok(prova);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao consultar a RespostaAluno, ocorreu o erro {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(RespostaAluno respostaAluno)
        {
            try
            {
                _repositorio.Adicionar(respostaAluno);
                if (await _repositorio.EfetuouAlteracoesAssincronas())
                {
                    return Ok(respostaAluno);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao consultar a RespostaAluno pelo Id, ocorreu o erro {ex.Message}");
            }
            return BadRequest();
        }
        [HttpDelete("id={respostaAlunoId}")]
        public async Task<IActionResult> Delete(int respostaAlunoId)
        {
            try
            {
                var respostaAlunoCadastrada = await _reporitorioRespostaAluno.ObterPeloId(respostaAlunoId);
                if (respostaAlunoCadastrada == null)
                {
                    return NotFound();
                }
                _repositorio.Deletar(respostaAlunoCadastrada);
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
                return BadRequest($"Ao tentar remover a RespostaAluno, ocorreu o erro: {ex.Message}");
            }
            return BadRequest();
        }
    }
}