using AutoMapper;
using AzureBlogs.Domain.Entities;
using AzureBlogs.Domain.Repositories;
using MediatR;

namespace AzureBlogs.Domain.Commands
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
