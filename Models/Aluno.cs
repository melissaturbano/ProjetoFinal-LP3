using System.ComponentModel.DataAnnotations;
namespace ProjetoFinal.Models;

    public class Aluno
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Turma { get; set; }

        [Required]
        public string Curso { get; set; }

        public Aluno() { }
        public Aluno(int id, string turma, string curso)
        {
            Id = id;
            Turma = turma;
            Curso = curso;
        }
    }
