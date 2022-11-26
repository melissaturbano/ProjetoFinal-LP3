using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers;

public class AlunoController : Controller 
{
     public readonly GerenciarEscolaContext _context;

     public AlunoController (GerenciarEscolaContext context)
     {
        _context = context;
     }

     public IActionResult Index()
     {
        return View(_context.Alunos);
     }

   //SHOW
     public IActionResult Show(int id)
     {
        Aluno aluno = _context.Alunos.Find(id);

        if(aluno == null)
        {
            return NotFound();
        }
        return View(aluno);
     }

   //DELETE
     public IActionResult Delete(int id)
    {
        Aluno aluno = _context.Alunos.Find(id);

        if(aluno == null)
        {
            return NotFound();
        }
        _context.Alunos.Remove(aluno);
        _context.SaveChanges();
        return View(aluno);
    }

    /*UPDATE*/
    public IActionResult Update (int id)
    {
        Aluno aluno  = _context.Alunos.Find(id);

        if(aluno == null)
        {
            return NotFound();
        }
        return View(aluno);
    }

    [HttpPost]
    public IActionResult Update
    (int id, [FromForm] string prontuario, [FromForm] string nome, [FromForm] string turma, [FromForm] string curso, [FromForm] string periodo)
    {
        Aluno aluno = _context.Alunos.Find(id);
        if(aluno == null)
        {
            return NotFound();
        }
        aluno.Prontuario = prontuario;
        aluno.Nome = nome;
        aluno.Turma = turma;
        aluno.Curso = curso;
        aluno.Periodo = periodo;
        
        _context.Alunos.Update(aluno);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

  
}