using AzureBlogs.Domain.Commands;
using AzureBlogs.Domain.Extensions;
using FluentValidation;

namespace AzureBlogs.Domain.Validators
{
    public class AddBlogCommandValidator : AbstractValidator<AddBlogCommand>
    {
        public AddBlogCommandValidator()
        {
            RuleFor(b => b.Url).NotEmpty().Url();
        }
    }
}
