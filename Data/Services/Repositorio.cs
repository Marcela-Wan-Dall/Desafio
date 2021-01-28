using System.Threading.Tasks;
using DesafioDeProgramacaoAPI.Data.Interfaces;

namespace DesafioDeProgramacaoAPI.Data.services
{
    public class Repositorio : IRepositorio
    {
        private readonly Contexto _contexto;
        public Repositorio(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public void Adicionar<A>(A entidade) where A : class
        {
            _contexto.Add(entidade);
        }
        public void Atualizar<A>(A entidade) where A : class
        {
            _contexto.Update(entidade);
        }
        public void Deletar<A>(A entidade) where A : class
        {
            _contexto.Remove(entidade);
        }
        public async Task<bool> EfetuouAlteracoesAssincronas()
        {
            return (await _contexto.SaveChangesAsync()) > 0;
        }
    }
}