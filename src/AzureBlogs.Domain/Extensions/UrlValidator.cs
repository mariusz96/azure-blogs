using FluentValidation;
using FluentValidation.Validators;

namespace AzureBlogs.Domain.Extensions
{
    public class UrlValidator<T> : PropertyValidator<T, string?>
    {
        public override string Name => "UrlValidator";

        public override bool IsValid(ValidationContext<T> context, string? value)
        {
            if (value is null)
            {
                return true;
            }

            return value.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase)
                || value.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase)
                || value.StartsWith("ftp://", StringComparison.InvariantCultureIgnoreCase);
        }

        protected override string GetDefaultMessageTemplate(string errorCode) =>
            "'{PropertyName}' is not a valid URL.";
    }
}
