using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Models;

namespace DesafioDeProgramacaoAPI.Data.Interfaces
{
    public interface IRepositorioProvaAluno
    {
        Task<ProvaAluno[]> ObterTodos();
        Task<ProvaAluno> ObterPeloId(int provaAlunoId);
    }
}