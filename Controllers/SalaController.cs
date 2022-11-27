using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers;

public class SalaController : Controller 
{
     public readonly GerenciarEscolaContext _context;

     public SalaController (GerenciarEscolaContext context)
     {
        _context = context;
     }

     public IActionResult Index()
     {
        return View(_context.Salas);
     }

   //SHOW
     public IActionResult Show(int id)
     {
        Sala sala = _context.Salas.Find(id);

        if(sala == null)
        {
            return NotFound();
        }
        return View(sala);
     }

   //DELETE
     public IActionResult Delete(int id)
    {
        Sala sala = _context.Salas.Find(id);

        if(sala == null)
        {
            return NotFound();
        }
        _context.Salas.Remove(sala);
        _context.SaveChanges();
        return View(sala);
    }

    //UPDATE
    public IActionResult Update (int id)
    {
        Sala sala  = _context.Salas.Find(id);

        if(sala == null)
        {
            return NotFound();
        }
        return View(sala);
    }

    [HttpPost]
    public IActionResult Update (int id, [FromForm] int numero, [FromForm] string bloco )
    {
        Sala sala = _context.Salas.Find(id);
        if(sala == null)
        {
            return NotFound();
        }

        sala.Numero = numero;
        sala.Bloco = bloco;

        _context.Salas.Update(sala);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    //CREATE
    public IActionResult Create (Sala sala)
    {
        if(!ModelState.IsValid)
        {
           return View(sala);
        } 
        
        _context.Salas.Add(sala);
        _context.SaveChanges();   

        return RedirectToAction("Index");
    }


}