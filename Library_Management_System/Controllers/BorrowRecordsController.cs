using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library_Management_System.Data;
using Library_Management_System.Models;

namespace Library_Management_System.Controllers
{
    public class BorrowRecordsController : Controller
    {
        private readonly NeondbContext _context;

        public BorrowRecordsController(NeondbContext context)
        {
            _context = context;
        }

        // GET: BorrowRecords
        public async Task<IActionResult> Index()
        {
            var neondbContext = _context.BorrowRecords.Include(b => b.Book);
            return View(await neondbContext.ToListAsync());
        }

        // GET: BorrowRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowRecord = await _context.BorrowRecords
                .Include(b => b.Book)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowRecord == null)
            {
                return NotFound();
            }

            return View(borrowRecord);
        }

        // GET: BorrowRecords/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "Bookid", "Bookid");
            return View();
        }

        // POST: BorrowRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookId,BorrowerName,BorrowDate,ReturnDate")] BorrowRecord borrowRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borrowRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Bookid", "Bookid", borrowRecord.BookId);
            return View(borrowRecord);
        }

        // GET: BorrowRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowRecord = await _context.BorrowRecords.FindAsync(id);
            if (borrowRecord == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Bookid", "Bookid", borrowRecord.BookId);
            return View(borrowRecord);
        }

        // POST: BorrowRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookId,BorrowerName,BorrowDate,ReturnDate")] BorrowRecord borrowRecord)
        {
            if (id != borrowRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrowRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorrowRecordExists(borrowRecord.Id))
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
            ViewData["BookId"] = new SelectList(_context.Books, "Bookid", "Bookid", borrowRecord.BookId);
            return View(borrowRecord);
        }

        // GET: BorrowRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowRecord = await _context.BorrowRecords
                .Include(b => b.Book)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowRecord == null)
            {
                return NotFound();
            }

            return View(borrowRecord);
        }

        // POST: BorrowRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var borrowRecord = await _context.BorrowRecords.FindAsync(id);
            if (borrowRecord != null)
            {
                _context.BorrowRecords.Remove(borrowRecord);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorrowRecordExists(int id)
        {
            return _context.BorrowRecords.Any(e => e.Id == id);
        }
    }
}
