using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDeProgramacaoAPI.Data.Services
{
    public class RepositorioAluno : IRepositorioAluno
    {
        private readonly Contexto _contexto;
        public RepositorioAluno(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public async Task<Aluno> ObterPeloId(int alunoId)
        {
            IQueryable<Aluno> consulta = _contexto.Aluno;
            consulta = consulta.AsNoTracking()
                               .OrderBy(i => i.Nome)
                               .Where(i => i.Id == alunoId);
            return await consulta.FirstOrDefaultAsync();
        }
        public async Task<Aluno[]> ObterTodos()
        {
            IQueryable<Aluno> consulta = _contexto.Aluno;
            consulta = consulta.AsNoTracking().OrderBy(i => i.Id);
            return await consulta.ToArrayAsync();
        }
        public static void ContarAlunos(int[] alunos)
        {
            List<Aluno> aluno = new List<Aluno>();
        }
    }
}