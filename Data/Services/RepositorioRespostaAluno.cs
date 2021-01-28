using System.Linq;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDeProgramacaoAPI.Data.Services
{
    public class RepositorioRespostaAluno : IRepositorioRespostaAluno
    {
        private readonly Contexto _contexto;
        public RepositorioRespostaAluno(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public async Task<RespostaAluno> ObterPeloId(int respostaAlunoId)
        {
            IQueryable<RespostaAluno> consulta = _contexto.RespostaAluno;
            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Resposta)
                               .Where(i => i.Id == respostaAlunoId);
            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<RespostaAluno[]> ObterTodos()
        {
            IQueryable<RespostaAluno> consulta = _contexto.RespostaAluno;
            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);
            return await consulta.ToArrayAsync();
        }
    }
}