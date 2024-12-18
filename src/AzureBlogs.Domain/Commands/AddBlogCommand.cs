using MediatR;

namespace AzureBlogs.Domain.Commands
{
    public class AddBlogCommand : IRequest<int>
    {
        public string Url { get; set; } = string.Empty;
    }
}
