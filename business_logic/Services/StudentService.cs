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

        public Student GetStudentByUserId(string userId)
        {
            return studentRepo.Get(
                filter: s => s.UserId == userId,
                includeProperties: new[] { "FieldOfStudy" }
            ).FirstOrDefault();
        }
        public void UpdateStudentUserId(string email, string userId)
        {
            var student = studentRepo.Get(
                filter: s => s.Email == email
            ).FirstOrDefault();

            if (student != null)
            {
                student.UserId = userId;
                studentRepo.Update(student);
                studentRepo.Save();
            }
            else
            {
                throw new Exception($"Student with email {email} not found.");
            }

        }



    }

}

