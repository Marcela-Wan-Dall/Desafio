using System.Threading.Tasks;

namespace DesafioDeProgramacaoAPI.Data.Interfaces
{
    public interface IRepositorio
    {
        void Adicionar<A>(A entidade) where A : class;
        void Atualizar<A>(A entidade) where A : class;
        void Deletar<A>(A entidade) where A : class;

        Task<bool> EfetuouAlteracoesAssincronas();
    }
}