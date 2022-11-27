using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers;

public class LivroController : Controller 
{
     public readonly GerenciarEscolaContext _context;

     public LivroController (GerenciarEscolaContext context)
     {
        _context = context;
     }

     public IActionResult Index()
     {
        return View(_context.Livros);
     }

   //SHOW
     public IActionResult Show(int id)
     {
        Livro livro = _context.Livros.Find(id);

        if(livro == null)
        {
            return NotFound();
        }
        return View(livro);
     }

   //DELETE
     public IActionResult Delete(int id)
    {
        Livro livro = _context.Livros.Find(id);

        if(livro == null)
        {
            return NotFound();
        }
        _context.Livros.Remove(livro);
        _context.SaveChanges();
        return View(livro);
    }

    //UPDATE
    public IActionResult Update (int id)
    {
        Livro livro  = _context.Livros.Find(id);

        if(livro == null)
        {
            return NotFound();
        }
        return View(livro);
    }

    [HttpPost]
    public IActionResult Update (int id, [FromForm] string autor, [FromForm] string titulo, [FromForm] string disciplina)
    {
        Livro livro = _context.Livros.Find(id);
        if(livro == null)
        {
            return NotFound();
        }

        livro.Autor = autor;
        livro.Titulo = titulo;
        livro.Disciplina = disciplina;

        _context.Livros.Update(livro);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    //CREATE
    public IActionResult Create (Livro livro)
    {
        if(!ModelState.IsValid)
        {
           return View(livro);
        } 
        
        _context.Livros.Add(livro);
        _context.SaveChanges();   

        return RedirectToAction("Index");
    }


}