using AzureBlogs.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AzureBlogs.Infrastructure.Contexts
{
    public class AzureBlogsContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public AzureBlogsContext(DbContextOptions<AzureBlogsContext> options)
            : base(options)
        {
        }
    }
}
