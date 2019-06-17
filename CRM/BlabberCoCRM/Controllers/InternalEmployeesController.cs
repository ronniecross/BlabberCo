using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlabberCoCRM.Models;

namespace BlabberCoCRM.Controllers
{
    public class InternalEmployeesController : Controller
    {
        private readonly CRMContext _context;

        public InternalEmployeesController(CRMContext context)
        {
            _context = context;
        }

        // GET: InternalEmployees
        public async Task<IActionResult> Index()
        {
            return View(await _context.InternalEmployee.ToListAsync());
        }

        // GET: InternalEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var internalEmployee = await _context.InternalEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (internalEmployee == null)
            {
                return NotFound();
            }

            return View(internalEmployee);
        }

        // GET: InternalEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InternalEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] InternalEmployee internalEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(internalEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(internalEmployee);
        }

        // GET: InternalEmployees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var internalEmployee = await _context.InternalEmployee.FindAsync(id);
            if (internalEmployee == null)
            {
                return NotFound();
            }
            return View(internalEmployee);
        }

        // POST: InternalEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] InternalEmployee internalEmployee)
        {
            if (id != internalEmployee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(internalEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InternalEmployeeExists(internalEmployee.Id))
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
            return View(internalEmployee);
        }

        // GET: InternalEmployees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var internalEmployee = await _context.InternalEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (internalEmployee == null)
            {
                return NotFound();
            }

            return View(internalEmployee);
        }

        // POST: InternalEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var internalEmployee = await _context.InternalEmployee.FindAsync(id);
            _context.InternalEmployee.Remove(internalEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InternalEmployeeExists(int id)
        {
            return _context.InternalEmployee.Any(e => e.Id == id);
        }
    }
}
