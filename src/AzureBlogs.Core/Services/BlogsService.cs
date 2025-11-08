using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;

namespace AzureBlogs.Core.Services;

public class BlogsService : IBlogsService
{
    private readonly IBlogsRepository repository;

    public BlogsService(IBlogsRepository repository)
    {
        this.repository = repository;
    }

    public async Task CreateBlog(Blog blog)
    {
        await repository.CreateBlogAsync(blog);
    }

    public async Task<bool> RemoveBlog(int id)
    {
        var blog = await repository.GetBlogAsync(id);
        if (blog is null)
        {
            return false;
        }

        await repository.RemoveBlogAsync(blog);
        return true;
    }
}
