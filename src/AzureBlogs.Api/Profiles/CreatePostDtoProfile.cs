using AutoMapper;
using AzureBlogs.Api.Dtos;
using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Profiles;

public class CreatePostDtoProfile : Profile
{
    public CreatePostDtoProfile()
    {
        CreateMap<CreatePostDto, Post>(MemberList.Source);
    }
}
