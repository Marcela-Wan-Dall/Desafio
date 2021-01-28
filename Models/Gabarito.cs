using System.Collections.Generic;

namespace DesafioDeProgramacaoAPI.Models
{
    public class Gabarito
    {
        public int Id { get; set; }
        public int Questao { get; set; }
        public int PesoQuestao { get; set; }
        public string OpcaoCorreta { get; set; }
        public int ProvaId { get; set; }
        public Prova Prova { get; set; }
        public IEnumerable<RespostaAluno> RespostaAlunos { get; set; }
        
        public Gabarito(int id, int questao, int pesoQuestao, string opcaoCorreta, int provaId)
        {
            this.Id = id;
            this.Questao = questao;
            this.PesoQuestao = pesoQuestao;
            this.OpcaoCorreta = opcaoCorreta;
            this.ProvaId = provaId;
        }
    }
}