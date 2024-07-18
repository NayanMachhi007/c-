using Microsoft.AspNetCore.Mvc;
using practice_database.Data;

namespace practice_database.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext _dataContext;

        public StudentController(DataContext dataContext) { 
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {   
            var data =_dataContext.students.ToList();
            return View(data);
        }
    }
}
