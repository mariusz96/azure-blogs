using AzureBlogs.Core.Commands;
using AzureBlogs.Core.Extensions;
using FluentValidation;

namespace AzureBlogs.Core.Validators
{
    public class AddBlogCommandValidator : AbstractValidator<AddBlogCommand>
    {
        public AddBlogCommandValidator()
        {
            RuleFor(b => b.Url).NotEmpty().Url();
        }
    }
}
