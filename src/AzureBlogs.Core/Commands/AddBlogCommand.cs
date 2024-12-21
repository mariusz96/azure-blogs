using MediatR;

namespace AzureBlogs.Core.Commands
{
    public class AddBlogCommand : IRequest<int>
    {
        public string Url { get; set; } = string.Empty;
    }
}
