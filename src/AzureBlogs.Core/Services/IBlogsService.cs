using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Services;

public interface IBlogsService
{
    Task CreateBlog(Blog blog);
    Task<bool> RemoveBlog(int id);
}