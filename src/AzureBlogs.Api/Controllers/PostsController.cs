using AutoMapper;
using AzureBlogs.Api.Dtos;
using AzureBlogs.Core.Entities;
using AzureBlogs.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlogs.Api.Controllers;

[ApiController]
[Route("api/posts")]
public class PostsController : ControllerBase
{
    private readonly IPostsService service;
    private readonly IMapper mapper;

    public PostsController(IPostsService service, IMapper mapper)
    {
        this.service = service;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreatePost([FromBody] CreatePostDto createPost)
    {
        var post = mapper.Map<Post>(createPost);
        await service.CreatePost(post);

        return StatusCode(StatusCodes.Status201Created, post.Id);
    }
}
