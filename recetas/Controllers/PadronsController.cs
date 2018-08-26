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
    public class PadronsController : Controller
    {
        private readonly RecetasContext _context;

        public PadronsController(RecetasContext context)
        {
            _context = context;
        }

        // GET: Padrons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Procesos.ToListAsync());
        }

        // GET: Padrons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padron = await _context.Procesos
                .FirstOrDefaultAsync(m => m.Id_Padron == id);
            if (padron == null)
            {
                return NotFound();
            }

            return View(padron);
        }

        // GET: Padrons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Padrons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Padron,Plan,Categoria,Numero,Orden,Tipo_doc,Num_doc,Nombre,Sexo,Ecivil,F_nacimiento,Nacionalidad,Parentesco,Vive_calle,Vive_numero,Vive_piso,Vive_depto,Vive_cod_postal,Vive_localidad_texto,Vive_localidad,Vive_partido,Vive_provincia,Telefono,Movil,Email,F_ingreso,Prepaga_anterior,F_egreso,Prepaga_proxima,Volveria,Motivo_baja_miembro,Motivo_baja_miembro_agrupado,Cobrador,Zona,F_alta_grupo,F_antiguedad1,Promotor,Tipo_grupo,Presento,F_baja,Motivo_baja_grupo,Motivo_baja_agrupado_grupo")] Padron padron)
        {
            if (ModelState.IsValid)
            {
                _context.Add(padron);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(padron);
        }

        // GET: Padrons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padron = await _context.Procesos.FindAsync(id);
            if (padron == null)
            {
                return NotFound();
            }
            return View(padron);
        }

        // POST: Padrons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Padron,Plan,Categoria,Numero,Orden,Tipo_doc,Num_doc,Nombre,Sexo,Ecivil,F_nacimiento,Nacionalidad,Parentesco,Vive_calle,Vive_numero,Vive_piso,Vive_depto,Vive_cod_postal,Vive_localidad_texto,Vive_localidad,Vive_partido,Vive_provincia,Telefono,Movil,Email,F_ingreso,Prepaga_anterior,F_egreso,Prepaga_proxima,Volveria,Motivo_baja_miembro,Motivo_baja_miembro_agrupado,Cobrador,Zona,F_alta_grupo,F_antiguedad1,Promotor,Tipo_grupo,Presento,F_baja,Motivo_baja_grupo,Motivo_baja_agrupado_grupo")] Padron padron)
        {
            if (id != padron.Id_Padron)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(padron);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PadronExists(padron.Id_Padron))
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
            return View(padron);
        }

        // GET: Padrons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padron = await _context.Procesos
                .FirstOrDefaultAsync(m => m.Id_Padron == id);
            if (padron == null)
            {
                return NotFound();
            }

            return View(padron);
        }

        // POST: Padrons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var padron = await _context.Procesos.FindAsync(id);
            _context.Procesos.Remove(padron);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PadronExists(int id)
        {
            return _context.Procesos.Any(e => e.Id_Padron == id);
        }
    }
}
