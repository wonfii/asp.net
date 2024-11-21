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
        private readonly IRepository<FieldOfStudySubject> fosSubRepo;
        private readonly IRepository<StudentSubject> studentSubRepo;
        public SubjectService(IRepository<Subject> subjectRepo,
            IRepository<FieldOfStudySubject> fosSubRepo,
            IRepository<StudentSubject> studentSubRepo)
        {
            this.subjectRepo = subjectRepo;
            this.fosSubRepo = fosSubRepo;
            this.studentSubRepo = studentSubRepo;
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

        public List<Subject> GetOptionalSubjects()
        {
            return subjectRepo.Get(
                filter: sub => sub.IsOptional == true
            ).ToList();
        }

        public List<Subject> GetSelectedSubjectsForStudent(int studentId)
        {
            var selectedSubjectIds = studentSubRepo.Get(
                filter: ss => ss.StudentId == studentId
            ).Select(ss => ss.SubjectId).ToList();

            return subjectRepo.Get(
                filter: sub => selectedSubjectIds.Contains(sub.Id)
            ).ToList();
        }

        public List<Subject> GetMandatorySubjects(int fieldOfStudyId)
        {
            var allSubjectIds = fosSubRepo.Get(
                filter: fosSub => fosSub.FieldOfStudyId == fieldOfStudyId
            ).Select(fosSub => fosSub.SubjectId).ToList();

            return subjectRepo.Get(
                filter: sub => allSubjectIds.Contains(sub.Id)
            ).ToList();
        }

        public Subject GetSubjectById(int id)
        {
            return subjectRepo.GetByID(id);
        }
    }
}
