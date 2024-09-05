using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }



        /*
        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber
            )
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParam"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null) 
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["currentFilter"] = searchString;

            var students = from student in _context.Students
                           select student;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(student => 
                student.LastName.Contains(searchString) || 
                student.FirstMidName.Contains(searchString));
            }
            switch (sortOrder) 
            {
                case "name_desc":
                    students = students.OrderByDescending(student => student.LastName);
                    break;
                case "firstname_desc":
                    students = students.OrderByDescending(student => student.FirstMidName);
                    break;
                case "Date":
                    students = students.OrderBy(student => student.EnrollmentDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(student => student.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(student => student.LastName);
                    break;
            }

            int pageSize = 3;
            return View(await _context.Students.ToListAsync());
        }
        */
        //Creat get, haarab vaatest andmed, mida create meetod vajab.
        public IActionResult Create() 
        { 
          return View();
        }

        //Create meetod, sisestab andmebaasi uuse õpilase. insert new student into database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID, LastName, FirstMidName, EnrollmentDate")]Student student)
        {
            if (ModelState.IsValid) 
            { 
              _context.Students.Add(student);
              await _context.SaveChangesAsync();
              return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        //student delete meetod
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        //Delete post meetod teeb andmebaasi vajaliku muudatuse
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student=await _context.Students.FindAsync(id); //otsime õpilasi id järgi

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task <IActionResult> Details(int? id)//details meeetod, naitab student andmeid
        {
            if (id == null)
            {
                return NotFound();
            }
            var student= await _context.Students.FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

    }
}
