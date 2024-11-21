using data_access.Entities;
using Microsoft.EntityFrameworkCore;

namespace data_access
{
    public static class StudentDbContextExtensions  
    {

        public static void SeedFieldsOfStudy(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FieldOfStudy>().HasData(
                new FieldOfStudy { Id = 1, Name = "Computer Science"},
                new FieldOfStudy { Id = 2, Name = "Mechanical Engineering"},
                new FieldOfStudy { Id = 3, Name = "Electrical Engineering"},
                new FieldOfStudy { Id = 4, Name = "Physics"},
                new FieldOfStudy { Id = 5, Name = "Applied Information Technology" },
                new FieldOfStudy { Id = 6, Name = "Digital Engineering" }
            );
        }

        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FullName = "Alice Smith", AverageGrade = 4.5M, FieldOfStudyId = 1, StudentImage = @"https://i.pinimg.com/564x/d1/2d/ec/d12dece72502dd732b11ec5a66fb9076.jpg", Email = "alice.smith@student.uni" },
                new Student { Id = 2, FullName = "John Doe", AverageGrade = 3.9M, FieldOfStudyId = 1, StudentImage = null, Email = "john.doe@student.uni" },
                new Student { Id = 3, FullName = "Emily Clark", AverageGrade = 4.1M, FieldOfStudyId = 2, StudentImage = @"https://i.pinimg.com/enabled_lo/564x/8b/9a/02/8b9a02ac3ea4d3bdb3e1403c34a6c232.jpg", Email = "emily.clark@student.uni" },
                new Student { Id = 4, FullName = "Michael Johnson", AverageGrade = 3.7M, FieldOfStudyId = 2, StudentImage = @"https://i.pinimg.com/564x/db/c5/e6/dbc5e69ece5632c0885e497d1882d40b.jpg", Email = "michael.johnson@student.uni" },
                new Student { Id = 5, FullName = "Sophia Williams", AverageGrade = 4.3M, FieldOfStudyId = 3, StudentImage = null, Email = "sophia.williams@student.uni" },
                new Student { Id = 6, FullName = "Liam Brown", AverageGrade = 4.0M, FieldOfStudyId = 4, StudentImage = null, Email = "liam.brown@student.uni" },
                new Student { Id = 7, FullName = "Olivia Davis", AverageGrade = 3.8M, FieldOfStudyId = 4, StudentImage = @"https://i.pinimg.com/736x/74/94/71/749471a2654703b02997f7357ef57a37.jpg", Email = "olivia.davis@student.uni" }
            );
        }

        public static void SeedSubjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Psychology", Ects = 5, IsOptional = true },
                new Subject { Id = 2, Name = "Research Methodology", Ects = 6, IsOptional = true },
                new Subject { Id = 3, Name = "Philosophy of Science", Ects = 4, IsOptional = true },
                new Subject { Id = 4, Name = "Information Systems", Ects = 5, IsOptional = true },
                new Subject { Id = 5, Name = "Cultural Studies", Ects = 3, IsOptional = true },

                // Computer Science
                new Subject { Id = 6, Name = "Calculus", Ects = 4, IsOptional = false },
                new Subject { Id = 7, Name = "Operating Systems", Ects = 5, IsOptional = false },
                new Subject { Id = 8, Name = "Programming", Ects = 8, IsOptional = false },

                // Mechanical Engineering
                new Subject { Id = 9, Name = "Structural Analysis", Ects = 5, IsOptional = false },
                new Subject { Id = 10, Name = "Computer Aided Engineering", Ects = 3, IsOptional = false },
                new Subject { Id = 11, Name = "Energy Systems", Ects = 6, IsOptional = false },

                // Electrical Engineering
                new Subject { Id = 12, Name = "Structural Analysis", Ects = 5, IsOptional = false },
                new Subject { Id = 13, Name = "Electrical Energy Production Transportation and Distribution", Ects = 3, IsOptional = false },
                new Subject { Id = 14, Name = "Trafic Infrastructure Design", Ects = 6, IsOptional = false },

                // Physics
                new Subject { Id = 15, Name = "Physics", Ects = 5, IsOptional = false },
                new Subject { Id = 16, Name = "Linear Algebra", Ects = 3, IsOptional = false },
                new Subject { Id = 17, Name = "Introduction to Biological Physics", Ects = 6, IsOptional = false },

                // Applied Information Technology
                new Subject { Id = 18, Name = "Databases", Ects = 5, IsOptional = false },
                new Subject { Id = 19, Name = "Software Engineering", Ects = 6, IsOptional = false },
                new Subject { Id = 20, Name = "Interaction Design", Ects = 6, IsOptional = false },

                // Digital Engineering
                new Subject { Id = 21, Name = "Programming for Engineers", Ects = 5, IsOptional = false },
                new Subject { Id = 22, Name = "Artificial Intelligence for Smart Technologies", Ects = 3, IsOptional = false },
                new Subject { Id = 23, Name = "Introduction to IOT", Ects = 6, IsOptional = false }
            );

        }

        public static void SeedFieldsOfStudySubjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FieldOfStudySubject>().HasData(
                new FieldOfStudySubject { FieldOfStudyId = 1, SubjectId = 6 },
                new FieldOfStudySubject { FieldOfStudyId = 1, SubjectId = 7 },
                new FieldOfStudySubject { FieldOfStudyId = 1, SubjectId = 8 },
                new FieldOfStudySubject { FieldOfStudyId = 1, SubjectId = 18 },

                new FieldOfStudySubject { FieldOfStudyId = 2, SubjectId = 9 },
                new FieldOfStudySubject { FieldOfStudyId = 2, SubjectId = 10 },
                new FieldOfStudySubject { FieldOfStudyId = 2, SubjectId = 11 },
                new FieldOfStudySubject { FieldOfStudyId = 2, SubjectId = 12 },


                new FieldOfStudySubject { FieldOfStudyId = 3, SubjectId = 12 },
                new FieldOfStudySubject { FieldOfStudyId = 3, SubjectId = 16 },
                new FieldOfStudySubject { FieldOfStudyId = 3, SubjectId = 13 },
                new FieldOfStudySubject { FieldOfStudyId = 3, SubjectId = 14 },
                new FieldOfStudySubject { FieldOfStudyId = 3, SubjectId = 11 },


                new FieldOfStudySubject { FieldOfStudyId = 4, SubjectId = 15 },
                new FieldOfStudySubject { FieldOfStudyId = 4, SubjectId = 16 },
                new FieldOfStudySubject { FieldOfStudyId = 4, SubjectId = 17 },

                new FieldOfStudySubject { FieldOfStudyId = 5, SubjectId = 18 },
                new FieldOfStudySubject { FieldOfStudyId = 5, SubjectId = 19 },
                new FieldOfStudySubject { FieldOfStudyId = 5, SubjectId = 20 },
                new FieldOfStudySubject { FieldOfStudyId = 5, SubjectId = 16 },

                new FieldOfStudySubject { FieldOfStudyId = 6, SubjectId = 21 },
                new FieldOfStudySubject { FieldOfStudyId = 6, SubjectId = 22 },
                new FieldOfStudySubject { FieldOfStudyId = 6, SubjectId = 23 }

            );
        }

    }
}
