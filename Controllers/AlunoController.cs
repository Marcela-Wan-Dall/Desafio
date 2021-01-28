using System;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDeProgramacaoAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepositorio _repositorio;
        private readonly IRepositorioAluno _reporitorioAluno;
        public AlunoController(IRepositorio repositorio, IRepositorioAluno repositorioAluno)
        {
            this._repositorio = repositorio;
            this._reporitorioAluno = repositorioAluno;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var aluno = await _reporitorioAluno.ObterTodos();
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao consultar o Aluno, ocorreu o erro {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(Aluno aluno)
        {
            try
            {
                _repositorio.Adicionar(aluno);
                if (await _repositorio.EfetuouAlteracoesAssincronas())
                {
                    return Ok(aluno);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Ao consultar o Aluno pelo Id, ocorreu o erro {ex.Message}");
            }
            return BadRequest();
        }
        [HttpDelete("id={alunoId}")]
        public async Task<IActionResult> Delete(int alunoId)
        {
            try
            {
                var alunoCadastrado = await _reporitorioAluno.ObterPeloId(alunoId);
                if (alunoCadastrado == null)
                {
                    return NotFound();
                }
                _repositorio.Deletar(alunoCadastrado);
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
                return BadRequest($"Ao tentar remover o Aluno, ocorreu o erro: {ex.Message}");
            }
            return BadRequest();
        }
    }
}