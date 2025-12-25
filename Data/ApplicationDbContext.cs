using Microsoft.EntityFrameworkCore;
using vrmninkosesi.Models;
using vrmninkosesi.Models;

namespace vrmninkosesi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Media> Medias { get; set; }


    }
}

