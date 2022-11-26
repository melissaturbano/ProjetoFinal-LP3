using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.Models;

public class  GerenciarEscolaContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    
    public GerenciarEscolaContext (DbContextOptions<GerenciarEscolaContext> options ) : base (options)
    {

    }
}