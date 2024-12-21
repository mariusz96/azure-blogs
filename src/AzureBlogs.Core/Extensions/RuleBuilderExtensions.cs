using FluentValidation;

namespace AzureBlogs.Core.Extensions
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilderOptions<T, string?> Url<T>(this IRuleBuilder<T, string?> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new UrlValidator<T>());
        }
    }
}
