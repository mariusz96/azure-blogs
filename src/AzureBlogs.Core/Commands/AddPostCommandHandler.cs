using AutoMapper;
using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Repositories;
using MediatR;

namespace AzureBlogs.Core.Commands
{
    public class AddPostCommandHandler : IRequestHandler<AddPostCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IPostsRepository _repository;

        public AddPostCommandHandler(IMapper mapper, IPostsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<int> Handle(AddPostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);
            await _repository.AddPostAsync(post);

            return post.Id;
        }
    }
}
