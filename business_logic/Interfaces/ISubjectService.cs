using data_access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface ISubjectService
    {
        List<Subject> GetAllSubjects();
        List<Subject> GetOptionalSubjects(List<int> ids);

        Subject GetSubjectById(int id);

        void Create(Subject subject);
        void Edit(Subject subject);
        void Delete(int id);
    }
}
