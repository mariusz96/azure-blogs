using AutoMapper;
using AzureBlogs.Core.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace AzureBlogs.Core.Tests.Profiles
{
    public class MapperConfigurationTest
    {
        [Fact]
        public void Should_Be_Valid()
        {
            var serviceProvider = new ServiceCollection()
                .AddAutoMapper(typeof(AddBlogCommandProfile).Assembly)
                .BuildServiceProvider();

            var mapper = serviceProvider.GetRequiredService<IMapper>();

            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
