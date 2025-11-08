using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;
using AzureBlogs.Core.Services;
using Moq;

namespace AzureBlogs.Tests.Services;

public class BlogsServiceTest
{
    [Fact]
    public async Task Should_Remove_Post_If_Exists()
    {
        var blog = new Blog();
        var repository = new Mock<IBlogsRepository>();
        repository.Setup(r => r.GetBlogAsync(1))
            .ReturnsAsync(blog);
        repository.Setup(r => r.RemoveBlogAsync(blog))
            .Returns(Task.CompletedTask);
        var service = new BlogsService(repository.Object);

        var result = await service.RemoveBlog(1);

        Assert.True(result);
    }

    [Fact]
    public async Task Should_Not_Remove_Post_If_Not_Exists()
    {
        var repository = new Mock<IBlogsRepository>();
        repository.Setup(r => r.GetBlogAsync(1))
            .ReturnsAsync((Blog?)null);
        var service = new BlogsService(repository.Object);

        var result = await service.RemoveBlog(1);
        
        Assert.False(result);
    }
}
