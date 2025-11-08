using AutoMapper;
using AzureBlogs.Api.Dtos;
using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Profiles;

public class CreateBlogDtoProfile : Profile
{
    public CreateBlogDtoProfile()
    {
        CreateMap<CreateBlogDto, Blog>(MemberList.Source);
    }
}
