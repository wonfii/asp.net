using data_access.Configuration;
using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access
{
    public class StudentDbContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public StudentDbContext() : base() { }
        public StudentDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentDbConfigurations());

            modelBuilder.SeedGroups();
            modelBuilder.SeedStudents();
            modelBuilder.SeedSubjects();
        }

    }
}
