using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;
using AzureBlogs.Infrastructure.Contexts;

namespace AzureBlogs.Infrastructure.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly AzureBlogsContext _context;

        public PostsRepository(AzureBlogsContext context)
        {
            _context = context;
        }

        public async Task AddPostAsync(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }
    }
}
