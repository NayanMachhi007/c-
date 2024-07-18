using databaseconnectivity_lacture_3.Data;
using databaseconnectivity_lacture_3.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace databaseconnectivity_lacture_3.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext _dataContext;

        public StudentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var data = _dataContext.StudentMst.ToList();
            return View(data);
        }

        [HttpGet]

        public IActionResult studentadd()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult studentadd(StudentMst student)
        {
            _dataContext.StudentMst.Add(student);
           _dataContext.SaveChanges();

            return RedirectToAction("Index");
            
        }


        [HttpGet]

        public IActionResult studentedit(int id)
        {
            var data = _dataContext.StudentMst.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult studentedit(StudentMst student)
        {
            _dataContext.StudentMst.Update(student);
            _dataContext.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
