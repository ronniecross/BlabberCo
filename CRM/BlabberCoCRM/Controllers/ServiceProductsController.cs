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
    public class ServiceProductsController : Controller
    {
        private readonly CRMContext _context;

        public ServiceProductsController(CRMContext context)
        {
            _context = context;
        }

        // GET: ServiceProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServiceProduct.ToListAsync());
        }

        // GET: ServiceProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProduct = await _context.ServiceProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceProduct == null)
            {
                return NotFound();
            }

            return View(serviceProduct);
        }

        // GET: ServiceProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Summary,DurationDays")] ServiceProduct serviceProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceProduct);
        }

        // GET: ServiceProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProduct = await _context.ServiceProduct.FindAsync(id);
            if (serviceProduct == null)
            {
                return NotFound();
            }
            return View(serviceProduct);
        }

        // POST: ServiceProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Summary,DurationDays")] ServiceProduct serviceProduct)
        {
            if (id != serviceProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceProductExists(serviceProduct.Id))
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
            return View(serviceProduct);
        }

        // GET: ServiceProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProduct = await _context.ServiceProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceProduct == null)
            {
                return NotFound();
            }

            return View(serviceProduct);
        }

        // POST: ServiceProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceProduct = await _context.ServiceProduct.FindAsync(id);
            _context.ServiceProduct.Remove(serviceProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceProductExists(int id)
        {
            return _context.ServiceProduct.Any(e => e.Id == id);
        }
    }
}
