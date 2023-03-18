using Microsoft.EntityFrameworkCore;
using Trabalho1.Models;

namespace Trabalho1.Data
{
    public class ApplicationDbContext : DbContext              
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
