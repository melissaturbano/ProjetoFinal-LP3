using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers;

public class ProfessorController : Controller 
{
     public readonly GerenciarEscolaContext _context;

     public ProfessorController (GerenciarEscolaContext context)
     {
        _context = context;
     }

     public IActionResult Index()
     {
        return View(_context.Professores);
     }

   //SHOW
     public IActionResult Show(int id)
     {
        Professor professor = _context.Professores.Find(id);

        if(professor == null)
        {
            return NotFound();
        }
        return View(professor);
     }

   //DELETE
     public IActionResult Delete(int id)
    {
        Professor professor = _context.Professores.Find(id);

        if(professor == null)
        {
            return NotFound();
        }
        _context.Professores.Remove(professor);
        _context.SaveChanges();
        return View(professor);
    }

    //UPDATE
    public IActionResult Update (int id)
    {
        Professor professor  = _context.Professores.Find(id);

        if(professor == null)
        {
            return NotFound();
        }
        return View(professor);
    }

    [HttpPost]
    public IActionResult Update
    (int id, [FromForm] string prontuario, [FromForm] string nome, [FromForm] string email, [FromForm] string disciplina)
    {
        Professor professor = _context.Professores.Find(id);

        if(professor == null)
        {
            return NotFound();
        }

        professor.Prontuario = prontuario;
        professor.Nome = nome;
        professor.Email = email;
        professor.Disciplina = disciplina;
        
        _context.Professores.Update(professor);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    //CREATE
    public IActionResult Create (Professor professor)
    {
        if(!ModelState.IsValid)
        {
           return View(professor);
        } 
        
        _context.Professores.Add(professor);
        _context.SaveChanges();   

        return RedirectToAction("Index");
    }
}