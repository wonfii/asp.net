using data_access;
using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using Student_Management.Services;

namespace Student_Management.Services {

    public interface IStudentService
    {
        //CRUD Interface
        List<Group> GetGroupsWithStudents();
        Group? GetGroupDetails(int id);
        Student? GetStudent(int id);
        void Create(Student product);
        void Edit(Student product);
        void Delete(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly StudentDbContext context;

        public StudentService(StudentDbContext context)
        {
            this.context = context;
        }

        public List<Group> GetGroupsWithStudents()
        {
            return context.Groups.Include(g => g.Students).ToList();
        }

        public Group? GetGroupDetails(int id)
        {
            return context.Groups.Include(g => g.Students).FirstOrDefault(g => g.Id == id);
        }

        public void Create(Student newStudent)
        {
            context.Students.Add(newStudent);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = context.Students.Find(id);
            if (student == null) return;

            context.Students.Remove(student);
            context.SaveChanges();
        }

        public void Edit(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            var student = context.Students.Find(id);
            if (student == null) { return null; }
            return student;
        }
    }

}

