using AzureBlogs.Domain.Entities;

namespace AzureBlogs.Domain.Repositories
{
    public interface IBlogsRepository
    {
        Task<Blog?> GetBlogAsync(int id);
        Task AddBlogAsync(Blog blog);
        Task RemoveBlogAsync(Blog blog);
    }
}
