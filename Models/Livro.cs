using System.ComponentModel.DataAnnotations;
namespace ProjetoFinal.Models;

    public class Livro
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Autor { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Disciplina { get; set; }

        public Livro() { }
        public Livro(int id, string autor, string titulo, string disciplina)
        {
            Id = id;
            Autor = autor;
            Titulo = titulo;
            Disciplina = disciplina;
        }
    }