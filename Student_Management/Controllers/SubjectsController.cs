using business_logic.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Student_Management.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly IAddSubjectService addSubjectService;
        private readonly ISubjectService subjectService;
        private readonly IStudentService studentService;
        private readonly UserManager<IdentityUser> userManager;

        public SubjectsController(IAddSubjectService addSubjectService,
            IStudentService studentService,
            UserManager<IdentityUser> userManager,
            ISubjectService subjectService)
        {
            this.studentService = studentService;
            this.userManager = userManager;
            this.addSubjectService = addSubjectService;
            this.subjectService = subjectService;
        }

        public IActionResult Index()
        {
            return View(subjectService.GetOptionalSubjects().ToList());
        }

        public IActionResult AddOptionalSubject(int subjectId, string returnUrl)
        {
            var userId = userManager.GetUserId(User);

            var student = studentService.GetStudentByUserId(userId);

            if (student == null)
            {
                return NotFound();
            }
            addSubjectService.AddSubject(student.Id,subjectId);
            return Redirect(returnUrl);
        }

        public IActionResult RemoveOptionalSubject(int subjectId, string returnUrl)
        {
            var userId = userManager.GetUserId(User);

            var student = studentService.GetStudentByUserId(userId);

            if (student == null)
            {
                return NotFound();
            }
            addSubjectService.RemoveSubject(student.Id, subjectId);
            return Redirect(returnUrl);
        }
    }
}
