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

            // Student - Group (* - 1)

            builder.HasOne(st => st.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(st => st.GroupId);

            // Student - Subject (* - *)

            builder.HasMany(st => st.Subjects)
                .WithMany(sj => sj.Students);

        }
    }

    public class GroupDbConfigurations : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(g => g.Name)
                .IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_Group_StudyYear", "StudyYear >= 1 AND StudyYear <= 4"));
        }
    }
}
