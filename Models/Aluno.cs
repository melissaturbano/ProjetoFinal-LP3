using System.ComponentModel.DataAnnotations;
namespace ProjetoFinal.Models;

    public class Aluno
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Prontuario { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Turma { get; set; }

        [Required]
        public string Curso { get; set; }

        [Required]
        public string Periodo { get; set; }

        public Aluno() { }
        public Aluno(int id, string prontuario, string nome, string turma, string curso, string periodo)
        {
            Id = id;
            Prontuario = prontuario;
            Nome = nome;
            Turma = turma;
            Curso = curso;
            Periodo = periodo;
        }
    }
