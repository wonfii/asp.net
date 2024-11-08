using business_logic.Interfaces;
using business_logic.Services;
using data_access.Entities;
using Microsoft.AspNetCore.Mvc;
using Student_Management.Services;

namespace Student_Management.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly IAddSubjectService addSubjectService;

        public SubjectsController(IAddSubjectService addSubjectService)
        {
            this.addSubjectService = addSubjectService;

        }

        public IActionResult Index()
        {
            return View(addSubjectService.GetSubjects().ToList());
        }

        public IActionResult AddOptionalSubject(int subjectId, string returnUrl)
        {
            addSubjectService.AddSubject(subjectId);
            return Redirect(returnUrl);
        }

        public IActionResult DeleteOptionalSubject(int subjectId, string returnUrl)
        {
            addSubjectService.RemoveSubject(subjectId);
            return Redirect(returnUrl);
        }
    }
}
