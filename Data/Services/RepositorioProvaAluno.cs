using System.Linq;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDeProgramacaoAPI.Data.Services
{
    public class RepositorioProvaAluno : IRepositorioProvaAluno
    {
        private readonly Contexto _contexto;
        public RepositorioProvaAluno(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public async Task<ProvaAluno> ObterPeloId(int provaAlunoId)
        {
            IQueryable<ProvaAluno> consulta = _contexto.ProvaAluno;
            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Nota)
                               .Where(i => i.Id == provaAlunoId);
            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<ProvaAluno[]> ObterTodos()
        {
            IQueryable<ProvaAluno> consulta = _contexto.ProvaAluno;
            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);
            return await consulta.ToArrayAsync();
        }
    }
}