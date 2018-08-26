using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using recetas.Models;

namespace recetas.Controllers
{
    public class MedicamentosController : Controller
    {
        private readonly RecetasContext _context;

        public MedicamentosController(RecetasContext context)
        {
            _context = context;
        }

        // GET: Medicamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registros.ToListAsync());
        }

        // GET: Medicamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamentos = await _context.Registros
                .FirstOrDefaultAsync(m => m.Id_medicamento == id);
            if (medicamentos == null)
            {
                return NotFound();
            }

            return View(medicamentos);
        }

        // GET: Medicamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medicamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_medicamento,Atc,Generico,Nombre,Presentacion,Pvp,Acargoos,Acargoafil,Laboratorio,Registro,Pr,Plan,Grupoter,Obser")] Medicamentos medicamentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicamentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicamentos);
        }

        // GET: Medicamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamentos = await _context.Registros.FindAsync(id);
            if (medicamentos == null)
            {
                return NotFound();
            }
            return View(medicamentos);
        }

        // POST: Medicamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_medicamento,Atc,Generico,Nombre,Presentacion,Pvp,Acargoos,Acargoafil,Laboratorio,Registro,Pr,Plan,Grupoter,Obser")] Medicamentos medicamentos)
        {
            if (id != medicamentos.Id_medicamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicamentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicamentosExists(medicamentos.Id_medicamento))
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
            return View(medicamentos);
        }

        // GET: Medicamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamentos = await _context.Registros
                .FirstOrDefaultAsync(m => m.Id_medicamento == id);
            if (medicamentos == null)
            {
                return NotFound();
            }

            return View(medicamentos);
        }

        // POST: Medicamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicamentos = await _context.Registros.FindAsync(id);
            _context.Registros.Remove(medicamentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicamentosExists(int id)
        {
            return _context.Registros.Any(e => e.Id_medicamento == id);
        }
    }
}
