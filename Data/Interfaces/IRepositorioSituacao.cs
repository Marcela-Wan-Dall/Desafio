using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Models;

namespace DesafioDeProgramacaoAPI.Data.Interfaces
{
    public interface IRepositorioSituacao
    {
        Task<Situacao[]> ObterTodos();
        Task<Situacao> ObterPeloId(int situacaoId);
    }
}