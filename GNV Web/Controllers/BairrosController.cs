using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GNV_Web.Data;
using GNV_Web.Models;

namespace GNV_Web.Controllers
{
    public class BairrosController : Controller
    {
        private readonly GNV_WebContext _context;
        List<Cidade> cidades = new List<Cidade>();


        public BairrosController(GNV_WebContext context)
        {
            _context = context;
        }

        //public SelectList CidadeSelecionada { get; set; }

        
    
    // GET: Bairros
    public IActionResult Index()
    {
            return View( _context.Bairro.ToList());
        }

    // GET: Bairros/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bairro = await _context.Bairro
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bairro == null)
        {
            return NotFound();
        }

        return View(bairro);
    }

    // GET: Bairros/Create
    public IActionResult Create()
    {
            var cidades = (from Cidade in _context.Cidade select Cidade);
            ViewBag.Cidades = cidades;
            return View();
    }

    // POST: Bairros/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id_Cidade,Nome")] Bairro bairro)
    {
        if (ModelState.IsValid)
        {
            _context.Bairro.Add(bairro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(bairro);
    }

    // GET: Bairros/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bairro = await _context.Bairro.FindAsync(id);
        if (bairro == null)
        {
            return NotFound();
        }
        return View(bairro);
    }

    // POST: Bairros/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Bairro bairro)
    {
        if (id != bairro.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(bairro);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BairroExists(bairro.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(bairro);
    }

    // GET: Bairros/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bairro = await _context.Bairro
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bairro == null)
        {
            return NotFound();
        }

        return View(bairro);
    }

    // POST: Bairros/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var bairro = await _context.Bairro.FindAsync(id);
        _context.Bairro.Remove(bairro);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool BairroExists(int id)
    {
        return _context.Bairro.Any(e => e.Id == id);
    }
}
}
