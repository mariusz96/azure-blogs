using AutoMapper;
using AzureBlogs.Domain.Commands;
using AzureBlogs.Domain.Entities;

namespace AzureBlogs.Domain.Profiles
{
    public class AddPostCommandProfile : Profile
    {
        public AddPostCommandProfile()
        {
            CreateMap<AddPostCommand, Post>(MemberList.Source);
        }
    }
}
