using AzureBlogs.Core.Commands;
using FluentValidation;

namespace AzureBlogs.Core.Validators
{
    public class AddPostCommandValidator : AbstractValidator<AddPostCommand>
    {
        public AddPostCommandValidator()
        {
            RuleFor(b => b.Title).NotEmpty();
            RuleFor(b => b.Content).NotEmpty();
            RuleFor(b => b.BlogId).NotEmpty();
        }
    }
}
