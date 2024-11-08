using business_logic.Interfaces;
using data_access;
using data_access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly StudentDbContext context;

        public SubjectService(StudentDbContext context)
        {
            this.context = context;
        }

        public void Create(Subject subject)
        {
            context.Subjects.Add(subject);
            context.SaveChanges(); ;
        }

        public void Delete(int id)
        {
            var subject = context.Subjects.Find(id);
            if (subject == null) return;

            context.Subjects.Remove(subject);
            context.SaveChanges();
        }

        public void Edit(Subject subject)
        {
            context.Subjects.Update(subject);
            context.SaveChanges();
        }

        public List<Subject> GetAllSubjects()
        {
            return context.Subjects.ToList();
        }

		public List<Subject> GetOptionalSubjects(List<int> ids)
		{
			return context.Subjects.Where(sub => ids.Contains(sub.Id)).ToList();
		}

		public Subject GetSubjectById(int id)
        {
           var subject = context.Subjects.Find(id);
           return subject; 
        }
    }
}
