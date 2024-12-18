using AzureBlogs.Domain.Entities;

namespace AzureBlogs.Domain.Repositories
{
    public interface IPostsRepository
    {
        Task AddPostAsync(Post post);
    }
}
