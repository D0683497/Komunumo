using System;
using Komunumo.Admin.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Komunumo.Admin.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            var hasher = new PasswordHasher<ApplicationUser>();

            for (int i = 0; i < 100; i++)
            {
                string name = "user" + i.ToString();
                var user = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    UserName = name,
                    NormalizedUserName = name.ToUpper(),
                    Email = name + "@gmail.com",
                    NormalizedEmail = name.ToUpper() + "@gmail.com".ToUpper(),
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                user.PasswordHash = hasher.HashPassword(user, name);
                
                builder.Entity<ApplicationUser>().HasData(user);
            }
        }
    }
}