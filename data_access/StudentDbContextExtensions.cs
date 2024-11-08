using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access
{
    public static class StudentDbContextExtensions  
    {

        public static void SeedGroups(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Name = "Computer Science", StudyYear = 1 },
                new Group { Id = 2, Name = "Mechanical Engineering", StudyYear = 2 },
                new Group { Id = 3, Name = "Electrical Engineering", StudyYear = 3 },
                new Group { Id = 4, Name = "Physics", StudyYear = 2 }
            );
        }

        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FullName = "Alice Smith", AverageGrade = 4.5M, GroupId = 1, StudentImage = @"https://i.pinimg.com/564x/d1/2d/ec/d12dece72502dd732b11ec5a66fb9076.jpg" },
                new Student { Id = 2, FullName = "John Doe", AverageGrade = 3.9M, GroupId = 1, StudentImage = null },
                new Student { Id = 3, FullName = "Emily Clark", AverageGrade = 4.1M, GroupId = 2, StudentImage = @"https://i.pinimg.com/enabled_lo/564x/8b/9a/02/8b9a02ac3ea4d3bdb3e1403c34a6c232.jpg" },
                new Student { Id = 4, FullName = "Michael Johnson", AverageGrade = 3.7M, GroupId = 2, StudentImage = @"https://i.pinimg.com/564x/db/c5/e6/dbc5e69ece5632c0885e497d1882d40b.jpg" },
                new Student { Id = 5, FullName = "Sophia Williams", AverageGrade = 4.3M, GroupId = 3, StudentImage = null },
                new Student { Id = 6, FullName = "Liam Brown", AverageGrade = 4.0M, GroupId = 4, StudentImage = null },
                new Student { Id = 7, FullName = "Olivia Davis", AverageGrade = 3.8M, GroupId = 4, StudentImage = @"https://i.pinimg.com/736x/74/94/71/749471a2654703b02997f7357ef57a37.jpg" }
            );
        }

        public static void SeedSubjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Psychology", Ects = 5, IsOptional = true },
                new Subject { Id = 2, Name = "Research Methodology", Ects = 6, IsOptional = true },
                new Subject { Id = 3, Name = "Philosophy of Science", Ects = 4, IsOptional = true },
                new Subject { Id = 4, Name = "Information Systems", Ects = 5, IsOptional = true },
                new Subject { Id = 5, Name = "Cultural Studies", Ects = 3, IsOptional = true }
            );

        }

    }
}
