using business_logic.Interfaces;
using data_access;
using data_access.Entities;
using data_access.Interfaces;
using Microsoft.EntityFrameworkCore;
using Student_Management.Services;

namespace Student_Management.Services {

    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> studentRepo;
        private readonly IRepository<Group> groupRepo;
        public StudentService(IRepository<Student> studentRepo, IRepository<Group> groupRepo)
        {
            this.studentRepo = studentRepo;
            this.groupRepo = groupRepo;
        }

        public List<Group> GetGroupsWithStudents()
        {
            return groupRepo.Get(
                includeProperties: new string[] { "Students" }
            ).ToList();
        }

        public Group? GetGroupDetails(int id)
        {
            var group = groupRepo.Get(
                filter: g => g.Id == id,
                includeProperties: new[] { "Students" }
            ).FirstOrDefault();

            return group;
        }

        public void Create(Student newStudent)
        {
            Console.WriteLine($"here");
            studentRepo.Insert(newStudent);
            studentRepo.Save();

            Console.WriteLine($"Student {newStudent.FullName} added successfully");
        }

        public void Delete(int id)
        {
            studentRepo.Delete(id);
            studentRepo.Save();
        }

        public void Edit(Student student)
        {
            studentRepo.Update(student);
            studentRepo.Save();
        }

        public Student GetStudent(int id)
        {
            return studentRepo.GetByID(id);
        }
    }

}

