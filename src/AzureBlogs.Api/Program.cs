using Azure.Identity;
using AzureBlogs.Core.Profiles;
using AzureBlogs.Core.Repositories;
using AzureBlogs.Core.Services;
using AzureBlogs.Infrastructure.Contexts;
using AzureBlogs.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureKeyVault(
    new Uri($"https://{builder.Configuration["KeyVaultName"]}.vault.azure.net/"),
    new DefaultAzureCredential());

builder.Services.AddDbContext<AzureBlogsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureBlogsContext")));

builder.Services.AddScoped<IBlogsService, BlogsService>();
builder.Services.AddScoped<IPostsService, PostsService>();

builder.Services.AddScoped<IBlogsRepository, BlogsRepository>();
builder.Services.AddScoped<IPostsRepository, PostsRepository>();

builder.Services.AddAutoMapper(typeof(CreateBlogDtoProfile).Assembly);

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
