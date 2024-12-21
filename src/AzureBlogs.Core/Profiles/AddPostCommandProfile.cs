using AutoMapper;
using AzureBlogs.Core.Commands;
using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Profiles
{
    public class AddPostCommandProfile : Profile
    {
        public AddPostCommandProfile()
        {
            CreateMap<AddPostCommand, Post>(MemberList.Source);
        }
    }
}
