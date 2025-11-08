using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;

namespace AzureBlogs.Core.Services;

public class PostsService : IPostsService
{
    private readonly IPostsRepository repository;

    public PostsService(IPostsRepository repository)
    {
        this.repository = repository;
    }

    public async Task CreatePost(Post post)
    {
        await repository.CreatePostAsync(post);
    }
}
