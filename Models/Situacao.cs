namespace DesafioDeProgramacaoAPI.Models
{
    public class Situacao
    {
        public int Id { get; set; }
        public double Media { get; set; }
        public string Aprovado { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public Situacao(int id, int alunoId, double media, string aprovado)
        {
            this.Id = id;
            this.AlunoId = alunoId;
            this.Media = media;
            this.Aprovado = aprovado;
            
        }
    }
}