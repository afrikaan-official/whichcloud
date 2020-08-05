using FluentValidation;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.Validators
{
    public class SourceValidator : AbstractValidator<SourceModel>
    {
        public SourceValidator()
        {
            RuleFor(x => x.Url).NotNull()
                .WithMessage("Url Should not empty!")
                .Matches(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$")
                .WithMessage("Please send valid Url");
        }
    }
}