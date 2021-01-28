using System.Collections.Generic;
namespace DesafioDeProgramacaoAPI.Models
{
    public class Prova
    {
        public int Id { get; set; }
        public int NumeroProva { get; set; }
        public IEnumerable<ProvaAluno> ProvaAlunos { get; set; }
        public IEnumerable<Gabarito> Gabaritos { get; set; }
        public IEnumerable<RespostaAluno> RespostaAlunos { get; set; }
        public Prova(int id, int NumeroProva)
        {
            this.Id = id;
            this.NumeroProva = NumeroProva;
        }
    }
}