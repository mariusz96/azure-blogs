using AutoMapper;
using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;
using MediatR;

namespace AzureBlogs.Core.Commands
{
    public class AddBlogCommandHandler : IRequestHandler<AddBlogCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IBlogsRepository _repository;

        public AddBlogCommandHandler(IMapper mapper, IBlogsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<int> Handle(AddBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = _mapper.Map<Blog>(request);
            await _repository.AddBlogAsync(blog);

            return blog.Id;
        }
    }
}
