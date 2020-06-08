using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Komunumo.Blog.Models;
namespace Komunumo.Blog.Data
{
    public class ApplicationDbContext : IdentityDbContext<BlogUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Like_s_article> Like_s_article { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Like_s_article>()
                .HasKey(c => new { c.Username, c.Article_ID });
        }
    }
}
