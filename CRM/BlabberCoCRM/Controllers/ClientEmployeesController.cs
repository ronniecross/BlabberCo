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
    public class ClientEmployeesController : Controller
    {
        private readonly CRMContext _context;

        public ClientEmployeesController(CRMContext context)
        {
            _context = context;
        }

        // GET: ClientEmployees
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientEmployee.ToListAsync());
        }

        // GET: ClientEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientEmployee = await _context.ClientEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientEmployee == null)
            {
                return NotFound();
            }

            return View(clientEmployee);
        }

        // GET: ClientEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress")] ClientEmployee clientEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientEmployee);
        }

        // GET: ClientEmployees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientEmployee = await _context.ClientEmployee.FindAsync(id);
            if (clientEmployee == null)
            {
                return NotFound();
            }
            return View(clientEmployee);
        }

        // POST: ClientEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,EmailAddress")] ClientEmployee clientEmployee)
        {
            if (id != clientEmployee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientEmployeeExists(clientEmployee.Id))
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
            return View(clientEmployee);
        }

        // GET: ClientEmployees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientEmployee = await _context.ClientEmployee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientEmployee == null)
            {
                return NotFound();
            }

            return View(clientEmployee);
        }

        // POST: ClientEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientEmployee = await _context.ClientEmployee.FindAsync(id);
            _context.ClientEmployee.Remove(clientEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientEmployeeExists(int id)
        {
            return _context.ClientEmployee.Any(e => e.Id == id);
        }
    }
}
