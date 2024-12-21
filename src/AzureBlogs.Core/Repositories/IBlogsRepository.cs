using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Repositories
{
    public interface IBlogsRepository
    {
        Task<Blog?> GetBlogAsync(int id);
        Task AddBlogAsync(Blog blog);
        Task RemoveBlogAsync(Blog blog);
    }
}
