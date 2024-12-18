using AzureBlogs.Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlogs.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddBlog(AddBlogCommand command)
        {
            int response = await _mediator.Send(command);
            return StatusCode(StatusCodes.Status201Created, response);
        }

        [HttpDelete("{id:min(1)}")]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            bool response = await _mediator.Send(new RemoveBlogCommand { Id = id });
            if (!response)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
