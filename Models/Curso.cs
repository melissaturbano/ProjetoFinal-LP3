using System.ComponentModel.DataAnnotations;
namespace ProjetoFinal.Models;

    public class Curso
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Formacao { get; set; }

        [Required]
        public string Duracao{ get; set; }

        public Curso() { }
        public Curso(int id, string nome, string formacao, string duracao)
        {
            Id = id;
            Nome = nome;
            Formacao = formacao;
            Duracao = duracao;
        }
    }
