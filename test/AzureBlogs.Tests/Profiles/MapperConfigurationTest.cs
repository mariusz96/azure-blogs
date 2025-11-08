using AutoMapper;
using AzureBlogs.Core.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace AzureBlogs.Tests.Profiles;

public class MapperConfigurationTest
{
    [Fact]
    public void Should_Be_Valid()
    {
        var serviceProvider = new ServiceCollection()
            .AddAutoMapper(typeof(CreateBlogDtoProfile).Assembly)
            .BuildServiceProvider();

        var mapper = serviceProvider.GetRequiredService<IMapper>();

        mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
}
