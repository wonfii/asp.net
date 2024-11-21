using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Configuration
{
    public class StudentDbConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(st => st.FullName).IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_Student_AverageGrade", "AverageGrade >= 2 AND AverageGrade <= 5"));


            // Relationships configuration 

            // Student - FieldOfStudy (* - 1)

            builder.HasOne(st => st.FieldOfStudy)
               .WithMany(f => f.Students)
               .HasForeignKey(st => st.FieldOfStudyId);

            // Student - Subject (* - *)

            builder.HasMany(st => st.Subjects)
               .WithMany(sj => sj.Students)
               .UsingEntity<StudentSubject>();

            // IdentityUser

            builder.HasOne(s => s.User)
               .WithOne() 
               .HasForeignKey<Student>(s => s.UserId) 
               .OnDelete(DeleteBehavior.Cascade);

        }
    }

    public class FieldOfStudyDbConfigurations : IEntityTypeConfiguration<FieldOfStudy>
    {
        public void Configure(EntityTypeBuilder<FieldOfStudy> builder)
        {
            builder.Property(g => g.Name)
                .IsRequired();

            // FieldOfStudy - Subject (* - *)

            builder.HasMany(f => f.Subjects)
               .WithMany(sj => sj.FieldsOfStudy)
               .UsingEntity<FieldOfStudySubject>();
        }
    }

    public class FssConfigurations : IEntityTypeConfiguration<FieldOfStudySubject>
    {
        public void Configure(EntityTypeBuilder<FieldOfStudySubject> builder)
        {
            builder.HasKey(fss => new { fss.FieldOfStudyId, fss.SubjectId });
        }
    }

    public class StudentSubjectDbConfigurations : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(ss => new { ss.StudentId, ss.SubjectId });

        }
    }

}
