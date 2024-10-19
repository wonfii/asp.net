using data_access;
using data_access.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student_Management.Services;

namespace Student_Management.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            return View(studentService.GetGroupsWithStudents());
        }

        public IActionResult GroupDetails(int id)
        {
            var group = studentService.GetGroupDetails(id);
            if (group == null) return NotFound();
            return View(group);
        }

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

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            studentService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

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

        private void LoadGroups()
        {
            ViewBag.GroupList = new SelectList(studentService.GetGroupsWithStudents(), nameof(Group.Id), nameof(Group.Name));
        }
    }

}
