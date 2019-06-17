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
    public class ClientServicesController : Controller
    {
        private readonly CRMContext _context;

        public ClientServicesController(CRMContext context)
        {
            _context = context;
        }

        // GET: ClientServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientService.ToListAsync());
        }

        // GET: ClientServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientService = await _context.ClientService
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientService == null)
            {
                return NotFound();
            }

            return View(clientService);
        }

        // GET: ClientServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,WarrantyExpiry,discount")] ClientService clientService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientService);
        }

        // GET: ClientServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientService = await _context.ClientService.FindAsync(id);
            if (clientService == null)
            {
                return NotFound();
            }
            return View(clientService);
        }

        // POST: ClientServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,EndDate,WarrantyExpiry,discount")] ClientService clientService)
        {
            if (id != clientService.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientServiceExists(clientService.Id))
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
            return View(clientService);
        }

        // GET: ClientServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientService = await _context.ClientService
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientService == null)
            {
                return NotFound();
            }

            return View(clientService);
        }

        // POST: ClientServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientService = await _context.ClientService.FindAsync(id);
            _context.ClientService.Remove(clientService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientServiceExists(int id)
        {
            return _context.ClientService.Any(e => e.Id == id);
        }
    }
}
