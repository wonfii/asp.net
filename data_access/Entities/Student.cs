using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace data_access.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public decimal AverageGrade { get; set; }

        public string? StudentImage { get; set; }

        public FieldOfStudy FieldOfStudy { get; set; }

        public int FieldOfStudyId {  get; set; }

        public string Email { get; set; }

        public ICollection<Subject>? Subjects { get; set; }

        public string? UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
