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
    public class SalesEmployeesController : Controller
    {
        private readonly CRMContext _context;

        public SalesEmployeesController(CRMContext context)
        {
            _context = context;
        }

        // GET: SalesEmployees
        public async Task<IActionResult> Index()
        {
            return View(await _context.SalesEmployee.ToListAsync());
        }

        // GET: SalesEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesEmployee = await _context.SalesEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesEmployee == null)
            {
                return NotFound();
            }

            return View(salesEmployee);
        }

        // GET: SalesEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] SalesEmployee salesEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesEmployee);
        }

        // GET: SalesEmployees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesEmployee = await _context.SalesEmployee.FindAsync(id);
            if (salesEmployee == null)
            {
                return NotFound();
            }
            return View(salesEmployee);
        }

        // POST: SalesEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] SalesEmployee salesEmployee)
        {
            if (id != salesEmployee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesEmployeeExists(salesEmployee.Id))
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
            return View(salesEmployee);
        }

        // GET: SalesEmployees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesEmployee = await _context.SalesEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesEmployee == null)
            {
                return NotFound();
            }

            return View(salesEmployee);
        }

        // POST: SalesEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesEmployee = await _context.SalesEmployee.FindAsync(id);
            _context.SalesEmployee.Remove(salesEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesEmployeeExists(int id)
        {
            return _context.SalesEmployee.Any(e => e.Id == id);
        }
    }
}
