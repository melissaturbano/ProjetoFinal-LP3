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

    //UPDATE
    public IActionResult Update (int id)
    {
        Departamento departamento  = _context.Departamentos.Find(id);

        if(departamento == null)
        {
            return NotFound();
        }
        return View(departamento);
    }

    [HttpPost]
    public IActionResult Update
    (int id, [FromForm] string nome, [FromForm] string sigla, [FromForm] string descricao, [FromForm] string bloco, [FromForm] string telefone, [FromForm] string email)
    {
        Departamento departamento = _context.Departamentos.Find(id);
        if(departamento == null)
        {
            return NotFound();
        }

        departamento.Nome = nome;
        departamento.Sigla = sigla;
        departamento.Descricao = descricao;
        departamento.Bloco = bloco;
        departamento.Telefone = telefone;
        departamento.Email = email;
        
        _context.Departamentos.Update(departamento);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

  
}