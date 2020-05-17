using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Komunumo.Blog.Data;
using Komunumo.Blog.Models;

namespace Komunumo.Blog.Controllers
{
    public class BlogPageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogPageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BlogPage
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogData.ToListAsync());
        }

        // GET: BlogPage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogData = await _context.BlogData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogData == null)
            {
                return NotFound();
            }

            return View(blogData);
        }

        // GET: BlogPage/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BlogPage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price")] BlogData blogData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogData);
        }

        // GET: BlogPage/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogData = await _context.BlogData.FindAsync(id);
            if (blogData == null)
            {
                return NotFound();
            }
            return View(blogData);
        }

        // POST: BlogPage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] BlogData blogData)
        {
            if (id != blogData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogDataExists(blogData.Id))
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
            return View(blogData);
        }

        // GET: BlogPage/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogData = await _context.BlogData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogData == null)
            {
                return NotFound();
            }

            return View(blogData);
        }

        // POST: BlogPage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogData = await _context.BlogData.FindAsync(id);
            _context.BlogData.Remove(blogData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogDataExists(int id)
        {
            return _context.BlogData.Any(e => e.Id == id);
        }
    }
}
