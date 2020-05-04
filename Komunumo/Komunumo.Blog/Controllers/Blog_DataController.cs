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
    public class Blog_DataController : Controller
    {
        private readonly ApplicationContext _context;

        public Blog_DataController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Blog_Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blog_Data.ToListAsync());
        }

        // GET: Blog_Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog_Data = await _context.Blog_Data
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog_Data == null)
            {
                return NotFound();
            }

            return View(blog_Data);
        }

        // GET: Blog_Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blog_Data/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArticleTitle,Context")] Blog_Data blog_Data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog_Data);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog_Data);
        }

        // GET: Blog_Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog_Data = await _context.Blog_Data.FindAsync(id);
            if (blog_Data == null)
            {
                return NotFound();
            }
            return View(blog_Data);
        }

        // POST: Blog_Data/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ArticleTitle,Context")] Blog_Data blog_Data)
        {
            if (id != blog_Data.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blog_Data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Blog_DataExists(blog_Data.Id))
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
            return View(blog_Data);
        }

        // GET: Blog_Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog_Data = await _context.Blog_Data
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog_Data == null)
            {
                return NotFound();
            }

            return View(blog_Data);
        }

        // POST: Blog_Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog_Data = await _context.Blog_Data.FindAsync(id);
            _context.Blog_Data.Remove(blog_Data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Blog_DataExists(int id)
        {
            return _context.Blog_Data.Any(e => e.Id == id);
        }
    }
}
