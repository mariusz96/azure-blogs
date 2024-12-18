using AzureBlogs.Domain.Commands;
using FluentValidation;

namespace AzureBlogs.Domain.Validators
{
    public class AddPostCommandValidator : AbstractValidator<AddPostCommand>
    {
        public AddPostCommandValidator()
        {
            RuleFor(b => b.Title).NotEmpty();
            RuleFor(b => b.Content).NotEmpty();
            RuleFor(b => b.BlogId).NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}
