using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DbFirstApproch.Models;

namespace DbFirstApproch.Controllers
{
    public class StudentsTablesController : Controller
    {
        private readonly StudentDBContext _context;

        public StudentsTablesController(StudentDBContext context)
        {
            _context = context;
        }

        // GET: StudentsTables
        public async Task<IActionResult> Index()
        {
              return _context.StudentsTables != null ? 
                          View(await _context.StudentsTables.ToListAsync()) :
                          Problem("Entity set 'StudentDBContext.StudentsTables'  is null.");
        }

        // GET: StudentsTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StudentsTables == null)
            {
                return NotFound();
            }

            var studentsTable = await _context.StudentsTables
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentsTable == null)
            {
                return NotFound();
            }

            return View(studentsTable);
        }

        // GET: StudentsTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentsTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Age")] StudentsTable studentsTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentsTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentsTable);
        }

        // GET: StudentsTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StudentsTables == null)
            {
                return NotFound();
            }

            var studentsTable = await _context.StudentsTables.FindAsync(id);
            if (studentsTable == null)
            {
                return NotFound();
            }
            return View(studentsTable);
        }

        // POST: StudentsTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Age")] StudentsTable studentsTable)
        {
            if (id != studentsTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentsTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentsTableExists(studentsTable.Id))
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
            return View(studentsTable);
        }

        // GET: StudentsTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StudentsTables == null)
            {
                return NotFound();
            }

            var studentsTable = await _context.StudentsTables
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentsTable == null)
            {
                return NotFound();
            }

            return View(studentsTable);
        }

        // POST: StudentsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StudentsTables == null)
            {
                return Problem("Entity set 'StudentDBContext.StudentsTables'  is null.");
            }
            var studentsTable = await _context.StudentsTables.FindAsync(id);
            if (studentsTable != null)
            {
                _context.StudentsTables.Remove(studentsTable);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentsTableExists(int id)
        {
          return (_context.StudentsTables?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
