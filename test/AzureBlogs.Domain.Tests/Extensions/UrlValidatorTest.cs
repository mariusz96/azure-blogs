using AzureBlogs.Domain.Extensions;
using FluentValidation;

namespace AzureBlogs.Domain.Tests.Extensions
{
    public class UrlValidatorTest
    {
        public class TestModel
        {
            public string? Url { get; set; }
        }

        public class TestValidator : AbstractValidator<TestModel>
        {
            public TestValidator()
            {
                RuleFor(x => x.Url).Url();
            }
        }

        [Theory]
        [MemberData(nameof(Should_Validate_Url_Data))]
        public void Should_Validate_Url(TestModel model, bool isValid)
        {
            var validator = new TestValidator();

            var validationResult = validator.Validate(model);

            Assert.Equal(isValid, validationResult.IsValid);
        }

        public static TheoryData<TestModel, bool> Should_Validate_Url_Data => new()
        {
            {
                new TestModel()
                {
                    Url = "https://www.google.com"
                },
                true
            },
            {
                new TestModel()
                {
                    Url = "notanurl"
                },
                false
            },
            {
                new TestModel()
                {
                    Url = null
                },
                true
            }
        };

        [Fact]
        public void Should_Get_Error_Message_When_Url_Is_Invalid()
        {
            var model = new TestModel()
            {
                Url = "notanurl"
            };
            var validator = new TestValidator();

            var validationResult = validator.Validate(model);

            Assert.Equal("'Url' is not a valid URL.", validationResult.Errors[0].ErrorMessage);
        }
    }
}
