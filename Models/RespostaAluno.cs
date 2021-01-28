namespace DesafioDeProgramacaoAPI.Models
{
    public class RespostaAluno
    {
        public int Id { get; set; }
        public int ProvaId { get; set; }
        public Prova Prova { get; set; }
        public int GabaritoId { get; set; }
        public Gabarito Gabarito { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public string Resposta  { get; set; }

         public RespostaAluno(int id, int provaId, int gabaritoId, int alunoId, string resposta)
        {
            this.Id = id;
            this.ProvaId = provaId;
            this.GabaritoId = gabaritoId;
            this.AlunoId = alunoId;
            this.Resposta = resposta;
        }
    }
}