using MediatR;

namespace AzureBlogs.Domain.Commands
{
    public class RemoveBlogCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
