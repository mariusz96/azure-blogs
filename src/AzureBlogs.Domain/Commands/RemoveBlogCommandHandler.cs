using AzureBlogs.Domain.Repositories;
using MediatR;

namespace AzureBlogs.Domain.Commands
{
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommand, bool>
    {
        private readonly IBlogsRepository _repository;

        public RemoveBlogCommandHandler(IBlogsRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = await _repository.GetBlogAsync(request.Id);
            if (blog is null)
            {
                return false;
            }

            await _repository.RemoveBlogAsync(blog);
            return true;
        }
    }
}
