using System.ComponentModel.DataAnnotations;
namespace ProjetoFinal.Models;

    public class Sala
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Bloco { get; set; }

        public Sala() { }
        public Sala(int id, int numero, string bloco)
        {
            Id = id;
            Numero = numero;
            Bloco = bloco;
        }
    }
