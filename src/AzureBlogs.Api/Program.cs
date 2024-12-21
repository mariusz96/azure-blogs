using Azure.Identity;
using AzureBlogs.Core.Commands;
using AzureBlogs.Core.Profiles;
using AzureBlogs.Core.Repositories;
using AzureBlogs.Core.Validators;
using AzureBlogs.Infrastructure.Contexts;
using AzureBlogs.Infrastructure.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureKeyVault(
    new Uri($"https://{builder.Configuration["KeyVaultName"]}.vault.azure.net/"),
    new DefaultAzureCredential());

builder.Services.AddDbContext<AzureBlogsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureBlogsContext")));

builder.Services.AddScoped<IBlogsRepository, BlogsRepository>();
builder.Services.AddScoped<IPostsRepository, PostsRepository>();

builder.Services.AddAutoMapper(typeof(AddBlogCommandProfile).Assembly);

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddBlogCommandHandler).Assembly));

builder.Services.AddValidatorsFromAssembly(typeof(AddBlogCommandValidator).Assembly);
builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error-development");
}
else
{
    app.UseExceptionHandler("/error");
}

app.UseAuthorization();

app.MapControllers();

app.Run();
