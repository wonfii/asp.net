using data_access;
using data_access.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Student_Management.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentDbContext context;

        public StudentsController(StudentDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View(context.Groups.Include(g => g.Students).ToList());
        }

        private void LoadGroups()
        {
            ViewBag.GroupList = new SelectList(context.Groups.ToList(), nameof(Group.Id), nameof(Group.Name));
        }

        public IActionResult GroupDetails(int id)
        {

            var group = context.Groups.Include(g => g.Students).FirstOrDefault(g => g.Id == id);

            if (group == null) { return NotFound(); }

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

            context.Students.Add(newStudent);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            var student = context.Students.Find(id);
            if (student == null) { return NotFound(); }

            context.Students.Remove(student);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult EditStudent(int id)
        {
            var student = context.Students.Find(id);
            if (student == null) { return NotFound(); }

            LoadGroups();

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

            context.Students.Update(student);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));  
        }


    }
}
