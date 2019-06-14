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
    public class TangibleProductsController : Controller
    {
        private readonly CRMContext _context;

        public TangibleProductsController(CRMContext context)
        {
            _context = context;
        }

        // GET: TangibleProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.TangibleProduct.ToListAsync());
        }

        // GET: TangibleProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tangibleProduct = await _context.TangibleProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tangibleProduct == null)
            {
                return NotFound();
            }

            return View(tangibleProduct);
        }

        // GET: TangibleProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TangibleProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Manufacture,Model,EndOfLife")] TangibleProduct tangibleProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tangibleProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tangibleProduct);
        }

        // GET: TangibleProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tangibleProduct = await _context.TangibleProduct.FindAsync(id);
            if (tangibleProduct == null)
            {
                return NotFound();
            }
            return View(tangibleProduct);
        }

        // POST: TangibleProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Manufacture,Model,EndOfLife")] TangibleProduct tangibleProduct)
        {
            if (id != tangibleProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tangibleProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TangibleProductExists(tangibleProduct.Id))
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
            return View(tangibleProduct);
        }

        // GET: TangibleProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tangibleProduct = await _context.TangibleProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tangibleProduct == null)
            {
                return NotFound();
            }

            return View(tangibleProduct);
        }

        // POST: TangibleProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tangibleProduct = await _context.TangibleProduct.FindAsync(id);
            _context.TangibleProduct.Remove(tangibleProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TangibleProductExists(int id)
        {
            return _context.TangibleProduct.Any(e => e.Id == id);
        }
    }
}
