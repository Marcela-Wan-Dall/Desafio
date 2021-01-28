using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Models;

namespace DesafioDeProgramacaoAPI.Data.Interfaces
{
    public interface IRepositorioAluno
    {
        Task<Aluno[]> ObterTodos();
        Task<Aluno> ObterPeloId(int alunoId);
    }
}