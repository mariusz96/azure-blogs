using AutoMapper;
using AzureBlogs.Core.Commands;
using AzureBlogs.Core.Entities;

namespace AzureBlogs.Core.Profiles
{
    public class AddBlogCommandProfile : Profile
    {
        public AddBlogCommandProfile()
        {
            CreateMap<AddBlogCommand, Blog>(MemberList.Source);
        }
    }
}
