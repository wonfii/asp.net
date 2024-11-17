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
        private readonly IRepository<FieldOfStudy> groupRepo;
        public StudentService(IRepository<Student> studentRepo, IRepository<FieldOfStudy> groupRepo)
        {
            this.studentRepo = studentRepo;
            this.groupRepo = groupRepo;
        }

        public List<FieldOfStudy> GetGroupsWithStudents()
        {
            return groupRepo.Get(
                includeProperties: new string[] { "Students" }
            ).ToList();
        }

        public FieldOfStudy? GetGroupDetails(int id)
        {
            var group = groupRepo.Get(
                filter: g => g.Id == id,
                includeProperties: new[] { "Students" }
            ).FirstOrDefault();

            return group;
        }

        public void Create(Student newStudent)
        {
            studentRepo.Insert(newStudent);
            studentRepo.Save();

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

        public FieldOfStudy GetFieldOfStudy(int id)
        {
            return groupRepo.GetByID(id);
        }

        public Student GetStudent(int id)
        {
            return studentRepo.GetByID(id);
        }
    }

}

