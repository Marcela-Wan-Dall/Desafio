using System.Linq;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDeProgramacaoAPI.Data.Services
{
    public class RepositorioProva : IRepositorioProva
    {
        private readonly Contexto _contexto;
        public RepositorioProva(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public async Task<Prova> ObterPeloId(int provaId)
        {
            IQueryable<Prova> consulta = _contexto.Prova;
            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.NumeroProva)
                               .Where(i => i.Id == provaId);
            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<Prova[]> ObterTodos()
        {
            IQueryable<Prova> consulta = _contexto.Prova;
            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);
            return await consulta.ToArrayAsync();
        }
    }
}