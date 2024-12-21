using MediatR;

namespace AzureBlogs.Core.Commands
{
    public class RemoveBlogCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
