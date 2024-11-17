using data_access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface IStudentService
    {
        List<FieldOfStudy> GetGroupsWithStudents();
        FieldOfStudy? GetGroupDetails(int id);
        Student? GetStudent(int id);
        void Create(Student student);
        void Edit(Student student);
        void Delete(int id);
        public FieldOfStudy GetFieldOfStudy(int id);
    }
}
