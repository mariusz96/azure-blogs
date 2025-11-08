using System.ComponentModel.DataAnnotations;

namespace AzureBlogs.Api.Dtos;

public record CreatePostDto(
    [Required(AllowEmptyStrings = false)]
    string Title,
    [Required(AllowEmptyStrings = false)]
    string Content,
    [Required(AllowEmptyStrings = false)]
    int BlogId);
