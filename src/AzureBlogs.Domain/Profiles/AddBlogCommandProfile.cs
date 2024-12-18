using AutoMapper;
using AzureBlogs.Domain.Commands;
using AzureBlogs.Domain.Entities;

namespace AzureBlogs.Domain.Profiles
{
    public class AddBlogCommandProfile : Profile
    {
        public AddBlogCommandProfile()
        {
            CreateMap<AddBlogCommand, Blog>(MemberList.Source);
        }
    }
}
