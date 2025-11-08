using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;
using AzureBlogs.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AzureBlogs.Infrastructure.Repositories;

public class BlogsRepository : IBlogsRepository
{
    private readonly AzureBlogsContext context;

    public BlogsRepository(AzureBlogsContext context)
    {
        this.context = context;
    }

    public async Task<Blog?> GetBlogAsync(int id)
    {
        return await context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task CreateBlogAsync(Blog blog)
    {
        context.Blogs.Add(blog);
        await context.SaveChangesAsync();
    }

    public async Task RemoveBlogAsync(Blog blog)
    {
        context.Blogs.Remove(blog);
        await context.SaveChangesAsync();
    }
}
