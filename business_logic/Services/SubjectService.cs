using business_logic.Interfaces;
using data_access;
using data_access.Entities;
using data_access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly IRepository<Subject> subjectRepo;
        public SubjectService(IRepository<Subject> subjectRepo)
        {
            this.subjectRepo = subjectRepo;
        }

        public void Create(Subject subject)
        {
            subjectRepo.Insert(subject);
            subjectRepo.Save();
        }

        public void Delete(int id)
        {
            subjectRepo.Delete(id);
            subjectRepo.Save();
        }

        public void Edit(Subject subject)
        {
            subjectRepo.Update(subject);
            subjectRepo.Save();
        }

        public List<Subject> GetAllSubjects()
        {
            return subjectRepo.Get().ToList();
        }

		public List<Subject> GetOptionalSubjects(List<int> ids)
		{
            return subjectRepo.Get(sub => ids.Contains(sub.Id)).ToList();
		}

		public Subject GetSubjectById(int id)
        {
            return subjectRepo.GetByID(id);
        }
    }
}
