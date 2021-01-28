using System.Linq;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Models;

namespace DesafioDeProgramacaoAPI.Data.Interfaces
{
    public interface IRepositorioGabarito
    {
        Task<Gabarito[]> ObterTodos();
        Task<Gabarito> ObterPeloId(int gabaritoId);
    }
}