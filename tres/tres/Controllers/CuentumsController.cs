using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tres.Models;

namespace tres.Controllers
{
    public class CuentumsController : Controller
    {
        private readonly TresContext _context;

        public CuentumsController(TresContext context)
        {
            _context = context;
        }

        // GET: Cuentums
        public async Task<IActionResult> Index()
        {
            var tresContext = _context.Cuenta.Include(c => c.IdclienteNavigation);
            return View(await tresContext.ToListAsync());
        }

        // GET: Cuentums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuentum = await _context.Cuenta
                .Include(c => c.IdclienteNavigation)
                .FirstOrDefaultAsync(m => m.Idcuenta == id);
            if (cuentum == null)
            {
                return NotFound();
            }

            return View(cuentum);
        }

        // GET: Cuentums/Create
        public IActionResult Create()
        {
            ViewData["Idcliente"] = new SelectList(_context.Personas, "Idpersona", "Idpersona");
            return View();
        }

        // POST: Cuentums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idcuenta,Tipo,Saldo,FechaCreacion,Idcliente,Departamento")] Cuentum cuentum)
        {
            
            if (ModelState.IsValid)
            {
                cuentum.FechaCreacion = DateOnly.FromDateTime(DateTime.Today);
                _context.Add(cuentum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcliente"] = new SelectList(_context.Personas, "Idpersona", "Idpersona", cuentum.Idcliente);
            return View(cuentum);
        }

        // GET: Cuentums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuentum = await _context.Cuenta.FindAsync(id);
            if (cuentum == null)
            {
                return NotFound();
            }
            ViewData["Idcliente"] = new SelectList(_context.Personas, "Idpersona", "Idpersona", cuentum.Idcliente);
            return View(cuentum);
        }

        // POST: Cuentums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idcuenta,Tipo,Saldo,FechaCreacion,Idcliente,Departamento")] Cuentum cuentum)
        {
            if (id != cuentum.Idcuenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuentum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuentumExists(cuentum.Idcuenta))
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
            ViewData["Idcliente"] = new SelectList(_context.Personas, "Idpersona", "Idpersona", cuentum.Idcliente);
            return View(cuentum);
        }

        // GET: Cuentums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuentum = await _context.Cuenta
                .Include(c => c.IdclienteNavigation)
                .FirstOrDefaultAsync(m => m.Idcuenta == id);
            if (cuentum == null)
            {
                return NotFound();
            }

            return View(cuentum);
        }

        // POST: Cuentums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cuentum = await _context.Cuenta.FindAsync(id);
            if (cuentum != null)
            {
                _context.Cuenta.Remove(cuentum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuentumExists(int id)
        {
            return _context.Cuenta.Any(e => e.Idcuenta == id);
        }

        // kass
        public IActionResult ObtenerFecha()
        {
            Cuentum modelo = new Cuentum();
            modelo.FechaCreacion = DateOnly.FromDateTime(DateTime.Today);

            return View(modelo);
        }
    }
}
