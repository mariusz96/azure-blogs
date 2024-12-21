using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Repositories
{
    public interface IPostsRepository
    {
        Task AddPostAsync(Post post);
    }
}
