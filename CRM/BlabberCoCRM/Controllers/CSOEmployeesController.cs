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
    public class CSOEmployeesController : Controller
    {
        private readonly CRMContext _context;

        public CSOEmployeesController(CRMContext context)
        {
            _context = context;
        }

        // GET: CSOEmployees
        public async Task<IActionResult> Index()
        {
            return View(await _context.CSOEmployee.ToListAsync());
        }

        // GET: CSOEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cSOEmployee = await _context.CSOEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cSOEmployee == null)
            {
                return NotFound();
            }

            return View(cSOEmployee);
        }

        // GET: CSOEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CSOEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress")] CSOEmployee cSOEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cSOEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cSOEmployee);
        }

        // GET: CSOEmployees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cSOEmployee = await _context.CSOEmployee.FindAsync(id);
            if (cSOEmployee == null)
            {
                return NotFound();
            }
            return View(cSOEmployee);
        }

        // POST: CSOEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress")] CSOEmployee cSOEmployee)
        {
            if (id != cSOEmployee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cSOEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CSOEmployeeExists(cSOEmployee.Id))
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
            return View(cSOEmployee);
        }

        // GET: CSOEmployees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cSOEmployee = await _context.CSOEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cSOEmployee == null)
            {
                return NotFound();
            }

            return View(cSOEmployee);
        }

        // POST: CSOEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cSOEmployee = await _context.CSOEmployee.FindAsync(id);
            _context.CSOEmployee.Remove(cSOEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CSOEmployeeExists(int id)
        {
            return _context.CSOEmployee.Any(e => e.Id == id);
        }
    }
}
