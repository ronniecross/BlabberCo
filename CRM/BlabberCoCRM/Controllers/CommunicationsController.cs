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
    public class CommunicationsController : Controller
    {
        private readonly CRMContext _context;

        public CommunicationsController(CRMContext context)
        {
            _context = context;
        }

        // GET: Communications
        public async Task<IActionResult> Index()
        {
            return View(await _context.Communication.ToListAsync());
        }

        // GET: Communications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communication = await _context.Communication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (communication == null)
            {
                return NotFound();
            }

            return View(communication);
        }

        // GET: Communications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Communications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,DateTime")] Communication communication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(communication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(communication);
        }

        // GET: Communications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communication = await _context.Communication.FindAsync(id);
            if (communication == null)
            {
                return NotFound();
            }
            return View(communication);
        }

        // POST: Communications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,DateTime")] Communication communication)
        {
            if (id != communication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(communication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommunicationExists(communication.Id))
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
            return View(communication);
        }

        // GET: Communications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communication = await _context.Communication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (communication == null)
            {
                return NotFound();
            }

            return View(communication);
        }

        // POST: Communications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var communication = await _context.Communication.FindAsync(id);
            _context.Communication.Remove(communication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommunicationExists(int id)
        {
            return _context.Communication.Any(e => e.Id == id);
        }
    }
}
