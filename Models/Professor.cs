using System.ComponentModel.DataAnnotations;
namespace ProjetoFinal.Models;

public class Professor
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Prontuario { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Disciplina { get; set; }

    public Professor() { }

    public Professor(int id, string prontuario, string nome, string email, string disciplina)
    {
        Id = id;
        Prontuario = prontuario;
        Nome = nome;
        Email = email;
        Disciplina = disciplina;
    }
}
