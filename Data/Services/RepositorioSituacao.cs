using System.Linq;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDeProgramacaoAPI.Data.Services
{
    public class RepositorioSituacao : IRepositorioSituacao
    {
        private readonly Contexto _contexto;
        public RepositorioSituacao(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public async Task<Situacao> ObterPeloId(int situacaoAlunoId)
        {
            IQueryable<Situacao> consulta = _contexto.Situacao;
            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Aprovado)
                               .Where(i => i.Id == situacaoAlunoId);
            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<Situacao[]> ObterTodos()
        {
            IQueryable<Situacao> consulta = _contexto.Situacao;
            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);
            return await consulta.ToArrayAsync();
        }
    }
}