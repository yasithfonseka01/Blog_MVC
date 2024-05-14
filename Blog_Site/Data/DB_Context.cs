using Blog_Site.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog_Site.Data
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
 
    }
}
