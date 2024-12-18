using AzureBlogs.Domain.Entities;
using AzureBlogs.Domain.Repositories;
using AzureBlogs.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AzureBlogs.Infrastructure.Repositories
{
    public class BlogsRepository : IBlogsRepository
    {
        private readonly AzureBlogsContext _context;

        public BlogsRepository(AzureBlogsContext context)
        {
            _context = context;
        }

        public async Task<Blog?> GetBlogAsync(int id)
        {
            return await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddBlogAsync(Blog blog)
        {
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveBlogAsync(Blog blog)
        {
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
        }
    }
}
