using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using test_curd_operation_30_05_2024.Data;

namespace test_curd_operation_30_05_2024.Controllers
{
    public class EmptestController : Controller
    {
        private readonly DataContext _dataContext;

        public EmptestController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var data = _dataContext.Emptesttables.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult empadd()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult empadd(Emptesttable emp)
        {
            _dataContext.Emptesttables.Add(emp);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult empedit(int id)
        {
            var data = _dataContext.Emptesttables.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult empedit(Emptesttable emp)
        {
            _dataContext.Emptesttables.Update(emp);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
