using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Komunumo.Blog.Data;
using Komunumo.Blog.Models;
using Microsoft.CodeAnalysis;
using System.Globalization;
using System;
namespace Komunumo.Blog.Controllers
{
    public class BlogPageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogPageController(ApplicationDbContext context)
        {
            _context = context;
        }

        #region Index
        // GET: BlogPage
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogData.ToListAsync());
        }
        #endregion 

        #region Add_Like
        // GET: BlogPage/Details/5 Like it
        public async Task<IActionResult> Add_Like(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var blogData = await _context.BlogData
                            .FirstOrDefaultAsync(m => m.Id == id);
            if (blogData == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    blogData.LikeCounter += 1;
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
                return View("Details", blogData);
            }
        }
        #endregion


        #region Details
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
        #endregion

        #region Create
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
        public async Task<IActionResult> Create([Bind("Id,Title,Context")] BlogData blogData)
        {

            System.Diagnostics.Debug.WriteLine(this.User.Identity.Name);
            if (ModelState.IsValid)
            {
                //System.Diagnostics.Debug.WriteLine(blogData.LikeCounter);
                blogData.Poster = this.User.Identity.Name;
                blogData.EditDate = DateTime.Now;
                blogData.PostDate = DateTime.Now;
                _context.Add(blogData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogData);
        }
        #endregion

        #region Edit
        // GET: BlogPage/Edit/5
        // int ? id 表示允許參數接收null值
        public async Task<IActionResult> Edit(int? id)
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

        // POST: BlogPage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Context")] BlogData blogData)
        {
            if (id != blogData.Id)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    var OldblogData = await _context.BlogData.FindAsync(id);
                    OldblogData.EditDate = DateTime.Now;
                    OldblogData.Title = blogData.Title;
                    OldblogData.Context = blogData.Context;
                    _context.Update(OldblogData);
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
        #endregion

        #region Delete
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
        #endregion
        private bool BlogDataExists(int id)
        {
            return _context.BlogData.Any(e => e.Id == id);
        }
    }
}
