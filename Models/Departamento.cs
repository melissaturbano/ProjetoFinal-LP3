using System.ComponentModel.DataAnnotations;
namespace ProjetoFinal.Models;

    public class Departamento
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sigla { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Bloco { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public Departamento() { }
        public Departamento(int id, string nome, string sigla, string descricao, string bloco, string telefone, string email) 
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
            Descricao = descricao;
            Bloco = bloco;
            Telefone = telefone;
            Email = email;
        }
    }