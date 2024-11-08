using data_access.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface IAddSubjectService
    {
        List<Subject> GetSubjects();
        void AddSubject(int subjectId);
        void RemoveSubject(int subjectId);

        public bool IsSubjectAdded(int subjectId);
    }
}
