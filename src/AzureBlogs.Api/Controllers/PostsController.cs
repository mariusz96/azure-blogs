using AzureBlogs.Core.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlogs.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddPost(AddPostCommand command)
        {
            int response = await _mediator.Send(command);
            return StatusCode(StatusCodes.Status201Created, response);
        }
    }
}
