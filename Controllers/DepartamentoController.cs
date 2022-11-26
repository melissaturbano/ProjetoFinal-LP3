using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers;

public class DepartamentoController : Controller 
{
     public readonly GerenciarEscolaContext _context;

     public DepartamentoController (GerenciarEscolaContext context)
     {
        _context = context;
     }

     public IActionResult Index()
     {
        return View(_context.Departamentos);
     }

   //SHOW
     public IActionResult Show(int id)
     {
        Departamento departamento = _context.Departamentos.Find(id);

        if(departamento == null)
        {
            return NotFound();
        }
        return View(departamento);
     }

     //DELETE
     public IActionResult Delete(int id)
    {
        Departamento departamento = _context.Departamentos.Find(id);

        if(departamento == null)
        {
            return NotFound();
        }
        _context.Departamentos.Remove(departamento);
        _context.SaveChanges();
        return View(departamento);
    }

  
}