using Microsoft.EntityFrameworkCore;
namespace ProjetoFinal.Models;

public class  GerenciarEscolaContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Sala> Salas { get; set; }
    public DbSet<Livro> Livros { get; set; }
    
    public GerenciarEscolaContext (DbContextOptions<GerenciarEscolaContext> options ) : base (options)
    {

    }
}