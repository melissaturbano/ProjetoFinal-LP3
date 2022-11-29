using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers;

public class CursoController : Controller 
{
     public readonly GerenciarEscolaContext _context;

     public CursoController (GerenciarEscolaContext context)
     {
        _context = context;
     }

     public IActionResult Index()
     {
        return View(_context.Cursos);
     }

   //SHOW
     public IActionResult Show(int id)
     {
        Curso curso = _context.Cursos.Find(id);

        if(curso == null)
        {
            return NotFound();
        }
        return View(curso);
     }

   //DELETE
     public IActionResult Delete(int id)
    {
       Curso curso = _context.Cursos.Find(id);

        if(curso == null)
        {
            return NotFound();
        }
        _context.Cursos.Remove(curso);
        _context.SaveChanges();
        return View(curso);
    }

    //UPDATE
    public IActionResult Update (int id)
    {
         Curso curso = _context.Cursos.Find(id);

        if(curso == null)
        {
            return NotFound();
        }
        return View(curso);
    }

    [HttpPost]
    public IActionResult Update
    (int id, [FromForm] string nome, [FromForm] string formacao, [FromForm] string duracao)
    {
         Curso curso = _context.Cursos.Find(id);

        if(curso == null)
        {
            return NotFound();
        }
        curso.Nome = nome;
        curso.Formacao = formacao;
        curso.Duracao = duracao;
        
        _context.Cursos.Update(curso);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    //CREATE
    public IActionResult Create (Curso curso)
    {
        if(!ModelState.IsValid)
        {
           return View(curso);
        } 
        
        _context.Cursos.Add(curso);
        _context.SaveChanges();   

        return RedirectToAction("Index");
    } 
}