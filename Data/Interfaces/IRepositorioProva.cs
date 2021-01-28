using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Models;

namespace DesafioDeProgramacaoAPI.Data.Interfaces
{
    public interface IRepositorioProva
    {
        Task<Prova[]> ObterTodos();
        Task<Prova> ObterPeloId(int provaId);
    }
}