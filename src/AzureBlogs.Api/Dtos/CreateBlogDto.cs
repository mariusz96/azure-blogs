using System.ComponentModel.DataAnnotations;

namespace AzureBlogs.Api.Dtos;

public record CreateBlogDto(
    [Url]
    [Required(AllowEmptyStrings = false)]
    string Url);
