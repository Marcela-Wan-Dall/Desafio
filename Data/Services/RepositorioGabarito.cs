using System.Linq;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using DesafioDeProgramacaoAPI.Models;

namespace DesafioDeProgramacaoAPI.Data.Services
{
    public class RepositorioGabarito : IRepositorioGabarito
    {
        private readonly Contexto _contexto;
        public RepositorioGabarito(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public async Task<Gabarito> ObterPeloId(int gabaritoId)
        {
            IQueryable<Gabarito> consulta = _contexto.Gabarito;
            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Questao)
                               .Where(i => i.Id == gabaritoId);
            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<Gabarito[]> ObterTodos()
        {
            IQueryable<Gabarito> consulta = _contexto.Gabarito;
            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);
            return await consulta.ToArrayAsync();
        }
    }
}