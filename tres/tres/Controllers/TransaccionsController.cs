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
    public class TransaccionsController : Controller
    {
        private readonly TresContext _context;

        public TransaccionsController(TresContext context)
        {
            _context = context;
        }

        // GET: Transaccions
        public async Task<IActionResult> Index()
        {
            var tresContext = _context.Transaccions.Include(t => t.CuentaDestinoNavigation).Include(t => t.CuentaOrigenNavigation);
            return View(await tresContext.ToListAsync());
        }

        // GET: Transaccions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaccion = await _context.Transaccions
                .Include(t => t.CuentaDestinoNavigation)
                .Include(t => t.CuentaOrigenNavigation)
                .FirstOrDefaultAsync(m => m.Idtransaccion == id);
            if (transaccion == null)
            {
                return NotFound();
            }

            return View(transaccion);
        }

        // GET: Transaccions/Create
        public IActionResult Create()
        {
            ViewData["CuentaDestino"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta");
            ViewData["CuentaOrigen"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta");
            return View();
        }

        // POST: Transaccions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idtransaccion,CuentaOrigen,CuentaDestino,Monto,Fecha")] Transaccion transaccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CuentaDestino"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta", transaccion.CuentaDestino);
            ViewData["CuentaOrigen"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta", transaccion.CuentaOrigen);
            return View(transaccion);
        }

        // GET: Transaccions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaccion = await _context.Transaccions.FindAsync(id);
            if (transaccion == null)
            {
                return NotFound();
            }
            ViewData["CuentaDestino"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta", transaccion.CuentaDestino);
            ViewData["CuentaOrigen"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta", transaccion.CuentaOrigen);
            return View(transaccion);
        }

        // POST: Transaccions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idtransaccion,CuentaOrigen,CuentaDestino,Monto,Fecha")] Transaccion transaccion)
        {
            if (id != transaccion.Idtransaccion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransaccionExists(transaccion.Idtransaccion))
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
            ViewData["CuentaDestino"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta", transaccion.CuentaDestino);
            ViewData["CuentaOrigen"] = new SelectList(_context.Cuenta, "Idcuenta", "Idcuenta", transaccion.CuentaOrigen);
            return View(transaccion);
        }

        // GET: Transaccions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaccion = await _context.Transaccions
                .Include(t => t.CuentaDestinoNavigation)
                .Include(t => t.CuentaOrigenNavigation)
                .FirstOrDefaultAsync(m => m.Idtransaccion == id);
            if (transaccion == null)
            {
                return NotFound();
            }

            return View(transaccion);
        }

        // POST: Transaccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaccion = await _context.Transaccions.FindAsync(id);
            if (transaccion != null)
            {
                _context.Transaccions.Remove(transaccion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransaccionExists(int id)
        {
            return _context.Transaccions.Any(e => e.Idtransaccion == id);
        }
    }
}
