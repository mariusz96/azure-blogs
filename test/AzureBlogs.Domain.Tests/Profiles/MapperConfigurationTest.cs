using AutoMapper;
using AzureBlogs.Domain.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace AzureBlogs.Domain.Tests.Profiles
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
