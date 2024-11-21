using data_access.Configuration;
using data_access.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace data_access
{
    public class StudentDbContext : IdentityDbContext<IdentityUser> 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<FieldOfStudy> FieldsOfStudy { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<FieldOfStudySubject> FieldOfStudySubject { get; set; }
        public DbSet<StudentSubject> StudentSubject { get; set; }
        public StudentDbContext() : base() { }
        public StudentDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentDbConfigurations());
            modelBuilder.ApplyConfiguration(new FieldOfStudyDbConfigurations());
            modelBuilder.ApplyConfiguration(new FieldOfStudyDbConfigurations());
            modelBuilder.ApplyConfiguration(new StudentSubjectDbConfigurations());

            modelBuilder.SeedFieldsOfStudy();
            modelBuilder.SeedStudents();
            modelBuilder.SeedSubjects();
            modelBuilder.SeedFieldsOfStudySubjects();
        }

    }
}
