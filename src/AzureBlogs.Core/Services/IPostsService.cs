using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Services;

public interface IPostsService
{
    Task CreatePost(Post post);
}