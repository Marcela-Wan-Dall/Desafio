using System.Collections.Generic;

namespace DesafioDeProgramacaoAPI.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public IEnumerable<ProvaAluno> ProvaAlunos { get; set; }
        public IEnumerable<RespostaAluno> RespostaAlunos { get; set; }
        public IEnumerable<Situacao> Situacaos { get; set; }

        public Aluno(int id, string nome, string sobreNome)
        {
            this.Id = id;
            this.Nome = nome;
            this.SobreNome = sobreNome;
        }
    }
}