using business_logic.Interfaces;
using business_logic.Services;
using data_access;
using data_access.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student_Management.Services;

namespace Student_Management.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;
        private readonly ISubjectService subjectService;
        private readonly UserManager<IdentityUser> userManager;

        public StudentsController(IStudentService studentService, 
            UserManager<IdentityUser> userManager,
            ISubjectService subjectService)
        {
            this.studentService = studentService;
            this.userManager = userManager;
            this.subjectService = subjectService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(studentService.GetGroupsWithStudents());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult GroupDetails(int id, string returnUrl = null)
        {
            var group = studentService.GetGroupDetails(id);
            if (group == null) return NotFound();
            ViewBag.ReturnUrl = returnUrl; 
            return View(group);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddNewStudent()
        {
            LoadGroups();
            return View();
        }

        [HttpPost]
        public IActionResult AddNewStudent(Student newStudent)
        {
            if (!ModelState.IsValid)
            {
                LoadGroups();
                return View(newStudent);
            }

            studentService.Create(newStudent);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            studentService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EditStudent(int id)
        {
            LoadGroups();
            var student = studentService.GetStudent(id);
            if (student == null) return NotFound();
            return View(student);
        }
       
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                LoadGroups();
                return View(student);
            }
            studentService.Edit(student);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        [HttpGet]
        public IActionResult MyProfile()
        {
            var userId = userManager.GetUserId(User);

            var student = studentService.GetStudentByUserId(userId);
            
            if (student == null)
            {
                return NotFound();
            }

            var mandatorySubjects = subjectService.GetMandatorySubjects(student.FieldOfStudyId);     
            var optionalSubjects = subjectService.GetOptionalSubjects();
            var selectedSubjects = subjectService.GetSelectedSubjectsForStudent(student.Id);

            ViewBag.MandatorySubjects = mandatorySubjects;
            ViewBag.OptionalSubjects = optionalSubjects;
            ViewBag.SelectedSubjects = selectedSubjects;


            return View(student);
        }


        private void LoadGroups()
        {
            ViewBag.FieldOfStudyList = new SelectList(studentService.GetGroupsWithStudents(), nameof(FieldOfStudy.Id), nameof(FieldOfStudy.Name));
        }
    }

}
