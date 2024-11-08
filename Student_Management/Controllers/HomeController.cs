using business_logic.Interfaces;
using business_logic.Services;
using data_access.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Management.Models;
using Student_Management.Services;
using System.Diagnostics;

namespace Student_Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService studentService;

        private readonly ISubjectService subjectService;

        public HomeController(IStudentService studentService, ISubjectService subjectService)
        {
            this.studentService = studentService;
            this.subjectService = subjectService;
        
        }      

        public IActionResult Index()
        {
            var groups = studentService.GetGroupsWithStudents();

            ViewBag.Subjects = subjectService.GetAllSubjects();
            return View(groups);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
