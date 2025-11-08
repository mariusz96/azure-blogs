using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;
using AzureBlogs.Infrastructure.Contexts;

namespace AzureBlogs.Infrastructure.Repositories;

public class PostsRepository : IPostsRepository
{
    private readonly AzureBlogsContext context;

    public PostsRepository(AzureBlogsContext context)
    {
        this.context = context;
    }

    public async Task CreatePostAsync(Post post)
    {
        context.Posts.Add(post);
        await context.SaveChangesAsync();
    }
}
