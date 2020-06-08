using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Komunumo.Blog.Data;
using Komunumo.Blog.Models;
using Microsoft.CodeAnalysis;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Komunumo.Blog.Controllers
{
    [Authorize]
    public class BlogPageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogPageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        #region Index
        // GET: BlogPage
        public async Task<IActionResult> Index()
        {
            return View(await _context.Article.ToListAsync());
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
            var article = await _context.Article
                            .FirstOrDefaultAsync(m => m.Article_ID == id);
            if (article == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    article.Popularity += 1;
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Article_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return View("Details", article);
            }
        }
        #endregion

        [AllowAnonymous]
        #region Details
        // GET: BlogPage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article
                .FirstOrDefaultAsync(m => m.Article_ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
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
        public async Task<IActionResult> Create([Bind("Title,Context")] Article article)
        {

            System.Diagnostics.Debug.WriteLine(this.User.Identity.Name);
            if (ModelState.IsValid)
            {
                //System.Diagnostics.Debug.WriteLine(article.LikeCounter);
                article.Poster = this.User.Identity.Name;
                article.OwnerID = this.User.Identity.Name;
                article.EditDate = DateTime.Now;
                article.PostDate = DateTime.Now;

                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }
        #endregion

        #region Edit
        // GET: BlogPage/Edit/5
        // int ? Article_ID 表示允許參數接收null值
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
                    
            var article = await _context.Article
                    .FirstOrDefaultAsync(m => m.Article_ID == id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: BlogPage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int article_ID, [Bind("Article_ID,Title,Context")] Article article)
        {
            if (article_ID != article.Article_ID)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    var Oldarticle = await _context.Article.FindAsync(article_ID);
                    Oldarticle.EditDate = DateTime.Now;
                    Oldarticle.Title = article.Title;
                    Oldarticle.Context = article.Context;
                    _context.Update(Oldarticle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Article_ID))
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
            return View(article);
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

            var article = await _context.Article
                .FirstOrDefaultAsync(m => m.Article_ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }
        

        // POST: BlogPage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogData = await _context.Article.FindAsync(id);
            _context.Article.Remove(blogData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
        private bool ArticleExists(int article_ID)
        {
            return _context.Article.Any(e => e.Article_ID == article_ID);
        }
    }
}
