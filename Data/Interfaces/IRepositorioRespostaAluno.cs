using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Models;

namespace DesafioDeProgramacaoAPI.Data.Interfaces
{
    public interface IRepositorioRespostaAluno
    {
        Task<RespostaAluno[]> ObterTodos();
        Task<RespostaAluno> ObterPeloId(int respostaAlunoId);
    }
}