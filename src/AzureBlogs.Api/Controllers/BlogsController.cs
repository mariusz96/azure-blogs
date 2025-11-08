using AutoMapper;
using AzureBlogs.Api.Dtos;
using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlogs.Api.Controllers;

[ApiController]
[Route("api/blogs")]
public class BlogsController : ControllerBase
{
    private readonly IBlogsService service;
    private readonly IMapper mapper;

    public BlogsController(IBlogsService service, IMapper mapper)
    {
        this.service = service;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateBlog([FromBody] CreateBlogDto createBlog)
    {
        var blog = mapper.Map<Blog>(createBlog);
        await service.CreateBlog(blog);

        return StatusCode(StatusCodes.Status201Created, blog.Id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveBlog([FromRoute] int id)
    {
        bool removed = await service.RemoveBlog(id);

        return removed ? NoContent() : NotFound();
    }
}
