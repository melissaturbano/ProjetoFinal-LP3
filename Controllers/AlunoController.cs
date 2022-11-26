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

     public IActionResult Show(int id)
     {
        Aluno aluno = _context.Alunos.Find(id);

        if(aluno == null)
        {
            return NotFound();
        }
        return View(aluno);
     }

  
}