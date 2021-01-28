using System.Collections.Generic;
using DesafioDeProgramacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDeProgramacaoAPI.Data
{
    public class Contexto : DbContext

    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) {}
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Prova> Prova { get; set; }
        public DbSet<ProvaAluno> ProvaAluno { get; set; }
        public DbSet<Gabarito> Gabarito { get; set; }
        public DbSet<RespostaAluno> RespostaAluno { get; set; }
        public DbSet<Situacao> Situacao { get; set; }
        
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Aluno>()
                .HasData(
                    new List<Aluno>()
                    {
                        new Aluno(1, "Pedro", "Santos"),
                        new Aluno(2, "Anna", "Mueller"),
                    }
                );
            builder.Entity<Prova>()
                .HasData(
                    new List<Prova>()
                    {
                        new Prova(1, 1),
                        new Prova(2, 2),
                        new Prova(3, 3),
                    }
                );    
            builder.Entity<ProvaAluno>()
                .HasData(
                    new List<ProvaAluno>()
                    {
                        new ProvaAluno(1, 1, 1, 6),
                        new ProvaAluno(2, 1, 2, 10),
                        new ProvaAluno(3, 1, 3, 8),
                        new ProvaAluno(4, 2, 1, 5),
                        new ProvaAluno(5, 2, 2, 7),
                        new ProvaAluno(6, 2, 3, 9),
                        
                    }
                );
            builder.Entity<Gabarito>()
                .HasData(
                    new List<Gabarito>()
                    {
                        new Gabarito(1, 1, 6, "b", 1),
                        new Gabarito(2, 2, 4, "a", 1),
                        new Gabarito(3, 1, 5, "a", 2),
                        new Gabarito(4, 2, 5, "a", 2),
                        new Gabarito(5, 1, 7, "b", 3),
                        new Gabarito(6, 2, 3, "a", 3),
                    }
                );
                builder.Entity<RespostaAluno>()
                .HasData(
                    new List<RespostaAluno>()
                    {
                        new RespostaAluno(1, 1, 1, 1, "b"),
                        new RespostaAluno(2, 1, 2, 1, "b"),
                        new RespostaAluno(3, 2, 1, 1, "a"),
                        new RespostaAluno(4, 2, 2, 1, "a"),
                        new RespostaAluno(5, 3, 1, 1, "b"),
                        new RespostaAluno(6, 3, 2, 1, "b"),
                        new RespostaAluno(7, 1, 1, 2, "b"),
                        new RespostaAluno(8, 1, 2, 2, "a"),
                        new RespostaAluno(9, 2, 1, 2, "b"),
                        new RespostaAluno(10, 2, 2, 2, "a"),
                        new RespostaAluno(11, 3, 1, 2, "a"),
                        new RespostaAluno(12, 3, 2, 2, "b"),
                    }
                );
                builder.Entity<Situacao>()
                .HasData(
                    new List<Situacao>()
                    {
                        new Situacao(1, 1, 8, "s"),
                        new Situacao(2, 2, 7, "n"),
                    }
                );
           
            
        }

    }
}