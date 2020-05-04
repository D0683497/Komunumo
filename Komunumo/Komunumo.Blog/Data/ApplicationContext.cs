using Microsoft.EntityFrameworkCore;
using Komunumo.Blog.Models;

namespace Komunumo.Blog.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Blog_Data> Blog_Data { get; set; }
    }
}