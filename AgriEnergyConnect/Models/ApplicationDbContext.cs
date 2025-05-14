using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnect.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
    }
}
