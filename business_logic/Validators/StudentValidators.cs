using data_access.Entities;
using FluentValidation;

namespace Student_Management.Validators
{
    public class StudentValidators : AbstractValidator<Student>
    {
        public StudentValidators() 
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithMessage("This field is required.");

            RuleFor(x => x.AverageGrade)
                .NotNull()
                .InclusiveBetween(2, 5);

            RuleFor(x => x.StudentImage).Must(LinkMustBeAUri)
               .WithMessage("{PropertyName} has incorrect URL format");

            RuleFor(x => x.Email)
               .NotEmpty()
               .NotNull()
               .EmailAddress()
               .WithMessage("Invalid email format.")
               .Must(email => email.EndsWith("@student.uni"))
               .WithMessage("Email must end with @student.uni");
        }

        private static bool LinkMustBeAUri(string? link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return true;
            }

            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
