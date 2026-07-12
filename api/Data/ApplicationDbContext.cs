using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comment { get; set; }

    }
}
