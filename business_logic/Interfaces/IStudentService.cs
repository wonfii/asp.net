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
        List<Group> GetGroupsWithStudents();
        Group? GetGroupDetails(int id);
        Student? GetStudent(int id);
        void Create(Student student);
        void Edit(Student student);
        void Delete(int id);
    }
}
