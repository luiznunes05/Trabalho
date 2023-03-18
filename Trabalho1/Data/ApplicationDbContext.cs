using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trabalho1.Models;

namespace Trabalho1.Data
{
    public class ApplicationDbContext : IdentityDbContext              
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
