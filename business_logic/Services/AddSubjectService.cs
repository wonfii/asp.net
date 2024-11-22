using business_logic.Interfaces;
using data_access.Entities;
using data_access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Services
{
    public class AddSubjectService : IAddSubjectService
    {
        private readonly IRepository<StudentSubject> studentSubjectRepo;

        public AddSubjectService(IRepository<StudentSubject> studentSubjectRepo)
        {
            this.studentSubjectRepo = studentSubjectRepo;
        }
        public void AddSubject(int studentId, int subjectId)
        {
            var exists = studentSubjectRepo.Get(
                filter: ss => ss.StudentId == studentId && ss.SubjectId == subjectId
            ).Any();

            if (!exists)
            {
                var studentSubject = new StudentSubject
                {
                    StudentId = studentId,
                    SubjectId = subjectId
                };

                studentSubjectRepo.Insert(studentSubject);
                studentSubjectRepo.Save();
            }
            else
            {
                Console.WriteLine("The subject is already added for this student.");
            }
        }

        public void RemoveSubject(int studentId, int subjectId)
        {
            var studentSubject = studentSubjectRepo.Get(
                filter: ss => ss.StudentId == studentId && ss.SubjectId == subjectId
            ).FirstOrDefault();

            if (studentSubject != null)
            {
                studentSubjectRepo.Delete(studentSubject);
                studentSubjectRepo.Save();
            }
            else
            {
                throw new Exception("The specified subject is not linked to the student.");
            }
        }

    }
}
