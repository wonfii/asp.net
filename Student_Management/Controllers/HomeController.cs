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

        public HomeController(IStudentService studentService)
        {
            this.studentService = studentService;        
        }      

        public IActionResult Index()
        {
            var groups = studentService.GetGroupsWithStudents();
            return View(groups);
        }

        public IActionResult FieldOfStudyDetails(int id, string returnUrl = null)
        {
            var group = studentService.GetFieldOfStudy(id);
            if (group == null) return NotFound();
            ViewBag.ReturnUrl = returnUrl;
            return View(group);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
