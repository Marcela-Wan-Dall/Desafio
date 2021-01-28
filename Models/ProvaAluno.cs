namespace DesafioDeProgramacaoAPI.Models
{
    public class ProvaAluno
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int ProvaId { get; set; }
        public Prova Prova { get; set; }
        public double Nota  { get; set; }

        public ProvaAluno(int id, int alunoId, int provaId, double nota)
        {
            this.Id = id;
            this.AlunoId = alunoId;
            this.ProvaId = provaId;
            this.Nota = nota;
        }
    }
}